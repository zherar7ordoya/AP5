using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subsistemas;

namespace Facade
{
    class Program
    {
        // MAIN es el Cliente.
        static void Main()
        {
            Fachada fachada = new Fachada();
            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=======================");

            Console.ReadKey();
        }
    }
}
