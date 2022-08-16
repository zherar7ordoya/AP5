using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace Parcial1
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            oBECliente = new BECliente();
            oBLLCliente = new BLLCliente();
        }

        BECliente oBECliente;
        BLLCliente oBLLCliente;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        //el nombre del form difiere porque al crearlo me equivoque y lo nombre Empleados
        private void Empleados_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

        }

        void Limpiartxt()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Today;
        }
        void CargarGrilla()
        {
            dataGridView1.DataSource = null;
            //llamada a metodo que me devuelve la lista de clientes
            dataGridView1.DataSource = oBLLCliente.ListarTodo();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Se crea objeto cliente auxiliar para traer los datos a los txt
                BECliente aux = new BECliente();
                aux = dataGridView1.SelectedRows[0].DataBoundItem as BECliente;
                textBox1.Text = aux.Codigo.ToString();
                textBox2.Text = aux.Nombre;
                textBox3.Text = aux.Apellido;
                textBox4.Text = aux.DNI.ToString();
                dateTimePicker1.Value = aux.FechaNacimiento;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar que se hayan ingresado datos en los campos
                if (textBox2.Text !="" && textBox3.Text!="" && textBox4.Text != "")
                {
                    BECliente aux = new BECliente();
                    if (textBox1.Text != "") aux.Codigo = Convert.ToInt32(textBox1.Text);
                    aux.Nombre = textBox2.Text;
                    aux.Apellido = textBox3.Text;
                    aux.DNI = Convert.ToInt32(textBox4.Text);
                    aux.FechaNacimiento = dateTimePicker1.Value;
                    //Al modificar preguntar si tiene tarjetas y las guardo
                    if ((dataGridView1.SelectedRows[0].DataBoundItem as BECliente).TarjetaInternacional != null)
                    {
                        aux.TarjetaInternacional = (dataGridView1.SelectedRows[0].DataBoundItem as BECliente).TarjetaInternacional;
                    }
                    if ((dataGridView1.SelectedRows[0].DataBoundItem as BECliente).TarjetaNacional != null)
                    {
                        aux.TarjetaNacional = (dataGridView1.SelectedRows[0].DataBoundItem as BECliente).TarjetaNacional;
                    }
                    

                    if (oBLLCliente.Guardar(aux) == false) { MessageBox.Show("No fue posible guardar los cambios", "Alerta"); }
                    else
                    {
                        MessageBox.Show("Los cambios se realizaron correctamente");
                        Limpiartxt();
                        CargarGrilla();
                    }
                }
                else { MessageBox.Show("Por favor, complete los datos del cliente","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);}
                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BECliente aux = new BECliente();
                aux = dataGridView1.SelectedRows[0].DataBoundItem as BECliente;

                //Se verifica si el cliente tiene tarjetas asociadas, se chequea directo de memoria
                //Ya que se trajo el objeto Tarjeta desde la base al leer los Clientes
                if(aux.TarjetaInternacional!=null || aux.TarjetaNacional != null)
                {
                    MessageBox.Show("El cliente a dar de baja no puede tener tarjetas asociadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Confirmacion del usuario
                    DialogResult rta;
                    rta = MessageBox.Show("Esta seguro que desea eliminar el cliente?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rta == DialogResult.Yes)
                    {
                        
                        if (oBLLCliente.Baja(aux) == true)
                        { 
                            MessageBox.Show("El cliente se dio de baja", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //Refresco datagrid
                            CargarGrilla();
                            //Limpio los txt
                            Limpiartxt();
                        }
                        else { MessageBox.Show("No se pudo dar de baja el cliente","Error");}
                       
                    }
                }

                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


    }
}
