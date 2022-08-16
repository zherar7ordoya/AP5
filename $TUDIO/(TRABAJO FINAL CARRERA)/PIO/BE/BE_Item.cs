namespace BE
{
    public class BE_Item : Entidad
    {
        public int ItemID { get; set; }
        public string CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string ProveedorID { get; set; }
    }
}
