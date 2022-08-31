using System;

namespace Factory
{
    class Automovil : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Presionar acelerador");
        }

        public void Encender()
        {
            Console.WriteLine("Girar la llave");
        }

        public void Frenar()
        {
            Console.WriteLine("Presionar el pedal");
        }

        public void Girar()
        {
            Console.WriteLine("Usar volante");
        }
    }
}
