using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Listas2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fcli = new frmCliente();
            fcli.MdiParent = this;
            fcli.Show();
        }

        private void paqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaquetes fpak = new frmPaquetes();
            fpak.MdiParent = this;
            fpak.Show();
        }

        private void contratacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientePack fcp = new frmClientePack();
            fcp.MdiParent = this;
            fcp.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes fi = new frmInformes();
            fi.MdiParent = this;
            fi.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
