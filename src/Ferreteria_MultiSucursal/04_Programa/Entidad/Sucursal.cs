namespace Entidad
{
    /// <summary>
    /// Representa un registro de la tabla Tbl_Sucursales.
    /// Los nombres de las propiedades son iguales a los de las columnas.
    /// </summary>
    public class Sucursal
    {
        public int CodigoSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string DireccionSucursal { get; set; }
        public string TipoSucursal { get; set; }
        public bool EstadoSucursal { get; set; }   // true = activa, false = inactiva
        public string Observaciones { get; set; }  // opcional
    }
}
