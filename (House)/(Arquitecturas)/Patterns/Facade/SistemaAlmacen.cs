using System;

namespace Subsistemas
{
    public class SistemaAlmacen
    {
        private int cantidad;

            public SistemaAlmacen()
        {
            cantidad = 3;
        }

        public bool SacarAlmacen()
        {
            if (cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto listo para ser enviado.");
                cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no disponible.");
                return false;
            }
        }
    }
}