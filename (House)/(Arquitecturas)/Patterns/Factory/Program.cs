using System;

namespace Factory
{
    class Program
    {
        static void Main()
        {
            IFabrica fabrica = new FabricaQuimica();
            fabrica.CrearProductos();

            IProductoLeche leche = fabrica.ObtenLeche;
            IProductoSabor sabor = fabrica.ObtenSabor;

            leche.Producir();
            sabor.Obtener();

            Console.WriteLine("Malteada {0} y {1}", leche.ObtenerDatos(), sabor.Informar());
        }
    }
}
