using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    /// <summary>
    /// Crea las conexiones a SQL Server.
    /// La cadena de conexión se lee del App.config del proyecto Presentación
    /// (nombre "Ferreteria"), así no se escribe dentro del código.
    /// </summary>
    public static class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            ConnectionStringSettings configuracion = ConfigurationManager.ConnectionStrings["Ferreteria"];
            if (configuracion == null)
                throw new InvalidOperationException("No se encontró la cadena de conexión 'Ferreteria' en App.config.");

            return new SqlConnection(configuracion.ConnectionString);
        }
    }
}
