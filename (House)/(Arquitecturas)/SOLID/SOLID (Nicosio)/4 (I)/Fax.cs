using System;

namespace _4__I_
{
    class Fax : IFax
    {
        public void Faxear()
        {
            Console.WriteLine("Envío un fax");
        }

        public void Telefonear()
        {
            Console.WriteLine("Hago una llamada");
        }
    }
}
