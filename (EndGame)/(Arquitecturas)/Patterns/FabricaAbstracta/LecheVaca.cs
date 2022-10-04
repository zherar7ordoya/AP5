using static System.Console;

namespace FabricaAbstracta
{
    public class LecheVaca : IProductoLeche
    {
        public void Producir()
        {
            WriteLine("Ordeñar la vaca en la granja");
        }

        public string ObtenDatos()
        {
            return "Leche de vaca, 250 ml";
        }
    }
}
