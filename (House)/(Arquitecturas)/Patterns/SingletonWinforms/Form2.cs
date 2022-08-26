using System;
using System.Windows.Forms;

namespace SingletonWinforms
{
    public partial class Form2 : Form, IDisposable
    {
        private static Form2 aForm = null;

        public static Form2 Instance()
        {
            if (aForm == null) aForm = (Form2)Factory.CrearForm2();
            return aForm;
        }

        //=====================================================================

        public Form2() => InitializeComponent();

        //============= CÓDIGO TRASLADADO DESDE FORM2.DESIGNER.CS =============

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            aForm = null;
        }
    }
}
