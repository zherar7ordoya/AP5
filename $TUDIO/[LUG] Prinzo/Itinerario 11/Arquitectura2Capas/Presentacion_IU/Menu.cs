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

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones ofo = new Operaciones();
            ofo.MdiParent = this;
            ofo.Show();
        }
    }
}
