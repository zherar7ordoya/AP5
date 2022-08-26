using System;

namespace Factory
{
    class SaborVainilla : IProductoSabor
    {
        public string Informar()
        {
            return "SABOR A VAINILLA";
        }

        public void Obtener()
        {
            Console.WriteLine("Extrayendo de las vainas...");
        }
    }
}
