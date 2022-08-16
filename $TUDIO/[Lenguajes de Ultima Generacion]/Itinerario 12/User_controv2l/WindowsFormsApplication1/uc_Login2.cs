using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class uc_Login2 : UserControl
    {
        public uc_Login2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "Pepe") && (textBox2.Text == "1234"))
            {
                MessageBox.Show("Ingreso al sistema");
            }
            else
            { MessageBox.Show("Datos erroneos"); }
        }
    }
}
