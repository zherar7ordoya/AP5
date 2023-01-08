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
    public partial class TotalAutoMoto : Form
    {
        public TotalAutoMoto()
        {
            InitializeComponent();
            bllrmm = new BLLRepuestoMarcaModelo();
        }
        BLLRepuestoMarcaModelo bllrmm;

        private void TotalAutoMoto_Load(object sender, EventArgs e)
        {
            dgvAuto.Enabled = false;
            dgvMoto.Enabled = false;
            bllrmm.TotalAuto(dgvAuto);
            bllrmm.TotalMoto(dgvMoto);
        }
    }
}
