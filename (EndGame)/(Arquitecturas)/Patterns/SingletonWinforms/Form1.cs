using System;
using System.Windows.Forms;

namespace SingletonWinforms
{
    public partial class Form1 : Form, IDisposable
    {
        private static Form1 aForm = null;

        public static Form1 Instance()
        {
            if (aForm == null) aForm = (Form1)Factory.CrearForm1();
            return aForm;
        }

        //=====================================================================

        public Form1() => InitializeComponent();

        //============= CÓDIGO TRASLADADO DESDE FORM1.DESIGNER.CS =============

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
