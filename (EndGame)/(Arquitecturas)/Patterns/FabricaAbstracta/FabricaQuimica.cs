using static System.Console;

namespace FabricaAbstracta
{
    public class FabricaQuimica : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenProductoLeche
        {
            get { return leche; }
        }
        public IProductoSaborizante ObtenSabor
        {
            get { return sabor; }
        }

        public void CrearProductos()
        {
            WriteLine("Estamos produciendo tu malteada");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }
}
