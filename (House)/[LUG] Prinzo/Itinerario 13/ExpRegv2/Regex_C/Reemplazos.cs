using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regex_C
{
    public partial class Reemplazos : Form
    {
        public Reemplazos()
        {
            InitializeComponent();
        }

        private void btnRemplazar_Click(object sender, EventArgs e)
        {
            Regex mR;// = default(Regex);
            if (this.chkPalabra.Checked)
            {
                mR = new Regex("\\b" + this.txtPatron.Text + "\\b", RegexOptions.IgnoreCase);
            }
            else
            {
                mR = new Regex(this.txtPatron.Text, RegexOptions.IgnoreCase);
            }

            this.txtFinal.Text = mR.Replace(this.txtOriginal.Text, this.txtRemplazo.Text);

         
        }

        private void Reemplazos_Load(object sender, EventArgs e)
        {

        }
    }
}
