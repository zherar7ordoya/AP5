using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Comparable
{
    public partial class PersonaForm : Form
    {
        public PersonaForm() { InitializeComponent(); }

        private void Formulario_Load(object sender, EventArgs e)
        {
            List<Persona> _listaPersonas = new List<Persona>
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

            // Ordeno la lista por el criterio que elegí en el método CompareTo
            _listaPersonas.Sort();

            PersonasDgv.DataSource = null;
            PersonasDgv.DataSource = _listaPersonas;
        }
    }

    // ********************************************************************* \\

    // Indico el tipo que quiero comparar: en este caso, comparar personas
    public class Persona : IComparable<Persona>
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

        public int CompareTo(Persona otra)
        {
            // Si quiero comparar por edad:
            if (Edad < otra.Edad) return -1;
            else if (Edad > otra.Edad) return 1;
            else return 0;
            // Si quiero comparar por nombre:
            // return string.Compare(Nombre, otra.Nombre);
        }
    }
}
