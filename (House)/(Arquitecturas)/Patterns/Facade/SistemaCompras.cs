using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Subsistemas
{
    public class SistemaCompras
    {
       public bool Comprar()
        {
            string dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nro de tarjeta:");
            dato = Console.ReadLine();

            if (dato == "12345")
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("PAGO ACEPTADO");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PAGO RECHAZADO");
                return false;
            }
        }
    }
}