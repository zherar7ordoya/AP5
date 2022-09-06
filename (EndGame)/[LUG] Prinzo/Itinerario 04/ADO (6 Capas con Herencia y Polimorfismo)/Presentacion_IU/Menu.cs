using System;
using System.Windows.Forms;

namespace Presentacion_IU
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gestionarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEquipo ofre = new FrmEquipo();
            ofre.MdiParent = this;
            ofre.Show();

        }
    }
}
