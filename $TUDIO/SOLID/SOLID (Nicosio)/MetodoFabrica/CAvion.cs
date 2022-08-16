using static System.Console;

namespace MetodoFabrica
{
    public class CAvion : IVehiculo
    {
        public void Acelerar()
        {
            WriteLine("Empuja el acelerador.");
        }

        public void Encender()
        {
            WriteLine("Sigue todo el procedimiento.");
        }

        public void Frenar()
        {
            WriteLine("Jala el acelerador.");
        }

        public void Girar()
        {
            WriteLine("Mueve el timón de cola.");
        }
    }

}
