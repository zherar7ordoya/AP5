using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Comparer
{
    public partial class PersonaForm : Form
    {
        public PersonaForm() { InitializeComponent(); }

        // Voy instanciado Persona con las distintas clases anidadas
        readonly Persona[] _listaPersonas =
        {
                new Persona("Alfa", 10),
                new Persona("Beta", 59),
                new Persona("Gamma", 9),
                new Persona("Delta", 19),
                new Persona("Epsilon", 29),
                new Persona("Zeta", 39),
                new Persona("Eta", 49),
                new Persona("Theta", 69),
                new Persona("Iota", 79),
                new Persona("Kappa", 89),
                new Persona("Lambda", 99),
                new Persona("Mu", 10),
                new Persona("Nu", 11),
                new Persona("Xi", 12),
                new Persona("Omicron", 13),
                new Persona("Pi", 14),
                new Persona("Rho", 15),
                new Persona("Sigma", 16),
                new Persona("Tau", 17),
                new Persona("Upsilon", 18),
                new Persona("Phi", 19),
                new Persona("Chi", 20),
                new Persona("Psi", 21),
                new Persona("Omega", 22)
        };

        private void PersonaForm_Load(object sender, EventArgs e) => Mostrar();

        private void Mostrar()
        {
            PersonasDgv.DataSource = null;
            PersonasDgv.DataSource = _listaPersonas;
        }

        // ********************************************************************
        
        private void NombreAscendenteRadio_CheckedChanged(object sender, EventArgs e)
        {
            Array.Sort(_listaPersonas, new Persona.NombreAscendente());
            Mostrar();
        }

        private void EdadAscendenteRadio_CheckedChanged(object sender, EventArgs e)
        {
            Array.Sort(_listaPersonas, new Persona.EdadAscendente());
            Mostrar();
        }

        private void NombreDescendenteRadio_CheckedChanged(object sender, EventArgs e)
        {
            Array.Sort(_listaPersonas, new Persona.NombreDescendente());
            Mostrar();
        }

        private void EdadDescendenteRadio_CheckedChanged(object sender, EventArgs e)
        {
            Array.Sort(_listaPersonas, new Persona.EdadDescendente());
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
