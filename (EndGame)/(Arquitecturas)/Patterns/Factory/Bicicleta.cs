using static System.Console;

namespace Factory
{
    class Bicicleta : IVehiculo
    {
        public void Acelerar() => WriteLine("Pedalear más rápido");
        public void Encender() => WriteLine("No se necesita encendido");
        public void Frenar() => WriteLine("Primero el freno trasero");
        public void Girar() => WriteLine("Usar el manubrio");
    }
}
