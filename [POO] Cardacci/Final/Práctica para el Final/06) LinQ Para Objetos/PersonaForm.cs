using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace LinQParaObjetos
{
    public partial class PersonaForm : Form
    {
        public PersonaForm()
        {
            InitializeComponent();
        }

        readonly Empresa _empresa = new Empresa();

        private void Mostrar()
        {
            Dgv.DataSource = null;
            if (radioButton1.Checked == true) Dgv.DataSource = _empresa.GetTodas();
            if (radioButton2.Checked == true) Dgv.DataSource = _empresa.FiltraNacionalidad();
            if (radioButton3.Checked == true) Dgv.DataSource = _empresa.AgrupaNacionalidad();
            if (radioButton4.Checked == true) Dgv.DataSource = _empresa.GetAnonimo();
            if (radioButton5.Checked == true) Dgv.DataSource = _empresa.Join();
            if (radioButton6.Checked == true) Dgv.DataSource = _empresa.FiltraPorLetra();
            if (radioButton7.Checked == true) Dgv.DataSource = _empresa.OrdenaPorNombre();
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(25029996, "Alejandro", "Cancelos", "Argentina", 44);
            _empresa.AgregaPersona(persona);
            persona = new Persona(26147196, "Romina", "Perez", "Paraguaya", 24);
            _empresa.AgregaPersona(persona);
            persona = new Persona(1234567, "Francisco", "Rodriguez", "Argentina", 14);
            _empresa.AgregaPersona(persona);
            persona = new Persona(42658987, "Santiago", "Gonzalez", "Paraguaya", 4);
            _empresa.AgregaPersona(persona);
            persona = new Persona(53698745, "Lucia", "Cardacci", "Argentina", 54);
            _empresa.AgregaPersona(persona);
            Btn.Enabled = false;
            Mostrar();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }
    }

    public class Persona : ICloneable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public int Edad { get; set; }

        public Persona(
            int dni,
            string nombre,
            string apellido,
            string nacionalidad,
            int edad)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
            Edad = edad;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }


    public class Empresa
    {
        private List<Persona> _listaPersonas;
        private List<int> _listaEnteros;

        public Empresa()
        {
            _listaPersonas = new List<Persona>();
            _listaEnteros = new List<int> { 4, 24, 40, 41, 42, 43, 44 };
        }

        public void AgregaPersona(Persona persona)
        {
            // Verifico que el DNI no exista
            var filtro = from x
                         in _listaPersonas
                         where x.DNI == persona.DNI
                         select x;

            if (filtro.Count() == 0) _listaPersonas.Add(persona);
            else MessageBox.Show("Ya existe");
        }

        // *********************************************************************

        /**                                                                   **  
         * Aquí se ven dos maneras de trabajar los retornos: con var           *
         * (sometiéndolo al método ToList()) o con List<Persona> (que          * 
         * posibilita que pueda hacerse una clonación)                         * 
         */


        public List<Persona> GetTodas()
        {
            List<Persona> lista = new List<Persona>();

            var personas = from persona
                           in _listaPersonas
                           select persona;

            foreach (Persona persona in personas)
            {
                lista.Add((Persona)persona.Clone());
            }

            return lista;
        }


        public List<Persona> FiltraNacionalidad()
        {
            //List<Persona> lista = new List<Persona>();

            var personas = from persona
                           in _listaPersonas
                           where persona.Nacionalidad == "Argentina"
                           select persona;
            return personas.ToList();
            //foreach (Persona persona in personas)
            //{
            //    lista.Add((Persona)persona.Clone());
            //}

            //return lista;
        }


        public List<Persona> AgrupaNacionalidad()
        {
            List<Persona> lista = new List<Persona>();

            var personas = from persona
                           in _listaPersonas
                           group persona
                           by persona.Nacionalidad;

            foreach (var nacionalidad in personas)
            {
                foreach (Persona persona in nacionalidad)
                {
                    lista.Add((Persona)persona.Clone());
                }
            }

            return lista;
        }


        // ¿Qué quisiste hacer aquí?
        public IEnumerable GetAnonimo()
        {
            var personas = from persona
                           in _listaPersonas
                           select new { persona.Nombre };
            return personas.ToList();
        }

        // ¿Qué quisiste hacer aquí?
        public IEnumerable Join()
        {
            var personas = from persona in _listaPersonas
                           join numero in _listaEnteros
                           on persona.Edad equals numero
                           select new { persona.Nombre, Numero = numero };
            return personas.ToList();
        }

        // *********************************************************************

        public List<Persona> FiltraPorLetra()
        {
            List<Persona> lista = new List<Persona>();
            var personas = from persona
                           in _listaPersonas
                           where persona.Nombre[0] == 'A'
                           select persona;
            foreach (Persona persona in personas)
            {
                lista.Add((Persona)persona.Clone());
            }
            return lista;
        }

        public List<Persona> OrdenaPorNombre()
        {
            var personas = from persona in _listaPersonas
                           orderby persona.Nombre ascending
                           select persona;
            return personas.ToList();
        }







    }
}
