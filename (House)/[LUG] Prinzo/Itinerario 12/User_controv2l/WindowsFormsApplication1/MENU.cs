using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void validarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Validar oFrv = new Validar();
            oFrv.MdiParent = this;
            oFrv.Show();
        }

        private void loguinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoguin ofrlog = new frmLoguin();
            ofrlog.MdiParent = this;
            ofrlog.Show();
        }

        private void datagrigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdg ofrdg = new frmdg();
            ofrdg.MdiParent = this;
            ofrdg.Show();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLimpiar ofrlimp = new frmLimpiar();
            ofrlimp.MdiParent = this;
            ofrlimp.Show();
        }
    }
}
