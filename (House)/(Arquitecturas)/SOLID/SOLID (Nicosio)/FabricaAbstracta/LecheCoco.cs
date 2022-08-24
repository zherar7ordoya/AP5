using static System.Console;

namespace FabricaAbstracta
{
    public class LecheCoco : IProductoLeche
    {
        public string ObtenerDatos()
        {
            return "Leche de coco natural, 250 ml.";
        }

        public void Producir()
        {
            WriteLine("Buscamos los cocos.");
        }
    }
}
