using System;

namespace Factory
{
    class SaborChocolate : IProductoSabor
    {
        public string Informar()
        {
            return "SABOR A CHOCOLATE";
        }

        public void Obtener()
        {
            Console.WriteLine("Produciendo C7H8N402...");
        }
    }
}
