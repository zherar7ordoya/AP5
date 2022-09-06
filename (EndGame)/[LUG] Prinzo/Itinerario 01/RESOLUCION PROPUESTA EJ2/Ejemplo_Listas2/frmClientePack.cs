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
    public partial class frmClientePack : Form
    {
        public frmClientePack()
        {
            InitializeComponent();
        }

        ClsCliente oCli = new ClsCliente();
        ClsPaquete oPack;

        internal static List<ClsCliente> LsClientes = new List<ClsCliente>();
       
       
        private void frmClientePack_Load(object sender, EventArgs e)
        {   
            CargarComboCLiente();
            CargarComboPack();
        }

        void CargarComboCLiente()
        {
          

            //lleno al combo con la lista
            this.cmbCliente.DataSource = null;
            // lo limpio paraque me actualice cuando agrego valores a la lista
            cmbCliente.DataSource = frmCliente.LstClientes;
            //aclaro cual es el valor y lo que se desea mostrar en el combo
            cmbCliente.ValueMember = "Codigo";
            //la variable publica de la clase
            cmbCliente.DisplayMember = "Apellido";
            cmbCliente.Refresh();
        }

        void CargarComboPack()
        {


            //lleno al combo con la lista
            this.cmbPack.DataSource = null;
            // lo limpio paraque me actualice cuando agrego valores a la lista
            cmbPack.DataSource = frmPaquetes.LstPaq;
            //aclaro cual es el valor y lo que se desea mostrar en el combo
            cmbPack.ValueMember = "Cod";
            //la variable publica de la clase
            cmbPack.DisplayMember = "Nombre";
            cmbPack.Refresh();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmbCliente.SelectedItem != null) && (cmbPack.SelectedItem != null))
                {
                    oPack = new ClsPaquete();

                    oCli = (ClsCliente)cmbCliente.SelectedItem;
                    oPack = (ClsPaquete)cmbPack.SelectedItem;

                    //+++++++++++++++++++++++

                    if (oCli.oFPago.Forma == "Debito")
                    {
                        oPack.Abono = oCli.oFPago.CalcularPrecio(oPack.PrecioU);
                        oPack.FechaPago = DateTime.Now;
                    }
                    else
                    { 
                        oPack.Abono = oCli.oFPago.CalcularPrecio(oPack.PrecioU);
                        oPack.FechaPago = DateTime.Now;
                    }

                    //++++++++++++++++++++++++++++

                    //si la lista esta vacia entonces puedo cargar el pack
                    if (oCli.LPaquetes.Count == 0)
                    {                          
                        oCli.LPaquetes.Add(oPack); }
                    else
                    {
                        //si la lista ya tiene algun pack corroboro de no agregar el mismo
                        foreach (ClsPaquete item in oCli.LPaquetes)
                        {
                            if (oPack.Equals(item))
                            { //error personalizado
                                throw new ErrorPersonalizado();

                            }

                        }
                        oCli.LPaquetes.Add(oPack);
                    }
                  
                    CargargrillaCliente_pack();
                  
                }
                else
                {
                    MessageBox.Show("Debe seleccionar algo");

                }
                LsClientes.Add(oCli);
            }
             
            catch (ErrorPersonalizado ex)
            { MessageBox.Show(ex.Message,"ALERTA"); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {


            CargargrillaCliente_pack();

            //uso la interface personalizada para calcular el total
           
            if(cmbCliente.SelectedItem is ICalcular)
            { 
            oCli = (ClsCliente)cmbCliente.SelectedItem;
            label3.Text = "Codigo: " + oCli.Codigo + " Nombre: " + oCli.Nombre + " Apellido: " + oCli.Apellido;
            label4.Text = "Monto Pagado Total: " + ((ICalcular)this.cmbCliente.SelectedItem).CalcularTotal(oCli).ToString();

            }
        }

        void CargargrillaCliente_pack()
        {
            oCli = (ClsCliente)cmbCliente.SelectedItem;
            if (oCli.LPaquetes.Count == 0)
            {
                this.dataGridView1.DataSource = null;
                   }
            else
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = oCli.LPaquetes;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargargrillaCliente_pack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oPack = new ClsPaquete();

            oCli = (ClsCliente)cmbCliente.SelectedItem;
           oPack = (ClsPaquete)cmbPack.SelectedItem;
            DialogResult Resultado;
            Resultado =MessageBox.Show("Esta seguro que desea desuscribirse del pack? " + oPack.Nombre ,"ATENCION",MessageBoxButtons.OKCancel);
            if (Resultado == DialogResult.OK)
            {
                if (oCli.LPaquetes.Count > 0)
                { foreach (ClsPaquete item in oCli.LPaquetes)
                    { if (oPack.Cod == item.Cod)
                        {
                            oCli.LPaquetes.Remove(oPack);
                            break;
                        }
                      
                    }
                }
            }
            CargargrillaCliente_pack();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oPack = (ClsPaquete)this.dataGridView1.CurrentRow.DataBoundItem;
            this.cmbPack.SelectedItem = oPack;
   
        }
    }
}
