using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_POO_Practica
{
    public partial class Form1 : Form
    {
        public Form1() {InitializeComponent();}

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Persona> LP = new List<Persona>();
            LP.Add(new Persona("Ana", 54));
            LP.Add(new Persona("Juan", 35));
            LP.Add(new Persona("Pedro", 2));
            LP.Sort(); //La ordeno por el criterio que elegí en el metodo compare tu
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LP;
        }
    }
    public class Persona : IComparable<Persona> //le indico el tipo que quiero comparar, en este caso voy a comparar personas
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Persona()  { }
        public Persona(string pNombre, int pEdad){Nombre = pNombre;Edad = pEdad;  }

        public int CompareTo(Persona otra) //En este caso ordeno por edad
        {
            //if (Edad < otra.Edad) return -1;
            //else if (Edad > otra.Edad) return 1;
            //else return 0;     

            //Si quiero comparar Nombre el codigo sería este:

            return string.Compare(Nombre, otra.Nombre);
        }
    }
}
