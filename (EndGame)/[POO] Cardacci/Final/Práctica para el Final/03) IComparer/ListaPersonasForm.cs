// ----------------------------------------------------------------------------|---------------------------------------|
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InterfazIComparer
{
    public partial class ListaPersonasForm : Form
    {
        public ListaPersonasForm() { InitializeComponent(); }

        IComparer<Persona> _persona = new Persona.NombreAscendente();

        // Voy instanciado esta variable "persona" con las distintas clases anidadas
        //readonly List<Persona> _listaPersonas = new List<Persona>();
        readonly List<Persona> _listaPersonas = new List<Persona>();

        private void Formulario_Load(object sender, EventArgs e)
        {
            _listaPersonas.Add(new Persona("Juan", 20));
            _listaPersonas.Add(new Persona("Ana", 30));
            _listaPersonas.Add(new Persona("Pedro", 40));
            _listaPersonas.Add(new Persona("Luis", 10));
            _listaPersonas.Add(new Persona("Ana", 20));
            Mostrar();
        }

        private void Mostrar()
        {
            _listaPersonas.Sort(_persona);
            ListaPersonasDgv.DataSource = null;
            ListaPersonasDgv.DataSource = _listaPersonas;
        }



        private void NombreAscendenteRadio_CheckedChanged(object sender, EventArgs e)
        {
            _persona = new Persona.NombreAscendente();
            Mostrar();
        }

        private void EdadAscendenteRadio_CheckedChanged(object sender, EventArgs e)
        {
            _persona = new Persona.EdadAscendente();
            Mostrar();
        }

        private void NombreDescendenteRadio_CheckedChanged(object sender, EventArgs e)
        {
            _persona = new Persona.NombreDescendente();
            Mostrar();
        }

        private void EdadDescendenteRadio_CheckedChanged(object sender, EventArgs e)
        {
            _persona = new Persona.EdadDescendente();
            Mostrar();
        }
    }


    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(
            string nombre,
            int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Ahora hago clases anidadas para ordenar por múltiples criterios
        public class NombreAscendente : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return string.Compare(x.Nombre, y.Nombre);
            }
        }

        public class EdadAscendente : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                if (x.Edad < y.Edad) return -1;
                else if (x.Edad > y.Edad) return 1;
                else return 0;
            }
        }

        public class NombreDescendente : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return string.Compare(x.Nombre, y.Nombre) * -1;
            }
        }

        public class EdadDescendente : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                if (x.Edad < y.Edad) return 1;
                else if (x.Edad > y.Edad) return -1;
                else return 0;
            }
        }
    }


}
