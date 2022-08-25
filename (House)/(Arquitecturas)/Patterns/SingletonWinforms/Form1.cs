using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonWinforms
{
    public partial class Form1 : Form
    {
        private static Form1 aForm = null;

        public static Form1 Instance()
        {
            if (aForm == null) aForm = new Form1();
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
