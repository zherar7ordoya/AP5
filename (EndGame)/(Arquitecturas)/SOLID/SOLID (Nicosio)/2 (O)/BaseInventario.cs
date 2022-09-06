namespace _2__O_
{
    abstract class BaseInventario
    {
        /// <summary>
        /// PROTECTED
        /// Con "protected" consigo que la propiedad "producto" sea accesible
        /// solo para las clases que heredan de "BaseInventario".
        /// </summary>
        protected Producto producto;

        public Producto Producto { get => producto; set => producto = value; }

        /// <summary>
        /// Este constructor impactará en las clases que hereden, las que
        /// deberán suplir el parámetro "producto" apelando a la instrucción
        /// "base".
        /// </summary>
        /// <param name="producto"></param>
        public BaseInventario(Producto producto)
        {
            this.producto = producto;
        }

        public override string ToString()
        {
            return producto.ToString();
        }

        public abstract double CalcularProducto();
    }
}
