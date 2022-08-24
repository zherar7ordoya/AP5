using System;
using System.Collections.Generic;

namespace _5__D_
{
    class Auditor
    {
        private IAuditable almacen;

        public Auditor(IAuditable almacen)
        {
            this.almacen = almacen;
        }

        public double TotalesAlimentos()
        {
            double total = 0;

            IEnumerable<Producto> listado = almacen.ObtenerProductos(0);

            foreach(Producto producto in listado)
            {
                if (producto.Tipo == 0)
                {
                    Console.WriteLine(producto);
                    total += producto.Costo;
                }
            }

            return total;
        }
    }
}
