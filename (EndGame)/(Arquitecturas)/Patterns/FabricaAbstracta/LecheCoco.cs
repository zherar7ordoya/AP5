using static System.Console;

namespace FabricaAbstracta
{
    public class LecheCoco : IProductoLeche
    {
        public void Producir()
        {
            WriteLine("Procesar los cocos");
        }

        public string ObtenDatos()
        {
            return "Leche de coco natural, 250 ml";
        }
    }
}
