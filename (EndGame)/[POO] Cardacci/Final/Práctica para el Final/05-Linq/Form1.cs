using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _05_Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa E = new Empresa();

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            if (radioButton1.Checked == true) dataGridView1.DataSource = E.RetornaTodasLasPersonas();
            if(radioButton2.Checked==true) dataGridView1.DataSource = E.FiltroNacionalidad();
            if (radioButton3.Checked == true) dataGridView1.DataSource = E.AgruparNacionalidad();
            if (radioButton4.Checked == true) dataGridView1.DataSource = E.RetornaAnonimo();
            if (radioButton5.Checked == true) dataGridView1.DataSource = E.Join();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Persona P = new Persona(25029996,"Alejandro","Cancelos","Argentina",44);
             E.AgregarPersona(P);
           P = new Persona(26147196, "Romina", "Perez", "Paraguaya", 24);
            E.AgregarPersona(P);
             P = new Persona(1234567, "Francisco", "Rodriguez", "Argentina", 14);
            E.AgregarPersona(P);
             P = new Persona(42658987, "Santiago", "Gonzalez", "Paraguaya", 4);
            E.AgregarPersona(P);
             P = new Persona(53698745, "Lucia", "Cardacci", "Argentina", 54);
            E.AgregarPersona(P);
            button2.Enabled = false;
            Mostrar();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }
    }

    public class Persona : ICloneable
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public int Edad { get; set; }

        public Persona()
        {

        }

        public Persona(int pDni,string pNombre, string pApellido, string pNacionalidad,int pEdad)
        {
            Dni = pDni;
            Nombre = pNombre;
            Apellido = pApellido;
            Nacionalidad = pNacionalidad;
            Edad = pEdad;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class Empresa
    {
        private List<Persona> LP;
        private List<int> Lint;

        public Empresa()
        {
            LP = new List<Persona>();
            Lint = new List<int>();
            Lint.Add(40);
            Lint.Add(41);
            Lint.Add(42);
            Lint.Add(43);
            Lint.Add(44);

        }

        public void AgregarPersona(Persona pPersona)
        {
            ///vamos a verificar por linq que el dni no exista
            ///

            var x = from P in LP where P.Dni == pPersona.Dni select P;
            if (x.Count() == 0)
            {
              LP.Add(pPersona);
            }
            else
            {
                MessageBox.Show("Ya existe");
            }          
        }

        public List<Persona> RetornaTodasLasPersonas() //retorna Todos las personas
        {
            List<Persona> ListaRetorno = new List<Persona>();
            var x = from P in LP select P;
            foreach(Persona p in x)
            {
                ListaRetorno.Add((Persona)p.Clone());
            }

            return ListaRetorno;
        }

        public IEnumerable RetornaAnonimo() 
        {
            var x = from P in LP select new  { Nombre = P.Nombre };
            return x.ToList();
            
           
           
        }

        public List<Persona> FiltroNacionalidad()
        {
            List<Persona> ListaRetorno = new List<Persona>();
            var x = from P in LP where P.Nacionalidad == "Argentina" select P;
            foreach (Persona p in x)
            {
                ListaRetorno.Add((Persona)p.Clone());
            }
            return ListaRetorno;
        }

        public List<Persona> FiltroPorLetra()
        {
            List<Persona> ListaRetorno = new List<Persona>();
            var x = from P in LP where P.Nombre[0]=='A' select P;
            foreach (Persona p in x)
            {
                ListaRetorno.Add((Persona)p.Clone());
            }
            return ListaRetorno;
        }

        public List<Persona> OrdenarPorNombre()
        {
            List<Persona> ListaRetorno = new List<Persona>();
            var x = from P in LP orderby P.Nombre ascending select P;
            foreach (Persona p in x)
            {
                ListaRetorno.Add((Persona)p.Clone());
            }
            return ListaRetorno;
        }

        public List<Persona> AgruparNacionalidad()
        {

            List<Persona> ListaRetorno = new List<Persona>();
            var x = from P in LP group P by P.Nacionalidad;

            foreach (var Nacionalidad in x)
            {
                foreach (Persona p in Nacionalidad)
                {
                    ListaRetorno.Add((Persona)p.Clone());
                }
            }

            return ListaRetorno;
        }

        public IEnumerable Join()
        {
            List<Persona> ListaRetorno = new List<Persona>();
            var x = from P in LP
                    join 
                    num in Lint on P.Edad equals num
                    select new { Nombre = P.Nombre, Numero = num };         
            return x.ToList();
        }


    }
}
