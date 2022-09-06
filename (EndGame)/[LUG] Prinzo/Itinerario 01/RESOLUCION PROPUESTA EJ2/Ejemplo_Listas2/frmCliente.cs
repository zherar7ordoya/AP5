using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Listas2
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        //creo el obejto cliente, pero lo instancio cuando lo necesito
        ClsCliente oCliente;
        //creo la lista de objetos localidad
        List<ClsLocalidad> LstLocalidad = new List<ClsLocalidad>();
        //creo la lista de objetos cliente y la hago compartida para poder
        //pasar luego la lista a otro form
        internal static List<ClsCliente> LstClientes = new List<ClsCliente>();
    
           
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //instancio el obejto cliente
                oCliente = new ClsCliente();
                oCliente.Codigo = GenerarCodigo();
                oCliente.Nombre = textBox1.Text;
                oCliente.Apellido = textBox2.Text;
                //paso los datos completos del obejto localidad
                oCliente.oLoc = (ClsLocalidad)comboBox1.SelectedItem;
                //como Forma de pago es abstracta entonces

                if (radioButton1.Checked)
                {
                    FPagoDebito oFPD = new FPagoDebito();
                    oFPD.Cod = 1;
                    oFPD.Forma = "Debito";
                    oCliente.oFPago = oFPD;
                    LstClientes.Add(oCliente);
                    limpiar();
                    CargarGrilla();
                }
                else if (radioButton2.Checked)
                {
                    FPagoCredito oFPC = new FPagoCredito();
                    oFPC.Cod = 2;
                    oFPC.Forma = "Credito";
                    oCliente.oFPago = oFPC;
                    LstClientes.Add(oCliente);
                    limpiar();
                    CargarGrilla();
                }
                else
                { MessageBox.Show("Debe seleccionar una Forma de Pago", "ALERTA");  }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        void CargarComboLocalidad()
        {    //op1 cargo objeto por  objeto a la lista de localidad
            //ClsLocalidad oLoc = new ClsLocalidad();
            //oLoc.ID = 1;
            //oLoc.Nombre = "Caba";
            //LstLocalidad.Add(oLoc);
            //ClsLocalidad oLoc2 = new ClsLocalidad();
            //oLoc2.ID = 2;
            //oLoc2.Nombre = "Castelar";
            //LstLocalidad.Add(oLoc2);
            //ClsLocalidad oLoc3 = new ClsLocalidad();
            //oLoc3.ID = 3;
            //oLoc3.Nombre = "Ituzaingo";
            //LstLocalidad.Add(oLoc3);
            //op2 instancio un objeto localidad
            LstLocalidad.Add(new ClsLocalidad() { ID = 1, Nombre = "Caba" });
            LstLocalidad.Add(new ClsLocalidad() { ID = 2, Nombre = "Castelar" });
            LstLocalidad.Add(new ClsLocalidad() { ID = 3, Nombre = "Ituzaingo" });
            LstLocalidad.Add(new ClsLocalidad() { ID = 4, Nombre = "Moron" });
            LstLocalidad.Add(new ClsLocalidad() { ID = 5, Nombre = "Padua" });

            //lleno al combo con la lista
            this.comboBox1.DataSource = null;
            // lo limpio paraque me actualice cuando agrego valores a la lista
            comboBox1.DataSource = LstLocalidad;
            //aclaro cual es el valor y lo que se desea mostrar en el combo
            comboBox1.ValueMember = "ID";
            //la variable publica de la clase
            comboBox1.DisplayMember = "Nombre";
            comboBox1.Refresh();

        }

       
        void CargarGrilla()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = LstClientes;
            //propiedad de la grilla para autosize de columnas
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambiar el header de la columna 
           this.dataGridView1.Columns["oLoc"].HeaderText = "Localidad";
            this.dataGridView1.Columns["oFPago"].HeaderText = "Forma Pago";
            //en el caso que no quieran mostrar una coulumna
            //this.dataGridView1.Columns["oFPago"].Visible = false;

        }

            

        void limpiar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }


        int GenerarCodigo()
        {
            Random rnd = new Random();
            return rnd.Next(1, 300000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarComboLocalidad();
         }

   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClsCliente oSeleccionado = new ClsCliente();
                oSeleccionado = (ClsCliente)this.dataGridView1.CurrentRow.DataBoundItem;
                textBox3.Text = oSeleccionado.Codigo.ToString();
                textBox1.Text = oSeleccionado.Nombre.ToString();
                textBox2.Text = oSeleccionado.Apellido.ToString();
                comboBox1.SelectedItem = oSeleccionado.oLoc;
                if (oSeleccionado.oFPago.Forma == "Debito")
                {  radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCliente oModificar = new ClsCliente();
                oModificar.Codigo = Convert.ToInt32(this.textBox3.Text);
                oModificar.Nombre = textBox1.Text;
                oModificar.Apellido = textBox2.Text;
                oModificar.oLoc = (ClsLocalidad)comboBox1.SelectedItem;
                if (radioButton1.Checked)
                {
                    FPagoDebito oFPD = new FPagoDebito();
                    oFPD.Cod = 1;
                    oFPD.Forma = "Debito";
                    oModificar.oFPago = oFPD;
                }
                else if (radioButton2.Checked)
                {
                    FPagoCredito oFPC = new FPagoCredito();
                    oFPC.Cod = 2;
                    oFPC.Forma = "Credito";
                    oModificar.oFPago = oFPC;
                }
                //recorro y busco el objeto en la lista
                foreach (ClsCliente item in LstClientes)
                    {
                        //Si esta lo modifico
                        if (oModificar.Codigo == item.Codigo)
                        {
                            item.Nombre = oModificar.Nombre;
                            item.Apellido = oModificar.Apellido;
                            item.oLoc = oModificar.oLoc;
                            item.oFPago = oModificar.oFPago;
                   
                        }
                    }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            finally { 
            //cargo la grilla para que me muestre los datos actualizados
            CargarGrilla();
                limpiar();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try { 
            ClsCliente oBorrar = new ClsCliente();
            DialogResult Respuesta;
             int pos = 0;
            oBorrar.Codigo = Convert.ToInt32(this.textBox3.Text);
            //recorro y busco el objeto en la lista
            foreach (ClsCliente item in LstClientes)
            {
                //Si esta lo borro
                if (oBorrar.Codigo == item.Codigo)
                {
                    Respuesta = MessageBox.Show("¿Confirma la eliminacion del cliente?", "Borrar", MessageBoxButtons.YesNo);
                    if (Respuesta == DialogResult.Yes)
                    {
                        pos = LstClientes.IndexOf(item);
                        //borro el objeto con la posicion
                        LstClientes.RemoveAt(pos);
                       break;
                    }
                    else
                    { break; }

                }
            }

            //vuelvo a cargar para que actualice
            CargarGrilla();
            limpiar();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
    }
}
