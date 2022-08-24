using System;

namespace _1__S_
{
    class Hacienda
    {

        public static double CalcularImpuesto(Empleado empleado)
        {
            return empleado.Sueldo * 0.35;
        }

        public static void PagarImpuesto(Empleado empleado)
        {
            double impuesto = CalcularImpuesto(empleado);
            Console.WriteLine("Se pagó {0} en impuesto por parte de {1}",
                impuesto, empleado.Nombre);
        }

    }
}
