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
    public partial class Asignacion : Form
    {
        public Asignacion()
        {
            InitializeComponent();
            oBLLCliente = new BLLCliente();
            oBECliente = new BECliente();
            oBETI = new BETarjetaInternacional();
            oBLLTI = new BLLTarjetaInternacional();
            oBLLTN = new BLLTarjetaNacional();
            oBETI = new BETarjetaInternacional();
            oBETN = new BETarjetaNacional();
            
        }

        BECliente oBECliente;
        BLLCliente oBLLCliente;
        BETarjetaInternacional oBETI;
        BETarjetaNacional oBETN;
        BLLTarjetaNacional oBLLTN;
        BLLTarjetaInternacional oBLLTI;
    

        private void Asignacion_Load(object sender, EventArgs e)
        {
            try
            {
                
                //Cargo Combo
                comboBox1.DataSource = null;
                comboBox2.DataSource = null;
                //llena los comboBox
                comboBox1.DataSource = oBLLCliente.ListarTodo();
                comboBox2.DataSource = oBLLCliente.ListarTodo();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                comboBox1.Refresh();
                radioButton1.Checked = true;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
           

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "Mostrando tarjetas internacionales: ";
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = oBLLTI.ListarTodo();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "Mostrando tarjetas nacionales: ";
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = oBLLTN.ListarTodo();


              


                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Se carga lista de clientes para ver que la tarjeta no se encuentre asociada a otro
                List<BECliente> listaclientes = new List<BECliente>();
                listaclientes = oBLLCliente.ListarTodo();
                //Validar que el cliente no tenga tarjetas asociadas
                //Se captura el objeto cliente seleccionado en el comboBox
                oBECliente=(BECliente)comboBox1.SelectedItem;

                if (oBECliente.TarjetaInternacional != null || oBECliente.TarjetaNacional != null)
                {
                    MessageBox.Show("El cliente ya tiene asignada una tarjeta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    
                    if (radioButton1.Checked)
                    {
                        //Internacionales

                        //Se captura la tarjeta seleccionada por el usuario
                        oBETI = dataGridView1.SelectedRows[0].DataBoundItem as BETarjetaInternacional;

                        BECliente aux = new BECliente();
                        //Validar que la tarjeta no pertenezca a otro cliente
                        aux = listaclientes.Find(x => x.TarjetaInternacional == oBETI);
                        if (aux != null)
                        {
                            MessageBox.Show("La tarjeta ya pertenece a otro cliente");
                        }
                        else
                        {

                            //Validar estado y cambiarlo a Activa
                            if (oBETI.EnumEstado == BETarjeta.Estado.Sin_Asignar)
                            {
                                //Cambio de estado a ACTIVA
                                oBETI.EnumEstado = BETarjeta.Estado.Activa;
                                //Se asigna la tarjeta al cliente
                                oBECliente.TarjetaInternacional = oBETI;
                                //Se guardan los cambios de la tarjeta
                                oBLLTI.Guardar(oBETI);
                                //Se guarda la modificacion
                                oBLLCliente.Guardar(oBECliente);
                                //Refresco grilla y combobox
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = oBLLTI.ListarTodo();
                                comboBox2.DataSource = oBLLCliente.ListarTodo();
                                comboBox2.Refresh();
                            }
                            else { MessageBox.Show("No se pudo realizar la asignación. El estado no es el correcto.", "Error"); }


                        }

                    }
                    if (radioButton2.Checked)
                    {
                        //Se captura la tarjeta seleccionada por el usuario
                        oBETN = dataGridView1.SelectedRows[0].DataBoundItem as BETarjetaNacional;

                        BECliente aux = new BECliente();
                        //Validar que la tarjeta no pertenezca a otro cliente
                        aux = listaclientes.Find(x => x.TarjetaNacional == oBETN);
                        if (aux != null)
                        {
                            MessageBox.Show("La tarjeta ya pertenece a otro cliente");
                        }
                        else
                        {

                            //Validar estado y cambiarlo a Activa
                            if (oBETN.EnumEstado == BETarjeta.Estado.Sin_Asignar)
                            {
                                //Cambio de estado a ACTIVA
                                oBETN.EnumEstado = BETarjeta.Estado.Activa;
                                //Se guardan los cambios de la tarjeta
                                oBLLTN.Guardar(oBETN);
                                //Se asigna la tarjeta al cliente
                                oBECliente.TarjetaNacional = oBETN;
                                //Se guarda la modificacion
                                oBLLCliente.Guardar(oBECliente);
                                //Refresco grilla y combobox
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = oBLLTN.ListarTodo();
                                comboBox2.DataSource = oBLLCliente.ListarTodo();
                                comboBox2.Refresh();
                            }
                            else { MessageBox.Show("No se pudo realizar la asignación. El estado no es el correcto.", "Error"); }



                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Baja LOGICA de tarjeta
            try
            {
                oBECliente = (BECliente)comboBox2.SelectedItem;
                //Valido si no tiene tarjetas
                if (oBECliente.TarjetaNacional == null && oBECliente.TarjetaInternacional == null) { MessageBox.Show("El cliente no tiene tarjetas asociadas", "Error"); }

                //Valido si el cliente tiene tarjeta asociada
                if (oBECliente.TarjetaInternacional!=null)
                {
                    BETarjetaInternacional aux = new BETarjetaInternacional();
                    //Se crea objeto tarjeta auxiliar
                    aux = oBECliente.TarjetaInternacional;
                    //Asigno el estado BAJA
                    aux.EnumEstado = BETarjeta.Estado.Baja;
                    //Se guarda el nuevo estado
                    oBLLTI.Guardar(aux);
                    //Se le saca la tarjeta al cliente
                    oBECliente.TarjetaInternacional = null;
                    //Se guarda el cliente sin la tarjeta
                    oBLLCliente.Guardar(oBECliente);
                    //Refresco grilla
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = oBLLTI.ListarTodo();


                }

                if (oBECliente.TarjetaNacional != null)
                {
                    BETarjetaNacional aux2 = new BETarjetaNacional();
                    //Se crea objeto tarjeta auxiliar
                    aux2 = oBECliente.TarjetaNacional;
                    //Asigno el estado BAJA
                    aux2.EnumEstado = BETarjeta.Estado.Baja;
                    //Se guarda el nuevo estado
                    oBLLTN.Guardar(aux2);
                    //Se le saca la tarjeta al cliente
                    oBECliente.TarjetaNacional = null;
                    //Se guarda el cliente sin la tarjeta
                    oBLLCliente.Guardar(oBECliente);
                    //Refresco grilla
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = oBLLTN.ListarTodo();
                }

                //Actualizo los combobox
                
                comboBox1.DataSource = null;
                comboBox2.DataSource = null;
                
                comboBox1.DataSource = oBLLCliente.ListarTodo();
                comboBox2.DataSource = oBLLCliente.ListarTodo();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                oBECliente = (BECliente)comboBox2.SelectedItem;
                //Pregunto cual tarjeta es y muestro sus datos
                if (oBECliente.TarjetaInternacional != null)
                {
                    textBox2.Text = oBECliente.TarjetaInternacional.Codigo.ToString();
                    textBox3.Text = oBECliente.TarjetaInternacional.Numero.ToString();
                    textBox4.Text = oBECliente.TarjetaInternacional.Saldo.ToString();
                    textBox5.Text = oBECliente.TarjetaInternacional.FechaVencimiento.ToShortDateString();
                    textBox6.Text = oBECliente.TarjetaInternacional.DescuentoAcumulado.ToString();
                    textBox7.Text = "Internacional";
                }
                if (oBECliente.TarjetaNacional != null)
                {
                    textBox2.Text = oBECliente.TarjetaNacional.Codigo.ToString();
                    textBox3.Text = oBECliente.TarjetaNacional.Numero.ToString();
                    textBox4.Text = oBECliente.TarjetaNacional.Saldo.ToString();
                    textBox5.Text = oBECliente.TarjetaNacional.FechaVencimiento.ToShortDateString();
                    textBox6.Text = oBECliente.TarjetaNacional.DescuentoAcumulado.ToString();
                    textBox7.Text = "Nacional";
                }
                if (oBECliente.TarjetaInternacional == null && oBECliente.TarjetaNacional == null)
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

               if(textBox1.Text != "")
               {
                    oBECliente = (BECliente)comboBox2.SelectedItem;

                    //Pregunto cual tarjeta es
                    if (oBECliente.TarjetaInternacional != null)
                    {  
                        //Guardo el objeto tarjeta del cliente
                        oBETI = oBECliente.TarjetaInternacional;

                        //Chequear el estado de la tarjeta y que no este vencida
                        if (oBETI.EnumEstado == BETarjeta.Estado.Activa && oBETI.FechaVencimiento>DateTime.Today)
                        {
                            //Chequear si el saldo es = o mayor al importe de la compra
                            if (oBETI.Saldo >= Convert.ToDouble(textBox1.Text))
                            {
                                //Acumulacion de descuentos
                                oBETI.DescuentoAcumulado = oBETI.DescuentoAcumulado + oBLLTI.AplicarDescuento(Convert.ToDouble(textBox1.Text));
                                //Actualizar saldo
                                oBETI.Saldo = oBETI.Saldo - (Convert.ToDouble(textBox1.Text) - oBLLTI.AplicarDescuento(Convert.ToDouble(textBox1.Text)));

                                //Saldo = a 0?
                                if (oBETI.Saldo == 0)
                                {
                                    oBETI.EnumEstado = BETarjeta.Estado.Sin_Saldo;
                                }

                                //Se guardan las modificaciones de la tarjeta
                                oBLLTI.Guardar(oBETI);
                                //Actualizar Grid
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = oBLLTI.ListarTodo();
                                //Informar datos de la tarjeta y descuento
                                MessageBox.Show("La compra hecha con la tarjeta N° "+ oBETI.Numero + " de tipo Internacional, recibió un descuento de $" + oBLLTI.AplicarDescuento(Convert.ToDouble(textBox1.Text)).ToString(),"Informacion descuento:",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                //Limpio txt de importe
                                textBox1.Text = "";
                              
                            }
                            else { MessageBox.Show("El importe ingresado supera el saldo de la tarjeta","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);}


                        }
                        else { MessageBox.Show("El estado de la tarjeta debe ser activa y no debe estar vencida","Error");}
 

                    }
                    if (oBECliente.TarjetaNacional != null)
                    {
                        //Guardo el objeto tarjeta del cliente
                        oBETN = oBECliente.TarjetaNacional;

                        //Chequear el estado de la tarjeta y la fecha de vencimiento
                        if (oBETN.EnumEstado == BETarjeta.Estado.Activa && oBETN.FechaVencimiento > DateTime.Today)
                        {
                            //Chequear si el saldo es = o mayor al importe de la compra
                            if (oBETN.Saldo >= Convert.ToDouble(textBox1.Text))
                            {
                                //Acumulacion de descuentos
                                oBETN.DescuentoAcumulado = oBETN.DescuentoAcumulado + oBLLTN.AplicarDescuento(Convert.ToDouble(textBox1.Text));
                                //Actualizar saldo
                                oBETN.Saldo = oBETN.Saldo - (Convert.ToDouble(textBox1.Text) - oBLLTN.AplicarDescuento(Convert.ToDouble(textBox1.Text)));

                                //Saldo = a 0?
                                if (oBETN.Saldo == 0)
                                {
                                    oBETN.EnumEstado = BETarjeta.Estado.Sin_Saldo;
                                }
                                //Se guardan las modificaciones de la tarjeta
                                oBLLTN.Guardar(oBETN);
                                //Actualizar grid
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = oBLLTN.ListarTodo();
                                //Informar datos de la tarjeta y descuento
                                MessageBox.Show("La compra hecha con la tarjeta N° " + oBETN.Numero + " de tipo Nacional, recibió un descuento de $" + oBLLTN.AplicarDescuento(Convert.ToDouble(textBox1.Text)).ToString(), "Informacion descuento:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Limpio txt de importe
                                textBox1.Text = "";
                               
                            }
                            else { MessageBox.Show("El importe ingresado supera el saldo de la tarjeta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                        }
                        else { MessageBox.Show("El estado de la tarjeta debe ser activa y no debe estar vencida", "Error"); }
                    }
                    //Si el cliente no posee tarjetas
                    if (oBECliente.TarjetaInternacional == null && oBECliente.TarjetaNacional == null) MessageBox.Show("El cliente no posee tarjetas asociadas");
               }
               else { MessageBox.Show("Ingrese importe de la compra","Error");}
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
      
        }
    }
}
