using static System.Console;

namespace FabricaAbstracta
{
    public class FabricaQuimica : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenerLeche { get { return leche; } }
        public IProductoSaborizante ObtenerSabor { get { return sabor; } }

        public void CrearProducto()
        {
            WriteLine("Estamos produciendo tu maltaeada.");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }
}
