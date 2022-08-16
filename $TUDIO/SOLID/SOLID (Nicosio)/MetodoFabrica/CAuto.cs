using static System.Console;

namespace MetodoFabrica
{
    public class CAuto : IVehiculo
    {
        public void Acelerar()
        {
            WriteLine("Oprime el pedal del acelerador.");
        }

        public void Encender()
        {
            WriteLine("Introduce la llave y gírala.");
        }

        public void Frenar()
        {
            WriteLine("Presiona el pedal de freno.");
        }

        public void Girar()
        {
            WriteLine("Toma el volante y gíralo.");
        }
    }

}
