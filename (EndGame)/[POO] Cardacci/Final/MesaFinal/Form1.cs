//array, lista (hard)
//con objetos
//linq que lo consuma
//foreach



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesaFinal
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona(22777420, "Gerardo"),
                new Persona(30666999, "Darío"),
                new Persona(15258456, "Tordoya"),
                new Persona(25148654, "Darío"),
                new Persona(10456123, "Cardacci")
            };

            var temporal1 = from x in personas where x.DNI > 22222222 select x;

            var temporal2 = from x
                           in personas
                           select x;

            var temporal3 = from x in personas where x.Nombre == "Darío" select x;

            List < Persona > datos = new List<Persona>();

            foreach (var item in temporal3)
            {
                datos.Add((Persona)item);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datos;
        }
    }


    public class Persona
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public Persona() { }
        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }
    }
}
