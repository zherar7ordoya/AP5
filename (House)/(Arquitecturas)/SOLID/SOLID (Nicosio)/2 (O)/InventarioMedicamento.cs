namespace _2__O_
{
    class InventarioMedicamento : BaseInventario
    {
        /// <summary>
        /// Sobre este constructor, ver nota en "InventarioAlimento". Pero, en
        /// resumen: "base" es una obligación impuesta por el constructor (él
        /// único constructor) definido en la súper-clase (que ha reemplazado
        /// su constructor vacío por defecto por uno que demanda un parámetro).
        /// </summary>
        /// <param name="producto"></param>
        public InventarioMedicamento(Producto producto) : base(producto) { }

        public override double CalcularProducto()
        {
            producto.Precio *= 0.8;
            return producto.Precio;
        }
    }
}
