using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }

        private void FormPadre_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void primerParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParcial formParcial = new FormParcial
            {
                MdiParent = this
            };
            formParcial.Show();
        }
    }
}
