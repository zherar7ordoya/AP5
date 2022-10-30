using GCDataAccess;
using ReaLTaiizor.Manager;
using System;
using System.Windows.Forms;


namespace GCWinforms
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar las conexiones a los repositorios
            ConfiguracionGlobal.IniciarConexion(DatastoreType.ArchivoCSV);

            // Iniciar MaterialSkinManager
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.EnforceBackcolorOnAllComponents = true;

            Application.Run(new PremiosForm(msm));
        }
    }
}
