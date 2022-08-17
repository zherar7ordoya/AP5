using System;
using System.Collections.Generic;

namespace _2__O_
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            List<BaseInventario> productos = new List<BaseInventario>
            {
                new InventarioAlimento(new Producto("Papa", 1, 12.5)),
                new InventarioMedicamento(new Producto("Analgésico", 2, 23.40)),
                new InventarioAlimento(new Producto("Tomate", 1, 30)),
                new InventarioAlimento(new Producto("Manzana", 1, 25)),
                new InventarioMedicamento(new Producto("Antibiótico", 2, 89)),
                new InventarioMedicamento(new Producto("Antiácido", 2, 43))
            };

            Tienda tienda = new Tienda(productos);
            tienda.CalcularInventario();

            Console.ReadKey();
        }
    }
}
