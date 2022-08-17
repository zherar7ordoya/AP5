using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_IComparer
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent();  }

        //Declaro Globalmente una variable del tipo Icomparer Persona y la instancio como la clase anidada

        IComparer<Persona> Pc = new Persona.NombreAsc();

        //Si tengo otros criterios puedo ir instanciado esta variable Pc con las distintas clases anidades
        //De entrada la instancio con una

         //Instancio la lista
        List<Persona> LP = new List<Persona>();
        private void Form1_Load(object sender, EventArgs e)
        {          
            LP.Add(new Persona("Ana", 54)); LP.Add(new Persona("Juan", 35)); LP.Add(new Persona("Pedro", 2));
            Mostrar();          
        }

        private void Mostrar()
        {
            LP.Sort(Pc);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = LP;
        }

        public class Persona 
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public Persona() { }
            public Persona(string pNombre, int pEdad) {Nombre = pNombre;Edad = pEdad; }

            //Ahora hago clases anidadas para ordenar por multiples criterios, ejemplo edad y nombre
            public class NombreAsc : IComparer<Persona>
            {
                public int Compare(Persona x, Persona y) { return string.Compare(x.Nombre, y.Nombre); }
            }
            public class EdadAsc : IComparer<Persona>
            {
                public int Compare(Persona x, Persona y)
                {
                    if (x.Edad < y.Edad) return -1;
                    else if (x.Edad > y.Edad) return 1;
                    else return 0;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Pc = new Persona.NombreAsc();
            Mostrar();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Pc = new Persona.EdadAsc();
            Mostrar();
        }
    }
}
