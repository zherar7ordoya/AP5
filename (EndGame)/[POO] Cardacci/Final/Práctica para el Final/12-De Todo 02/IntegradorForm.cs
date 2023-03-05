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

namespace CloneableComparableDisposableEnumerable
{
    public partial class IntegradorForm : Form
    {
        public IntegradorForm() => InitializeComponent();

        Empresa empresa = new Empresa();
        IComparer<Cliente> _dniAsc = new Cliente.DniAsc();

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(Interaction.InputBox("Dni:"));
                string nombre = Interaction.InputBox("Nombre");
                string codigo = Interaction.InputBox("Codigo", "Codigo", "ABCD-1234");

                var respuesta = MessageBox.Show("¿Es Premium?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    Cliente cliente = new ClientePremium();
                    cliente.DniNoValidoEventHandler += new EventHandler<DniNoValidoEventArgs>(FuncionEvento);
                    cliente.DelegadoMuestraMensaje += MuestraMensaje;

                    MessageBox.Show($"Mensaje del delegado: {cliente.DelegadoMuestraMensaje()}");
                    if (cliente.FuncMuestraMensaje(1) == true) MessageBox.Show("Mensaje enviado por Func");

                    cliente.DNI = dni;
                    cliente.Nombre = nombre;
                    cliente.Codigo = codigo;

                    MessageBox.Show($"Cuota a pagar: {cliente.Cuota()}");

                    empresa.AgregarCliente(cliente);
                    cliente.Dispose();
                }
                else
                {
                    Cliente cliente = new ClienteComun();
                    cliente.DniNoValidoEventHandler += new EventHandler<DniNoValidoEventArgs>(FuncionEvento);
                    cliente.DelegadoMuestraMensaje += MuestraMensaje;

                    MessageBox.Show($"Mensaje del delegado: {cliente.DelegadoMuestraMensaje()} ");
                    cliente.DNI = dni;
                    cliente.Nombre = nombre;
                    cliente.Codigo = codigo;

                    MessageBox.Show($"Cuota a pagar: {cliente.Cuota()}");

                    empresa.AgregarCliente(cliente);
                    cliente.Dispose();
                }
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string MuestraMensaje()
        {
            return "Mensaje enviado por el delegado";
        }

        private void FuncionEvento(object sender, DniNoValidoEventArgs e)
        {
            MessageBox.Show("El Dni: " + e.DNI + " Es trucho.");
        }

        private void Mostrar()
        {
            if (radioButton1.Checked == true)
            {
                List<Cliente> LC = empresa.GetClientes();
                LC.Sort();
                ClientesDgv.DataSource = null;
                ClientesDgv.DataSource = LC;
            }
            else if (radioButton2.Checked == true)
            {
                List<Cliente> LC = empresa.GetClientes();
                LC.Sort(_dniAsc);
                ClientesDgv.DataSource = null;
                ClientesDgv.DataSource = LC;
            }

            else if (radioButton3.Checked == true)
            {
                List<Cliente> LC = empresa.RetornaComienzanConA();

                ClientesDgv.DataSource = null;
                ClientesDgv.DataSource = LC;
            }
            Grilla2.DataSource = null;
            Grilla2.DataSource = empresa.RetornaSoloNombres();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente C;
                try
                {
                    C = ClientesDgv.SelectedRows[0].DataBoundItem as Cliente;
                }
                catch (Exception)
                {

                    throw new Exception("No hay Clientes");
                }

                foreach (string s in C)
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

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;

            if (empresa.RetornaBusqueda(nombre).Count == 0) MessageBox.Show("Cliente no encontrado");
            else
            {
                ClientesDgv.DataSource = null;
                ClientesDgv.DataSource = empresa.RetornaBusqueda(nombre);
            }
        }
    }
}
