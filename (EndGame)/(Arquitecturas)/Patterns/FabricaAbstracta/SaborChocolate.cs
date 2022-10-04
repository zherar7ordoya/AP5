using static System.Console;

namespace FabricaAbstracta
{
    public class SaborChocolate : IProductoSaborizante
    {
        public void Obtener()
        {
            WriteLine("Se produce C7H8N402");
        }

        public string Informacion()
        {
            return "Sabor a chocolate";
        }
    }
}
