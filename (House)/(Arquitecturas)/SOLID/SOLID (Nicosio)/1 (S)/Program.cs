using System;

namespace _1__S_
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Empleado empleado = new Empleado("Gerardo", "Facturador", 44, 44000);

            Console.WriteLine(empleado);
            Console.WriteLine(Hacienda.CalcularImpuesto(empleado));
            Hacienda.PagarImpuesto(empleado);

            Console.ReadKey();
        }
    }
}
