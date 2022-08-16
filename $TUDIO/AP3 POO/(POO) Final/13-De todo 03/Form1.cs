using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _13_De_todo_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empresa MiEmpresa = new Empresa();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Persona.NombreDeMierda += FuncionDeMierda;

            Persona P = new Persona(1,"Mierda");
            Auto A = new Auto();
            A.EventoComun += MetodoComun;
            A.EventoPersonalizado += new EventHandler<EventoPersonalizadoEventArgs>(this.MetodoComun);

            //Persona P2 = new Persona();
            //P2.Nombre = "Mierda";
        }

        private void MetodoComun(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MetodoComun(object sender, EventoPersonalizadoEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FuncionDeMierda(object sender, EventArgs e)
        {
            MessageBox.Show("Sos una mierda");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Persona P3 = new Persona();
            P3.Nombre = "Mierda";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Auto A = new Auto();
                A.Marca = Interaction.InputBox("Marca");
                A.Patente = Interaction.InputBox("Patente");
                A.Modelo = int.Parse(Interaction.InputBox("Modelo"));
                MiEmpresa.AgregarAuto(A);

                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = MiEmpresa.GroupByModelo();

            dataGridView1.DataSource = MiEmpresa.UsarJoin();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var A = dataGridView1.SelectedRows[0].DataBoundItem as VistaInservible;

            MessageBox.Show("Es un"+A.GetType().ToString());
        }
    }
}
