using System;

namespace Factory
{
    class LecheCoco : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "LECHE NATURAL DE COCO (250ML)";
        }

        public void Producir()
        {
            Console.WriteLine("Buscando cocos...");
        }
    }
}
