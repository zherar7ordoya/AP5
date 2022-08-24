using System;

namespace _4__I_
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiAvanzado avanzado = new MultiAvanzado();
            avanzado.Escanear();
            avanzado.Faxear();
            avanzado.Imprimir();
            avanzado.Telefonear();

            Console.WriteLine("------------");

            Fax fax = new Fax();
            fax.Telefonear();
            fax.Faxear();

            Console.WriteLine("------------");

            MultiSencillo sencillo = new MultiSencillo();
            sencillo.Escanear();
            sencillo.Imprimir();

            Console.ReadKey();
        }
    }
}
