using System;
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
