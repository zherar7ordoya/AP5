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

namespace _12_De_Todo_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa MiEmpresa = new Empresa();
        IComparer<Cliente> DniAsc = new Cliente.DniAsc();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                

                int Dni = int.Parse(Interaction.InputBox("Dni:"));
                string Nombre = Interaction.InputBox("Nombre");
                string Codigo = Interaction.InputBox("Codigo", "Codigo", "ABCD-1234");
                var R = MessageBox.Show("Es Premium?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    Cliente C = new ClientePremium();
                    C.DniTrucho += new EventHandler<DniTruchoEventArgs>(this.FuncionEvento);
                    C.Del1 += FuncionDelegado;
                    MessageBox.Show("El Delegado me dijo: " + C.Del1());

                    if (C.MiFunc(1) == true)
                    {
                        MessageBox.Show("Soy func");
                    }
                    C.Dni = Dni;
                    C.Nombre = Nombre;
                    C.Codigo = Codigo;

                    MessageBox.Show("Paga: " + C.Cuota());
                    MiEmpresa.AgregarCliente(C);
                    C.Dispose();
                }
                else
                {
                    Cliente C = new ClienteComun();
                    C.DniTrucho += new EventHandler<DniTruchoEventArgs>(this.FuncionEvento);
                    C.Del1 += FuncionDelegado;
                    MessageBox.Show("El Delegado me dijo: " + C.Del1());
                    C.Dni = Dni;
                    C.Nombre = Nombre;
                    C.Codigo = Codigo;
                    MessageBox.Show("Paga: " + C.Cuota());
                    MiEmpresa.AgregarCliente(C);
                    C.Dispose();
                }

                Mostrar();
                

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private string FuncionDelegado()
        {
            return "Mensaje";
        }

        private void FuncionEvento(object sender, DniTruchoEventArgs e)
        {
            MessageBox.Show("El Dni: " + e.Dni + " Es trucho.");
        }

        private void Mostrar()
        {
            if (radioButton1.Checked == true)
            {
                List<Cliente> LC = MiEmpresa.RetornaClientes();
                LC.Sort();
                Grilla1.DataSource = null;
                Grilla1.DataSource = LC;
            }
            else if (radioButton2.Checked == true)
            {
                List<Cliente> LC = MiEmpresa.RetornaClientes();
                LC.Sort(DniAsc);
                Grilla1.DataSource = null;
                Grilla1.DataSource = LC;
            }

            else if (radioButton3.Checked == true)
            {
                List<Cliente> LC = MiEmpresa.RetornaComienzanConA();
                
                Grilla1.DataSource = null;
                Grilla1.DataSource = LC;
            }
            Grilla2.DataSource = null;
            Grilla2.DataSource = MiEmpresa.RetornaSoloNombres();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente C;
                try
                {
                    C = Grilla1.SelectedRows[0].DataBoundItem as Cliente;
                }
                catch (Exception)
                {

                    throw new Exception("No hay Clientes");
                }

                foreach(string s in C)
                {
                    MessageBox.Show(s);
                }
               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Busqueda = txtBuscar.Text;

           if(MiEmpresa.RetornaBusqueda(Busqueda).Count == 0)
            {
                MessageBox.Show("No se encontró");
            }
            else
            {
                Grilla1.DataSource = null;
                Grilla1.DataSource = MiEmpresa.RetornaBusqueda(Busqueda);
            }
        }
    }
}
