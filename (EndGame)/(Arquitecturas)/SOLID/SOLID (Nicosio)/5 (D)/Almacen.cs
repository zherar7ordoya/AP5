using System;
using System.Collections.Generic;

namespace _5__D_
{
    class Almacen : IAuditable
    {
        private List<Producto> inventario;

        public Almacen()
        { 
            inventario= new List<Producto>();
        }

        public void AdicionarProducto(Producto producto)
        {
            inventario.Add(producto);
            Console.WriteLine("Adicionamos {0}", producto.Nombre);
        }

        public IEnumerable<Producto> ObtenerProductos(int tipo)
        {
            List<Producto> encontrados = new List<Producto>();

            foreach(Producto o in inventario)
            {
                if (o.Tipo == tipo) encontrados.Add(o);
            }

            return encontrados;
        }

    }
}
