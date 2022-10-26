using ReaLTaiizor.Colors;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
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

            // Iniciar las conexiones
            GCLibrary.ConfiguracionGlobal.IniciarConexiones(true, true);

            // ─────────────────────────────────────────────────────────────────
            // Initialize MaterialSkinManager
            MaterialSkinManager msm = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-material
            // Skin components. This HAS to be set before the AddFormToManage()
            msm.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.Green600,
                MaterialPrimary.Green700,
                MaterialPrimary.Green200,
                MaterialAccent.Red100,
                MaterialTextShade.WHITE);
            // ─────────────────────────────────────────────────────────────────

            Application.Run(new PremiosForm(msm));
        }
    }
}
