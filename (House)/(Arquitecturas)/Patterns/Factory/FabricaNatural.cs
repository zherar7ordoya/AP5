using System;

namespace Factory
{
    class FabricaNatural : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSabor sabor;
        public IProductoLeche ObtenLeche {get {return leche; } }
        public IProductoSabor ObtenSabor { get { return sabor; } }

        public void CrearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1) Almendras || 2) Coco");
            string seleccion = Console.ReadLine();

            if (seleccion == "1") leche = new LecheAlmendras();
            else { leche = new LecheCoco(); }

            leche.Producir();
            sabor = new SaborVainilla();
            sabor.Obtener();
        }
    }
}
