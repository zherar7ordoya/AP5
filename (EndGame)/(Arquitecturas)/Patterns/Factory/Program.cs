/*
    ───────────────────────────────────────────────────────────────────────────
    @title          PATRÓN MÉTODO FÁBRICA
    @description    El patrón Método Fábrica es un patrón de diseño creacional
                    que proporciona una interfaz para crear objetos en una
                    superclase mientras permite a las subclases alterar el tipo
                    de objetos que se crearán.
    @author         Gerardo Tordoya
    @date           2022-09-27
    @source         https://youtu.be/t-vqCWlFQLI
    ───────────────────────────────────────────────────────────────────────────
*/


using System;
using static System.Console;

namespace Factory
{
    class Program
    {
        static void Main()
        {
            WriteLine("Dinero disponible: ");
            int dinero = Convert.ToInt32(ReadLine());
            IVehiculo vehiculo = Creador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();

            ReadKey();
        }
    }
}

 // ┌─────────────────────────────────────────────────────────────────────┐  \\
 // │ NOTA: Ver MD adjunto.                                               │  \\
 // └─────────────────────────────────────────────────────────────────────┘  \\
