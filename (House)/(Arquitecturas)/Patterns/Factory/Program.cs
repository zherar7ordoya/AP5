using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Dinero disponible: ");
            int dinero = Convert.ToInt32(Console.ReadLine());
            IVehiculo vehiculo = Creador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();

            Console.ReadKey();
        }
    }
}
