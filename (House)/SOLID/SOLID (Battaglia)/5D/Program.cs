using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5D
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();  

            IImprimible factura = new Factura(1234, DateTime.Now, 303);
            NotaCredito notaCredito = new NotaCredito(344, DateTime.Now,400);
            Remito remito = new Remito(5551, DateTime.Now, 5);
            FacturaLuz facturaLuz = new FacturaLuz(441, "444545");
            IImprimible municipal = new Municipal(12221, "555246252");

            Cobranza cobranza = new Cobranza
            {
                Numero = 25,
                Importe = 45000
            };


            List<IImprimible> lista = new List<IImprimible>();
            lista.Add(factura);
            lista.Add(notaCredito);
            lista.Add(remito);
            lista.Add(facturaLuz);
            lista.Add(municipal);
            lista.Add(cobranza);

            //impresora.Imprimir(factura);
            //impresora.Imprimir(notaCredito);
            //impresora.Imprimir(remito);
            //impresora.Imprimir(facturaLuz);
            //impresora.Imprimir(municipal);
            //impresora.Imprimir(cobranza);

            foreach (IImprimible m in lista)
            {
                impresora.Imprimir(m);
            }

            Console.ReadKey();
        }
    }
}
