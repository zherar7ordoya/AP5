using System;

namespace Factory
{
    class LecheAlmendras : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "LECHE ORGÁNICA DE ALMENDRA (250ML)";
        }

        public void Producir()
        {
            Console.WriteLine("Procesando almendras...");
        }
    }
}
