using System;

namespace Factory
{
    class FabricaQuimica:IFabrica
    {
        private IProductoLeche leche;
        private IProductoSabor sabor;
        public IProductoLeche ObtenLeche { get { return leche; } }
        public IProductoSabor ObtenSabor { get { return sabor; } }

        public void CrearProductos()
        {
            Console.WriteLine("Creando malteada...");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }
}
