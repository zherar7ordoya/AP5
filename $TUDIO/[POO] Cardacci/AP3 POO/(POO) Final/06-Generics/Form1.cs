using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Generics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona<int> P = new Persona<int>();
        Persona<string> P2 = new Persona<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            P.Dni = 25029996;
            P2.Dni = "25029996";

            P.MostrarEstado();
            P2.MostrarEstado();
            P.MetodoGenerico(1);
            P.MetodoGenerico(true);
            DateTime Fecha = DateTime.Now;
            P.MetodoGenerico(Fecha);
            P.MetodoGenerico(10.54m);
            P.MetodoGenerico(10.54);

        }
    }

    public class Persona<T> //clase generica
    {
        private T _Dni;

        public T Dni { get { return _Dni; } set { _Dni = value; } }

        public Persona(T pDni)
        {
            _Dni = pDni;
        }
        public Persona()
        {

        }
        public void MostrarEstado()
        {
            MessageBox.Show("El Dni es un " + _Dni.GetType().ToString() + " y su valor es: " + _Dni);
        }

        public void MetodoGenerico<S> (S pDni) where S:struct
        {
            MessageBox.Show("Me llego un tipo: " + pDni.GetType().ToString());
        }
    }
}
