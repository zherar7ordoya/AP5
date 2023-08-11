using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Integrador
{
    public partial class IntegradorForm : Form
    {
        public IntegradorForm()
        {
            InitializeComponent();
        }

        Empresa MiEmpresa = new Empresa();
        IComparer<Persona<int>> OrdenNom = new Persona<int>.NombreAsc(); //por defecto lo pongo nombre ascendente
        int IdTitAuto = 1;
        int IdPersona = 1;
        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                Persona<int> P = new Persona<int>();
                //Suscribo a los Eventos, Si despues cambio la edad saltan tambien
                P.MayordeEdad += new EventHandler(FuncionMayorEdad);
                P.MenorDeEdad += new EventHandler<MenordeEdadEventArgs> (FuncionMenorEdad);

                P.Dni = int.Parse(Interaction.InputBox("Dni"));
                P.Nombre = Interaction.InputBox("Nombre");
                P.Edad = int.Parse(Interaction.InputBox("Edad"));
                P.Id = IdPersona;
                MiEmpresa.AgregarPersona(P);
                Mostrar();
                IdPersona++;
            }
            catch (Exception ex) when (ex.Message.Contains("La edad no puede ser negativa"))
            {

                MessageBox.Show("Andate a la puta que te parió");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Finally");
            }
        }

        private void FuncionMenorEdad(object sender, MenordeEdadEventArgs e)
        {
            MessageBox.Show("Se ingresó un menor de " + e.Edad + " años");
        }

        private void FuncionMayorEdad(object sender, EventArgs e)
        {
            MessageBox.Show("Se ingresó un mayor de 65, pero no se la edad exacta.");
        }

        private void Mostrar()
        {
            Grilla1.DataSource = null;
            if (RB1.Checked == true || RB2.Checked==true)
            {

                List<Persona<int>> LP = MiEmpresa.RetornaPersonas();
                LP.Sort(OrdenNom);
                Grilla1.DataSource = LP.ToList<Persona<int>>();
            }
            else
            {
                List<Persona<int>> LP = MiEmpresa.RetornaPersonas();
                LP.Sort();
                Grilla1.DataSource = LP.ToList<Persona<int>>();
            }
        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            OrdenNom = new Persona<int>.NombreAsc();
            Mostrar();
        }

        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
            OrdenNom = new Persona<int>.NombreDesc();
            Mostrar();
        }

        private void RB3_CheckedChanged(object sender, EventArgs e)
        {
            
            Mostrar();
        }

        private void btnModPersona_Click(object sender, EventArgs e)
        {
            try
            {
                Persona<int> PClonada = new Persona<int>();

                try
                {
                    PClonada = Grilla1.SelectedRows[0].DataBoundItem as Persona<int>;
                }
                catch (Exception)
                {

                    throw new Exception("No hay Personas");
                }

                int Edad = int.Parse(Interaction.InputBox("Edad", "Modificar Edad", PClonada.Edad.ToString()));
               

                MiEmpresa.ModificarEdad(PClonada,Edad);
                Mostrar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                Auto A = new Auto();
                A.VerificarModelo += VerModelo;
                A.Marca = Interaction.InputBox("Marca", "Ingresar Auto", "VW");
                A.Patente = Interaction.InputBox("Patente", "Ingresar Auto", "AD321HY");
                A.Modelo = int.Parse(Interaction.InputBox("Modelo"));
                A.IdTitular = IdTitAuto; 
                string mensaje=A.VerificarModelo(A.Modelo);

                MessageBox.Show("Está ingresando el ID: "+A.Retornaalgo<int>(IdTitAuto));

                MessageBox.Show(mensaje);
                MiEmpresa.AgregarAuto(A);
                MostrarAutos();
                IdTitAuto++;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private string VerModelo(int a)
        {
            if (a < 2000) return "Es anterior al 2000";
            else return "Es un auto Moderno";
        }

        private void MostrarAutos()
        {
            Grilla2.DataSource = null;
            if (rbTodos.Checked == true)
            {
                Grilla2.DataSource = MiEmpresa.RetornaAutos().ToList<Auto>();
            }
            else if (rbViejos.Checked == true)
            {
                Grilla2.DataSource = MiEmpresa.RetornaAutosViejos().ToList<Auto>();
            }
            else if (radioButton1.Checked == true)
            {
                Grilla2.DataSource = MiEmpresa.RetornaAutosTitulares();///lista anonima
            }
            else if (rbAutosNuevos.Checked == true)
            {
                Grilla2.DataSource = MiEmpresa.RetornoAutosNuevos();
            }
        }

        private void btnPatente_Click(object sender, EventArgs e)
        {
            try
            {
                Auto A = new Auto();
                try
                {
                    A = Grilla2.SelectedRows[0].DataBoundItem as Auto;
                }
                catch (Exception)
                {

                    throw new Exception("No hay Autos");
                }

                foreach(string s in A)
                {
                    MessageBox.Show(s);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            MostrarAutos();
        }

        private void rbViejos_CheckedChanged(object sender, EventArgs e)
        {
            MostrarAutos();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MostrarAutos();
        }

        private void rbAutosNuevos_CheckedChanged(object sender, EventArgs e)
        {
            MostrarAutos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Func<int, bool> NombreFunc = x => x == 1;
            bool R = NombreFunc(1);


            Func<int, string> Func2=Funcion;
            
        }
        public delegate string MiDel(int a);
        Func<string, int> MiDel2;

        public string Funcion(int a)
        {
            return "";
        }
    }
}
