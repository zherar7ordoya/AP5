namespace _1S
{
    public class Producto
    {
        public Producto(string descripcion, double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }

        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
