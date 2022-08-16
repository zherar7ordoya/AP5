using static System.Console;

namespace FabricaAbstracta
{
    public class VainillaNatural : IProductoSaborizante
    {
        public string Informar()
        {
            return "Extracto natural de vainilla";
        }

        public void Obtener()
        {
            WriteLine("Se extrae de las vainas");
        }
    }
}
