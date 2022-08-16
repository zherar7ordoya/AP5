namespace _2__O_
{
    class InventarioAlimento : BaseInventario
    {
        /// <summary>
        /// "base" es una apelación al constructor del padre, una apelación a
        /// la que estoy obligado (pues el padre estableció su propio
        /// constructor, reemplazó el original vacío).
        /// </summary>
        /// <param name="producto"></param>
        public InventarioAlimento(Producto producto) : base(producto) { }

        public override double CalcularProducto()
        {
            producto.Precio *= 1.2;
            return producto.Precio;
        }
    }
}
