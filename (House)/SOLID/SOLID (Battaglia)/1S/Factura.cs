using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1S
{
    public class Factura
    {
        public Factura(int numero, Cliente cliente)
        {
            Numero = numero;
            Cliente = cliente;
            Items = new List<Item>();
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> Items { get; set; }

        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Subtotal();
            }
            return total;
        }
    }
}
