
using System;
using System.Windows.Forms;
using Reglas_de_Negocio_BLL;
using Entidades_de_Negocio_BE;

namespace Presentacion_IU
{
    public partial class Operaciones : Form
    {
        public Operaciones() => InitializeComponent();

        BLLClsNumero BLLNro;
        BEClsNumero  BENro;

        private void Button1_Click(object sender, EventArgs e)
        {
            BLLNro = new BLLClsNumero();

            BENro = new BEClsNumero(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = BLLNro.SUMAR(BENro).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BLLNro = new BLLClsNumero();
            BENro = new BEClsNumero();

            BENro.Numero1 = Convert.ToInt32(textBox1.Text);
            BENro.Numero2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = BLLNro.MULTIPLICAR(BENro).ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = string.Empty;
            textBox3.Text = "";
        }
    }
}
