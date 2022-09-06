using static System.Console;

namespace FabricaAbstracta
{
    public class LecheVaca : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "Lecha de vaca, 250 ml.";
        }

        public void Producir()
        {
            WriteLine("Ordeñar vaca en la granja.");
        }
    }
}
