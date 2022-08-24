using Presentador;
using System;
using System.Windows.Forms;

namespace Vista
{

    public partial class Form1 : Form, IVistaOperaciones
    {

        // *-------------------------------------------------------=> ATRIBUTOS

        private readonly PresentadorOperaciones PRESENTADOR_OPERACIONES;

        // *-----------------------------------------------------=> CONSTRUCTOR

        public Form1()
        {
            InitializeComponent();
            PRESENTADOR_OPERACIONES = new PresentadorOperaciones(this);
        }

        // *--------------------------------------=> IMPLEMENTACIÓN DE INTERFAZ

        public double Num1
        {
            get { return !string.IsNullOrEmpty(textBox1.Text) ? Convert.ToDouble(textBox1.Text) : 0; }
            set { textBox1.Text = value.ToString(); }
        }

        public double Num2
        {
            get { return !string.IsNullOrEmpty(textBox2.Text) ? Convert.ToDouble(textBox2.Text) : 0; }
            set { textBox2.Text = value.ToString(); }
        }

        public double Resultado
        {
            set { label1.Text = value.ToString(); }
        }

        // *------------------------------------------------------=> FORMULARIO

        private void Form1_Load(object sender, EventArgs e)
        {
            PRESENTADOR_OPERACIONES.IniciarVista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PRESENTADOR_OPERACIONES.ActualizarVista();
        }

        // *------------------------------------------------------=> Ç'EST FINI

    }

}
