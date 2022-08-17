using System;
using static System.Console;

namespace FabricaAbstracta
{
    public class FabricaNatural : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenerLeche { get { return leche; } }
        public IProductoSaborizante ObtenerSabor { get { return sabor; } }

        public void CrearProducto()
        {
            ForegroundColor = ConsoleColor.Green;
            string seleccion;
            WriteLine("Estamos creando tu bebida");
            WriteLine("1-Almendras 2-Coco");
            seleccion = ReadLine();

            if (seleccion == "1") leche = new LecheAlmendras();
            else { leche = new LecheCoco(); }

            leche.Producir();

            WriteLine("Ahora extraemos el sabor");
            sabor = new VainillaNatural();
            sabor.Obtener();
        }
    }
}
