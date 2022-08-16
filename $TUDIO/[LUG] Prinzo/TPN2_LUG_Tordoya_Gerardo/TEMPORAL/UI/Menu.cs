using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

 
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente oFrmP = new Cliente
            {
                MdiParent = this
            };
            oFrmP.Show();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localidad oFrmL = new Localidad
            {
                MdiParent = this
            };
            oFrmL.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
