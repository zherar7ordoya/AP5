using System;
using System.Windows.Forms;

namespace Presentacion_IU
{
    public partial class Operaciones : Form
    {
        ClsNumero Nro;

        // *------------------------------------------------=> BEGINS SINGLETON

        //NOTA: Se crea instancia en MDI Parent (Form Principal)

        //Cambiar el public del constructor a private
        private Operaciones()
        {
            InitializeComponent();
        }

        //Crear variable estática privada
        private static Operaciones instancia = null;

        //Crear método estático público
        public static Operaciones Instanciamiento()
        {
            if (instancia is null) instancia = new Operaciones();
            return instancia;
        }
        // *--------------------------------------------------=> ENDS SINGLETON


        private void Operaciones_Load(object sender, EventArgs e)
        {
            Nro = new ClsNumero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nro.Numero1 = Convert.ToInt32(textBox1.Text);
            Nro.Numero2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Nro.SUMAR().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nro.Numero1 = Convert.ToInt32(textBox1.Text);
            Nro.Numero2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Nro.MULTIPLICAR().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = string.Empty;
            textBox3.Text = "";
        }
    }
}
