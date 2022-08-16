using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_C
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void vectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArrays ofrma = new frmArrays();
            ofrma.MdiParent = this;
            ofrma.Show();
        }

        private void dataviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatview ofrmDV = new frmDatview();
            ofrmDV.MdiParent = this;
            ofrmDV.Show();
        }

        private void tablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabla ofrmDT = new frmTabla();
            ofrmDT.MdiParent = this;
            ofrmDT.Show();
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmXml ofrmcsv = new frmXml();
           ofrmcsv.MdiParent = this;
           ofrmcsv.Show();
        }

        private void exportarImportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportExport ofrmEI = new frmImportExport();
            ofrmEI.MdiParent = this;
            ofrmEI.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas ofrl = new frmListas();
            ofrl.MdiParent = this;
            ofrl.Show();
        }
    }
}
