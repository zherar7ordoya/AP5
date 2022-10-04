/*
  @title        PATRÓN FÁBRICA ABSTRACTA
  @description  El patrón Fábrica Abstracta proporciona una interfaz para crear
                familias de objetos relacionados o dependientes sin especificar
                sus clases concretas.
  @author       Gerardo Tordoya
  @date         2022-09-28
  @credits      https://youtu.be/10xMzsv_yBQ
*/


using static System.Console;

namespace FabricaAbstracta
{
    internal class Program
    {
        static void Main()
        {
            IFabrica MiFabrica = new FabricaQuimica();
            MiFabrica.CrearProductos();

            IProductoLeche MiLeche = MiFabrica.ObtenProductoLeche;
            IProductoSaborizante MiSabor = MiFabrica.ObtenSabor;

            MiLeche.Producir();
            MiSabor.Obtener();

            WriteLine("Mi malteada es de {0} y {1}", MiLeche.ObtenDatos(), MiSabor.Informacion());

            WriteLine("───────────────────────────────────────────────────────────");

            MiFabrica = new FabricaNatural();
            MiFabrica.CrearProductos();
            MiLeche = MiFabrica.ObtenProductoLeche;
            MiSabor = MiFabrica.ObtenSabor;

            WriteLine("Mi malteada es de {0} y {1}", MiLeche.ObtenDatos(), MiSabor.Informacion());

            ReadKey();
        }
    }
}
