using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PresupuestoMarcaModelo : Form
    {
        public PresupuestoMarcaModelo()
        {
            InitializeComponent();
            bllrmm = new BLLRepuestoMarcaModelo();
        }

        BLLRepuestoMarcaModelo bllrmm;

        private void PresupuestoMarcaModelo_Load(object sender, EventArgs e)
        {
            dgvPresupestos.Enabled = false;
            bllrmm.Pmm(dgvPresupestos);
        }
    }
}
