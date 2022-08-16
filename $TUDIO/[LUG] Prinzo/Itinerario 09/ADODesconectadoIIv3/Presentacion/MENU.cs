using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class MENU : Form
    {
        public MENU() => InitializeComponent();

        public static bool formulario_FrmCrearDS = false;
        public static bool formulario_ABMSimpleDesconectado = false;
        public static bool formulario_ABMSimple_TextBox = false;
        public static bool formulario_ABMDesconectaado = false;
        public static bool formulario_Filtros = false;

        FrmCrearDS oFrmCrearDs;
        ABMSimpleDesconectado oFrmABMSimple;
        ABMSimple_TextBox oFrmABMI;
        ABMDesconectaado oFrmABM;
        Filtros oFfil;

        private void crearDSEnMemoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formulario_FrmCrearDS) oFrmCrearDs.Focus();
            else
            {
                oFrmCrearDs = new FrmCrearDS { MdiParent = this };
                oFrmCrearDs.Show();
                oFrmCrearDs.StartPosition = FormStartPosition.CenterScreen;
                formulario_FrmCrearDS = true;
            }
        }

        private void aBMSimpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formulario_ABMSimpleDesconectado) oFrmABMSimple.Focus();
            else
            {
                oFrmABMSimple = new ABMSimpleDesconectado { MdiParent = this };
                oFrmABMSimple.Show();
                formulario_ABMSimpleDesconectado = true;
            }
        }

        private void aBMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (formulario_ABMSimple_TextBox) oFrmABMI.Focus();
            else
            {
                oFrmABMI = new ABMSimple_TextBox { MdiParent = this };
                oFrmABMI.Show();
                formulario_ABMSimple_TextBox = true;
            }
        }

        private void aBMStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formulario_ABMDesconectaado) oFrmABM.Focus();
            else
            {
                oFrmABM = new ABMDesconectaado { MdiParent = this };
                oFrmABM.Show();
                formulario_ABMDesconectaado = true;
            }
        }

        private void filtrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formulario_Filtros) oFfil.Focus();
            else
            {
                oFfil = new Filtros { MdiParent = this };
                oFfil.Show();
                formulario_Filtros = true;
            }
        }

    }
}
