using System;

namespace Factory
{
    class Avioneta : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Empujar acelerador");
        }

        public void Encender()
        {
            Console.WriteLine("Según procedimiento");
        }

        public void Frenar()
        {
            Console.WriteLine("Jalar acelerador");
        }

        public void Girar()
        {
            Console.WriteLine("Usar timón");
        }
    }
}
