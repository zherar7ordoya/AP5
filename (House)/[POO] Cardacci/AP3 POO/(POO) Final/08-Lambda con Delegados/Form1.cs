using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _08_Lambda_con_Delegados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate int Midelegado(int i);

        private void Form1_Load(object sender, EventArgs e)
        {
            Midelegado Del = x => x * x;
            Del += Metodo;
            Del += Metodo2;

            List<string> Lista = new List<string> { "Alex", "Juan", "Pedro" };

            var v = Lista.Where(x => x.Length < 5);
            foreach (string s in v)
            {
                MessageBox.Show(s);
            }
        }

        private int Metodo(int a)
        {
            return a;
        }
        private int Metodo2(int a)
        {
            return a*a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //el int es el parametro, el bool lo que retorna, despues el nombre de la funcion y despues la funcion con LAMBDA
            Func<int, bool> MiFuncion = x => x == 1;
            int a = int.Parse(Interaction.InputBox("Numero: (Si es 1 es true)"));

            if (MiFuncion(a) == true) MessageBox.Show("Verdadero");
            else MessageBox.Show("Falso");

        }
    }
}
