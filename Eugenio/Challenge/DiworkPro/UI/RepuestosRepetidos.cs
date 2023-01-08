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
    public partial class RepuestosRepetidos : Form
    {
        public RepuestosRepetidos()
        {
            InitializeComponent();
            bllrmm = new BLLRepuestoMarcaModelo();
        }
        BLLRepuestoMarcaModelo bllrmm;
        private void RepuestosRepetidos_Load(object sender, EventArgs e)
        {
            dgvRepuestoRepetido.Enabled = false;
            bllrmm.Rmm(dgvRepuestoRepetido);
        }
    }
}
