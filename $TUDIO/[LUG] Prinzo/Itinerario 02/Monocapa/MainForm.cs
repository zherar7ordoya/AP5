using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monocapa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CorazonesBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No he venido, amigos, a robar vuestros corazones.");
        }
    }
}
