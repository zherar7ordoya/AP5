using static System.Console;

namespace FabricaAbstracta
{
    public class LecheAlmendras : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "Leche orgánica de almendra, 250ml.";
        }

        public void Producir()
        {
            WriteLine("Procesar las almendras.");
        }
    }
}
