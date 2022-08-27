using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Bicicleta : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Pedalear más rápido");
        }

        public void Encender()
        {
            Console.WriteLine("No se necesita encendido");
        }

        public void Frenar()
        {
            Console.WriteLine("Primero el freno trasero");
        }

        public void Girar()
        {
            Console.WriteLine("Usar el manubrio");
        }
    }
}
