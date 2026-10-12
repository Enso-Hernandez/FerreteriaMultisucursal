using System.Collections.Generic;
using Datos;
using Entidad;

namespace Negocio
{
    /// <summary>
    /// Reglas y validaciones de Sucursales.
    /// Presentación llama a esta clase; esta clase llama a SucursalDatos.
    /// Los métodos que guardan devuelven "" si todo salió bien,
    /// o un mensaje explicando el problema.
    /// </summary>
    public class SucursalNegocio
    {
        private readonly SucursalDatos sucursalDatos = new SucursalDatos();

        public List<Sucursal> Listar()
        {
            return sucursalDatos.Listar();
        }

        /// <summary>Si el texto está vacío devuelve todas las sucursales.</summary>
        public List<Sucursal> Buscar(string texto)
        {
            texto = (texto ?? "").Trim();
            if (texto == "")
                return sucursalDatos.Listar();

            return sucursalDatos.Buscar(texto);
        }

        public string Insertar(Sucursal sucursal)
        {
            string error = Validar(sucursal);
            if (error != "") return error;

            return sucursalDatos.Insertar(sucursal) ? "" : "No se pudo agregar la sucursal.";
        }

        public string Actualizar(Sucursal sucursal)
        {
            if (sucursal.CodigoSucursal <= 0) return "Selecciona una sucursal válida para editar.";

            string error = Validar(sucursal);
            if (error != "") return error;

            return sucursalDatos.Actualizar(sucursal) ? "" : "No se encontró la sucursal que se quiere editar.";
        }

        /// <summary>Borrado lógico: la sucursal pasa a estado inactivo.</summary>
        public string Eliminar(int codigoSucursal)
        {
            if (codigoSucursal <= 0) return "Selecciona una sucursal válida para eliminar.";

            return sucursalDatos.Eliminar(codigoSucursal) ? "" : "La sucursal no existe o ya está inactiva.";
        }

        /// <summary>Quita espacios sobrantes y revisa obligatorios y tamaños de Tbl_Sucursales.</summary>
        private string Validar(Sucursal sucursal)
        {
            sucursal.NombreSucursal = (sucursal.NombreSucursal ?? "").Trim();
            sucursal.DireccionSucursal = (sucursal.DireccionSucursal ?? "").Trim();
            sucursal.TipoSucursal = (sucursal.TipoSucursal ?? "").Trim();
            sucursal.Observaciones = (sucursal.Observaciones ?? "").Trim();

            if (sucursal.NombreSucursal == "") return "El nombre de la sucursal es obligatorio.";
            if (sucursal.NombreSucursal.Length > 45) return "El nombre no puede tener más de 45 caracteres.";

            if (sucursal.DireccionSucursal == "") return "La dirección es obligatoria.";
            if (sucursal.DireccionSucursal.Length > 100) return "La dirección no puede tener más de 100 caracteres.";

            if (sucursal.TipoSucursal == "") return "El tipo de sucursal es obligatorio.";
            if (sucursal.TipoSucursal.Length > 45) return "El tipo de sucursal no puede tener más de 45 caracteres.";

            if (sucursal.Observaciones.Length > 150) return "Las observaciones no pueden tener más de 150 caracteres.";

            return "";
        }
    }
}
