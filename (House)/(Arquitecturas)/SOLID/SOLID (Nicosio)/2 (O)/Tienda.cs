using System;
using System.Collections.Generic;

namespace _2__O_
{
    class Tienda
    {
        private List<BaseInventario> productos;

        public Tienda(List<BaseInventario> productos)
        {
            this.productos = productos;
        }

        public void CalcularInventario()
        {
            double total = 0;

            foreach (var producto in productos)
            {
                producto.CalcularProducto();
                Console.WriteLine(producto);
                total += producto.Producto.Precio;
            }

            Console.WriteLine("El total en inventario es {0}", total);
        }
    }
}
