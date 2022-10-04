using static System.Console;

namespace FabricaAbstracta
{
    public class LecheAlmendras : IProductoLeche
    {
        public void Producir()
        {
            WriteLine("Procesar las almendras");
        }

        public string ObtenDatos()
        {
            return "Leche orgánica de almendras, 250 ml";
        }
    }
}
