namespace _1S
{
    public class Item
    {
        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public double Subtotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}
