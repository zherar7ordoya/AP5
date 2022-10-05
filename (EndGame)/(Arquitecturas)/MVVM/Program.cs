using System;
using System.Windows.Forms;

namespace CSharpCorner
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Initialize();
        }

        // ─── NOTAS SOBRE ESTE MÉTODO ────────────────────────────────────────
        /* This code uses reflection to get information whether Form1 is
         * decorated with our custom attribute or not, and then to check if the
         * Activated property is set to true or not. */

        private static void Initialize()
        {
            //Type t = typeof(Form1);
            //object[] attributes = t.GetCustomAttributes(typeof(ViewModelAttribute), false);

            //if (attributes.Length > 0 && (attributes[0] as ViewModelAttribute).Activated == true)
            {
                Form1 form1 = new Form1();
                _ = new ViewModel(form1);
            }
            //else
            //{
            //    Application.Run(new Form1());
            //}
        }
    }
}
