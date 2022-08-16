using ABS;
using BEL;
using System.Windows.Forms;

namespace UIL
{
    public static class Factory
    {
        //================================ PROGRAM ============================

        public static Menu CrearMenu()
        {
            return new Menu();
        }
        // ================================= MENU =============================

        public static Form CrearForm()
        {
            return new Form();
        }

        public static OpenFileDialog CrearOpenFileDialog()
        {
            return new OpenFileDialog();
        }

        public static SaveFileDialog CrearSaveFileDialog()
        {
            return new SaveFileDialog();
        }

        //================================ PROPIOS ============================
        public static ICalculadoraPresenter CrearCalculadoraPresenter()
        {
            return new CalculadoraPresenter(CrearCalculadoraForm(), CrearCalculadoraModel());
        }

        public static ICalculadoraView CrearCalculadoraForm()
        {
            return new CalculadoraForm();
        }

        public static ICalculadoraModel CrearCalculadoraModel()
        {
            return new CalculadoraModel();
        }
    }
}
