using System;

namespace _3__L_
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal noticiero = new Noticiero("Hola a todos!");
            noticiero.Muestra();

            Principal radio = new Radio("¿Cómo están?");
            radio.Muestra();

            Console.WriteLine("/////////////////////");
            
            Console.ReadKey();
        }
    }
}
