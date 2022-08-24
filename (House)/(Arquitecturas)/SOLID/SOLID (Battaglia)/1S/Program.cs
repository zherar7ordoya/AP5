using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1S
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente
            {
                Apellido = "López",
                Nombre = "Diego"
            };
            Factura factura = new Factura(21332, cliente);

            Item i1 = new Item(new Producto("Arroz", 10), 5);
            Item i2 = new Item(new Producto("Queso", 90), 1);
            Item i3 = new Item(new Producto("Fanta", 70), 2);

            factura.Items.Add(i1);
            factura.Items.Add(i2);
            factura.Items.Add(i3);

            WriteLine(factura.Total());
            ReadKey();
        }
    }
}
