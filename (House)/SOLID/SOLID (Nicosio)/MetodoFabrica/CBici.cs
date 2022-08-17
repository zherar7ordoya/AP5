using static System.Console;

namespace MetodoFabrica
{
    class CBici : IVehiculo
    {
        public void Acelerar()
        {
            WriteLine("Pedalea fuerte para acelerar.");
        }

        public void Encender()
        {
            WriteLine("Las bicis no necesitan encendido.");
        }

        public void Frenar()
        {
            WriteLine("Presiona el freno trasero primero.");
        }

        public void Girar()
        {
            WriteLine("Usa el manubrio");
        }
    }

}
