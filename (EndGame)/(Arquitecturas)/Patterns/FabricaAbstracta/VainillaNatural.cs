using static System.Console;

namespace FabricaAbstracta
{
    public class VainillaNatural : IProductoSaborizante
    {
        public void Obtener()
        {
            WriteLine("Se extrae de las vainas");
        }

        public string Informacion()
        {
            return "Extracto natural de vainilla";
        }
    }
}
