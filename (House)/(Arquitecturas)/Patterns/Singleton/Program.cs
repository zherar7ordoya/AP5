using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Singleton uno = Singleton.ObtenInstancia();
            uno.PonerDatos("Ana", 27);
            uno.AlgunProceso();

            Singleton dos = Singleton.ObtenInstancia();
            Console.WriteLine(dos);
            Console.ReadKey();
        }
    }
}
