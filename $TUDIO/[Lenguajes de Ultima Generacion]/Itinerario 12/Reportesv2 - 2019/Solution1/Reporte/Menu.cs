using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporte
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void datasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDataSet ods = new FDataSet();
            ods.MdiParent = this;
            ods.Show();


        }

        private void listasObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas oLs = new Listas();
            oLs.MdiParent = this;
            oLs.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
