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

namespace _14_De_Todo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empresa MiEmpresa = new Empresa();
        IComparer<Cliente> IdAsc = new Cliente.IdAsc();
        public delegate int MiDelegado(int a);
        MiDelegado Del1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente.EsNacional += FuncionEsNacional;
            Del1 += FuncionDel1;

            Del1(45);

            Func<int, string> MiDelegado2 = FuncionDel2;
            MessageBox.Show("Devuelvo una" + MiDelegado2(2));
        }

        private string FuncionDel2(int arg)
        {
            MessageBox.Show("Recibi un " + arg);
            return "Cadena";
        }

        private int FuncionDel1(int a)
        {
            MessageBox.Show("Soy el Delegado: "+a);
            return 0;
        }

        private void FuncionEsNacional(object sender, NacionalEventArgs e)
        {
            MessageBox.Show("El Cliente: " + e.Nombre + " es Nacional.");
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = Interaction.InputBox("Id Cliente:", "Nuevo Cliente", "AR-1234");
                string Nombre = Interaction.InputBox("Nombre:");

                if (Id.Substring(0, 2) == "AR")
                {
                    Cliente C = new ClienteNacional();
                    C.Id = Id;
                    C.Nombre = Nombre;
                    MiEmpresa.AgregarCliente(C);
                }
                else
                {
                    Cliente C = new ClienteExtranjero();
                    C.Id = Id;
                    C.Nombre = Nombre;
                    MiEmpresa.AgregarCliente(C);
                }

                Mostrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void Mostrar()
        {
            Grilla1.DataSource = null;
            List<Cliente> LC = MiEmpresa.RetornaClientes();

            if (rbNomAsc.Checked == true)
            {
                LC.Sort();    
                Grilla1.DataSource = LC;
            }
            else if (rbIdAsc.Checked == true)
            {
                LC.Sort(IdAsc);
                Grilla1.DataSource = LC;
            }
            else if (rbGroupPais.Checked == true)
            {
                LC = MiEmpresa.AgruparPorCodigo();
                Grilla1.DataSource = LC;
            }
            Grilla2.DataSource = null;
            Grilla2.DataSource = MiEmpresa.RetornaPaises();
            Grilla3.DataSource = null;
            Grilla3.DataSource = MiEmpresa.RetornaClientePais();
        }

        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = Interaction.InputBox("Nombre");
                string Codigo = Interaction.InputBox("Codigo", "Codigo Pais", Nombre.Substring(0, 2).ToUpper());
                Pais<string> P = new Pais<string>();
                P.Codigo = Codigo;
                P.Nombre = Nombre;
                MessageBox.Show(P.RetornaCadena<int>(3));
                MessageBox.Show(P.RetornaCadena<DateTime>(DateTime.Now));
                MessageBox.Show(P.RetornaCadena<decimal>(10.2m));
                MiEmpresa.AgregarPais(P);
                Mostrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
        }

        private void rbNomAsc_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void rbIdAsc_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void rbGroupPais_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Codigo = "";
               foreach( string s in (Grilla1.SelectedRows[0].DataBoundItem as Cliente))
                {
                    Codigo += s;
                }

                MessageBox.Show(Codigo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
