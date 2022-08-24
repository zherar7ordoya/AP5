using static System.Console;

namespace FabricaAbstracta
{
    public class SaborChocolate : IProductoSaborizante
    {
        public string Informar()
        {
            return "Sabor a chocolate.";
        }

        public void Obtener()
        {
            WriteLine("Se produce C7H8N4O2.");
        }
    }
}
