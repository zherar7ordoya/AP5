using BEL;
using BLL;
using System;
using System.Windows.Forms;

namespace Presentacion_IU
{
    public partial class OperacionForm : Form
    {
        NumeroBEL NroBEL;
        NumeroBLL NroBLL;
        int Numero1, Numero2;

        // *-------------------------------------------------------=> SINGLETON

        //Cambiar el public del constructor a private
        private OperacionForm()
        {
            InitializeComponent();
        }

        //Crear variable estática privada
        private static OperacionForm instancia = null;

        //Crear método estático público
        public static OperacionForm Instanciamiento()
        {
            if (instancia is null) instancia = new OperacionForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********


        private void Operaciones_Load(object sender, EventArgs e)
        {
            NroBLL = new NumeroBLL();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToInt32(textBox1.Text);
            Numero2 = Convert.ToInt32(textBox2.Text);
            NroBEL = new NumeroBEL(Numero1, Numero2);
            textBox3.Text = NroBLL.SUMAR(NroBEL).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToInt32(textBox1.Text);
            Numero2 = Convert.ToInt32(textBox2.Text);
            NroBEL = new NumeroBEL(Numero1, Numero2);
            textBox3.Text = NroBLL.MULTIPLICAR(NroBEL).ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = string.Empty;
            textBox3.Text = "";
        }
    }
}
