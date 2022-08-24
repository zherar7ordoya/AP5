using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5D
{
    public class Cobranza : IImprimible
    {
        public double Importe { get; set; }
        public int Numero { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo cobranza {Numero} de importe {Importe}");
        }
    }
}
