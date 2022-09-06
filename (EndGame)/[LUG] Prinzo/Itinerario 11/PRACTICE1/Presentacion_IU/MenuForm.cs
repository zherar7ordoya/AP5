using System;
using System.Windows.Forms;

namespace Presentacion_IU
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // *----------------------------------------------=> HOOK SINGLETON
            OperacionForm formulario = OperacionForm.Instanciamiento();
            // *----------------------------------------------=> **************

            formulario.MdiParent = this;
            formulario.Show();
            formulario.BringToFront();
        }
    }
}
