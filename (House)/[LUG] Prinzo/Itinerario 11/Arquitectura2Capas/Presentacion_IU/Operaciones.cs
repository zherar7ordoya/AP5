using System;
using System.Windows.Forms;
using Reglas_de_Negocio_BLL;

namespace Presentacion_IU
{
    public partial class Operaciones : Form
    {
        public Operaciones() => InitializeComponent();

        BLLClsNumero Nro;

        private void Button1_Click(object sender, EventArgs e)
        {
            Nro = new BLLClsNumero();

            Nro.Numero1 = Convert.ToInt32(textBox1.Text);
            Nro.Numero2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Nro.SUMAR().ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Nro = new BLLClsNumero();

            Nro.Numero1 = Convert.ToInt32(textBox1.Text);
            Nro.Numero2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Nro.MULTIPLICAR().ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = string.Empty;
            textBox3.Text = "";
        }
    }
}
