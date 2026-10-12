using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    /// <summary>
    /// Operaciones de la tabla Tbl_Sucursales en SQL Server.
    /// Todas las consultas usan parámetros (@...) para evitar inyección SQL.
    /// </summary>
    public class SucursalDatos
    {
        private const string ColumnasSelect =
            "SELECT CodigoSucursal, NombreSucursal, DireccionSucursal, TipoSucursal, EstadoSucursal, Observaciones " +
            "FROM dbo.Tbl_Sucursales ";

        /// <summary>Consultar: devuelve todas las sucursales (activas e inactivas).</summary>
        public List<Sucursal> Listar()
        {
            string sql = ColumnasSelect + "ORDER BY CodigoSucursal";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sql, conexion))
            {
                conexion.Open();
                return LeerSucursales(comando);
            }
        }

        /// <summary>Buscar: filtra por nombre, dirección o tipo de sucursal.</summary>
        public List<Sucursal> Buscar(string texto)
        {
            string sql = ColumnasSelect +
                "WHERE NombreSucursal LIKE @Texto OR DireccionSucursal LIKE @Texto OR TipoSucursal LIKE @Texto " +
                "ORDER BY CodigoSucursal";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sql, conexion))
            {
                comando.Parameters.Add("@Texto", SqlDbType.VarChar, 102).Value = "%" + texto + "%";
                conexion.Open();
                return LeerSucursales(comando);
            }
        }

        /// <summary>Agregar: inserta una sucursal nueva. El código lo genera la base de datos (IDENTITY).</summary>
        public bool Insertar(Sucursal sucursal)
        {
            string sql =
                "INSERT INTO dbo.Tbl_Sucursales (NombreSucursal, DireccionSucursal, TipoSucursal, EstadoSucursal, Observaciones) " +
                "VALUES (@NombreSucursal, @DireccionSucursal, @TipoSucursal, @EstadoSucursal, @Observaciones)";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sql, conexion))
            {
                AgregarParametros(comando, sucursal);
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>Editar: actualiza los datos de una sucursal existente.</summary>
        public bool Actualizar(Sucursal sucursal)
        {
            string sql =
                "UPDATE dbo.Tbl_Sucursales SET " +
                "NombreSucursal = @NombreSucursal, DireccionSucursal = @DireccionSucursal, TipoSucursal = @TipoSucursal, " +
                "EstadoSucursal = @EstadoSucursal, Observaciones = @Observaciones " +
                "WHERE CodigoSucursal = @CodigoSucursal";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sql, conexion))
            {
                AgregarParametros(comando, sucursal);
                comando.Parameters.Add("@CodigoSucursal", SqlDbType.Int).Value = sucursal.CodigoSucursal;
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Eliminar (borrado lógico): no borra la fila, solo la marca como inactiva.
        /// Así no se rompen las llaves foráneas de Tbl_Usuarios y Tbl_Inventario.
        /// Devuelve false si la sucursal no existe o ya estaba inactiva.
        /// </summary>
        public bool Eliminar(int codigoSucursal)
        {
            string sql =
                "UPDATE dbo.Tbl_Sucursales SET EstadoSucursal = 0 " +
                "WHERE CodigoSucursal = @CodigoSucursal AND EstadoSucursal = 1";

            using (SqlConnection conexion = Conexion.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(sql, conexion))
            {
                comando.Parameters.Add("@CodigoSucursal", SqlDbType.Int).Value = codigoSucursal;
                conexion.Open();
                return comando.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>Parámetros comunes de Insertar y Actualizar (tamaños iguales a la tabla).</summary>
        private void AgregarParametros(SqlCommand comando, Sucursal sucursal)
        {
            comando.Parameters.Add("@NombreSucursal", SqlDbType.VarChar, 45).Value = sucursal.NombreSucursal;
            comando.Parameters.Add("@DireccionSucursal", SqlDbType.VarChar, 100).Value = sucursal.DireccionSucursal;
            comando.Parameters.Add("@TipoSucursal", SqlDbType.VarChar, 45).Value = sucursal.TipoSucursal;
            comando.Parameters.Add("@EstadoSucursal", SqlDbType.Bit).Value = sucursal.EstadoSucursal;

            // Observaciones es opcional: si viene vacía se guarda NULL.
            if (string.IsNullOrEmpty(sucursal.Observaciones))
                comando.Parameters.Add("@Observaciones", SqlDbType.VarChar, 150).Value = DBNull.Value;
            else
                comando.Parameters.Add("@Observaciones", SqlDbType.VarChar, 150).Value = sucursal.Observaciones;
        }

        /// <summary>Convierte cada fila del resultado en un objeto Sucursal.</summary>
        private List<Sucursal> LeerSucursales(SqlCommand comando)
        {
            List<Sucursal> lista = new List<Sucursal>();

            using (SqlDataReader lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    Sucursal sucursal = new Sucursal();
                    sucursal.CodigoSucursal = Convert.ToInt32(lector["CodigoSucursal"]);
                    sucursal.NombreSucursal = lector["NombreSucursal"].ToString();
                    sucursal.DireccionSucursal = lector["DireccionSucursal"].ToString();
                    sucursal.TipoSucursal = lector["TipoSucursal"].ToString();
                    sucursal.EstadoSucursal = Convert.ToBoolean(lector["EstadoSucursal"]);
                    sucursal.Observaciones = lector["Observaciones"] == DBNull.Value ? "" : lector["Observaciones"].ToString();
                    lista.Add(sucursal);
                }
            }

            return lista;
        }
    }
}
