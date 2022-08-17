using System;
using static System.Console;

namespace MetodoFabrica
{
    class Program
    {
        static void Main()
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;

            WriteLine("¿Cuánto dinero tienes para tu vehículo?");

            dato = ReadLine();
            dinero = Convert.ToInt32(dato);

            vehiculo = CCreador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();

            ReadKey();
        }
    }
}
