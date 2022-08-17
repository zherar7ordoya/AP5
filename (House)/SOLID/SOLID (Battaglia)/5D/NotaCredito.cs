using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5D
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
            sigla = "NC";
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo nota de crédito {Numero} del {Fecha} de importe {Importe}");
        }

        public override double Total()
        {
            return Importe * 1.21 * -1;
        }
    }
}
