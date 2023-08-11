using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Memoria_Icomparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> LP = new List<Persona>();

        IComparer<Persona> NombreAsc = new Persona.NomAsc();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LP.Add(new Persona("Juan"));
            LP.Add(new Persona("Pedro"));
            LP.Add(new Persona("Alex"));
            LP.Sort(NombreAsc);
            foreach (Persona P in LP)
            {
                listView1.Items.Add(P.Nombre);
            }
            
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public Persona()
        {

        }
        public Persona(string pNombre)
        {
            Nombre = pNombre;
        }

        ///Clases anidadas IComparer
        ///

        public class NomAsc : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return string.Compare(x.Nombre, y.Nombre);
            }
        }
    }
}
