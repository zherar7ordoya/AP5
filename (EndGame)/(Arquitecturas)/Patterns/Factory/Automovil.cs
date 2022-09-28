using static System.Console;

namespace Factory
{
    class Automovil : IVehiculo
    {
        public void Acelerar() => WriteLine("Presionar acelerador");
        public void Encender() => WriteLine("Girar la llave");
        public void Frenar() => WriteLine("Presionar el pedal");
        public void Girar() => WriteLine("Usar volante");
    }
}
