using static System.Console;

namespace Factory
{
    class Avioneta : IVehiculo
    {
        public void Acelerar() => WriteLine("Empujar acelerador");
        public void Encender() => WriteLine("Según procedimiento");
        public void Frenar() => WriteLine("Jalar acelerador");
        public void Girar() => WriteLine("Usar timón");
    }
}
