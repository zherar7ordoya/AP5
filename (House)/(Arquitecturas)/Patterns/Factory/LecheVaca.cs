using System;

namespace Factory
{
    class LecheVaca : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "LECHE DE VACA (250ML)";
        }

        public void Producir()
        {
            Console.WriteLine("Ordeñando vaca...");
        }
    }
}
