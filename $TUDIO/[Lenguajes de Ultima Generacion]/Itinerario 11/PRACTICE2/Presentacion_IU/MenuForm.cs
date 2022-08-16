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

        private void GestionarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipoForm formulario = EquipoForm.Instancia();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.BringToFront();
        }
    }
}
