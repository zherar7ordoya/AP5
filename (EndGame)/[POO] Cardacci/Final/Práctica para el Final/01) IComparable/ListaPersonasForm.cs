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
    public partial class ListaPersonasForm : Form
    {
        public ListaPersonasForm() { InitializeComponent(); }

        private void Formulario_Load(object sender, EventArgs e)
        {
            List<Persona> _listaPersonas = new List<Persona>
            {
                new Persona("Beta", 59),
                new Persona("Alfa", 109),
                new Persona("Gamma", 9)
            };

            // Ordeno la lista por el criterio que elegí en el método CompareTo

            _listaPersonas.Sort();

            ListaPersonasDgv.DataSource = null;
            ListaPersonasDgv.DataSource = _listaPersonas;
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

        public int CompareTo(Persona otraPersona)
        {
            // Si quiero comparar por edad:
            if (Edad < otraPersona.Edad) return -1;
            else if (Edad > otraPersona.Edad) return 1;
            else return 0;
            // Si quiero comparar por nombre:
            // return string.Compare(Nombre, otraPersona.Nombre);
        }
    }
}
