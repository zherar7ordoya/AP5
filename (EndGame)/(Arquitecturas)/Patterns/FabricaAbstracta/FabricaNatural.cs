using System;
using static System.Console;

namespace FabricaAbstracta
{
    public class FabricaNatural : IFabrica
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
            ForegroundColor = ConsoleColor.Green;
            string seleccion;
            WriteLine("Estamos creando tu bebida");
            WriteLine("1) Almendras || 2) Coco");
            seleccion = ReadLine();

            if (seleccion == "1")
            {
                leche = new LecheAlmendras();
            }
            else if (seleccion == "2")
            {
                leche = new LecheCoco();
            }
            else
            {
                WriteLine("Opcion no valida");
            }

            leche.Producir();

            WriteLine("Ahora extraemos el sabor");
            sabor = new VainillaNatural();
            sabor.Obtener();
        }
    }
}
