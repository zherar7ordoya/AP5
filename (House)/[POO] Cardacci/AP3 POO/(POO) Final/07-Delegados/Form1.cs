using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Delegados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate string MiDelegado(string a); //Declaro el Delegado. Devuelve un string y le paso por referencia un string
        delegate int Delegado2(int b, int c);


        private void Form1_Load(object sender, EventArgs e)
        {
            MiDelegado DMensaje; //Declaro la variable del tipo de delegado creado.
            DMensaje = MostrarMensaje; //le suscribo una funcion compatible, en este caso MostrarMensaje devuelve un string
            //y recibe como parametro un string.

            //Ahora puedo invocar el delegado directamente, en vez de llamar a la función.

           MessageBox.Show(DMensaje("Hola"));

            Delegado2 DSuma;
            DSuma = Sumar;

            //invoco al delegado
            int r = DSuma(2, 5);
            MessageBox.Show(r.ToString());
        }

        private int Sumar(int b, int c)
        {
            return b + c;
        }


        //Esta es la funcion compatible que puedo suscribir al delegado que creé.
        private string MostrarMensaje(string a)
        {
            return a;
        }

        

        
    }


}
