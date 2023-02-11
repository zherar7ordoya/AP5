using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Persona _p;
        private void Form1_Load(object sender, EventArgs e)
        {
              _p = new Persona();
        }

        private void pepito(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo !!!");
            _p.DNI = "18.345.678";
            MessageBox.Show(_p.DNI);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Click +=pepito;
            this.Text = (int.Parse(this.Text) + 1).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(int.Parse(this.Text)>0)
            {
            this.button1.Click -= pepito;
            this.Text = (int.Parse(this.Text) - 1).ToString();

            }
        }
    }

    public class Persona
    {
        string _Nombre;
        public string DNI { get; set; }
        public string Nombre 
        {
            get { return _Nombre; }
            set { _Nombre = value; } 
        }
        public string Apellido { get; set; }
    }

}
