using System;

namespace _4__I_
{
    class MultiAvanzado : IMultiCompleto
    {
        public void Escanear()
        {
            Console.WriteLine("Escaneando...");
        }

        public void Faxear()
        {
            Console.WriteLine("Faxeando...");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo...");
        }

        public void Telefonear()
        {
            Console.WriteLine("Telefoneando...");
        }
    }
}
