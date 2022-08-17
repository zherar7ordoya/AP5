using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_C
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ejemplosSImplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEx1 frmer1 = new RegEx1();
            frmer1.MdiParent = this;
            frmer1.Show();
        }

        private void ejemplosV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEx2 frmer2 = new RegEx2();
            frmer2.MdiParent = this;
            frmer2.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos frmGrup = new Grupos();
            frmGrup.MdiParent = this;
            frmGrup.Show();
        }

        private void reemplazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reemplazos frmRemp = new Reemplazos();
            frmRemp.MdiParent = this;
            frmRemp.Show();
        }

        private void imagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagenes frmImag = new Imagenes();
            frmImag.MdiParent = this;
            frmImag.Show();
        }
    }
}
