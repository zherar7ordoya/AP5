using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_XML
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void xMLLecturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturaEscrituraI ofLEI = new LecturaEscrituraI();
            ofLEI.MdiParent = this;
            ofLEI.Show();
        }

        private void linQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LINQtoXML ofrlq = new LINQtoXML();
            ofrlq.MdiParent = this;
            ofrlq.Show();
        }

        private void xMLLecturaEscrituraSimpleIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturaEscrituraXMLSimple ofLEII = new LecturaEscrituraXMLSimple();
            ofLEII.MdiParent = this;
            ofLEII.Show();
        }

        private void lecturaEscrituraDOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturaEscrituraDOM ofDOm = new LecturaEscrituraDOM();
            ofDOm.MdiParent = this;
            ofDOm.Show();
        }

        private void linQClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LINQtoXMLv2 ofrlq2 = new LINQtoXMLv2();
            ofrlq2.MdiParent = this;
            ofrlq2.Show();
        }

        private void linQBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LINQtoXMLv3 ofrlq3 = new LINQtoXMLv3();
            ofrlq3.MdiParent = this;
            ofrlq3.Show();
        }

        private void linqABMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LINQtoXMLv4 ofrlq4 = new LINQtoXMLv4();
            ofrlq4.MdiParent = this;
            ofrlq4.Show();
        }
    }
}
