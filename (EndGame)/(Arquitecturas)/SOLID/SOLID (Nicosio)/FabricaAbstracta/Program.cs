using static System.Console;

namespace FabricaAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica miFabrica = new FabricaQuimica();
            miFabrica.CrearProducto();

            IProductoLeche miLeche = miFabrica.ObtenerLeche;
            IProductoSaborizante miSabor = miFabrica.ObtenerSabor;

            miLeche.Producir();
            miSabor.Obtener();

            WriteLine("Mi malteada es de {0} y {1}", miLeche.ObtenerDatos(), miSabor.Informar());

            WriteLine("=====================================================");

            miFabrica = new FabricaNatural();
            miFabrica.CrearProducto();

            miLeche = miFabrica.ObtenerLeche;
            miSabor = miFabrica.ObtenerSabor;

            WriteLine("Mi malteada es de {0} y {1}", miLeche.ObtenerDatos(), miSabor.Informar());

            ReadKey();
        }
    }
}
