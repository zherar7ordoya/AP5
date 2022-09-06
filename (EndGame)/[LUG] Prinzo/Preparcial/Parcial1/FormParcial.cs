using System;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class FormParcial : Form
    {
        public Cliente cliente;
        public TInternacional tinternacional;
        public TNacional tnacional;

        public FormParcial()
        {
            InitializeComponent();

            textBoxPais.Visible = false;

            label18.Visible = false;
        }

        private void buttonCargaTarjeta_Click(object sender, EventArgs e)
        {
            if (textBoxNTarjeta.Text == string.Empty || textBoxSaldoT.Text == string.Empty)
            {
                MessageBox.Show("Falta completar datos");
            }
            else
            {
                #region radiobutton nacional

                if (radioButtonNacional.Checked)
                {
                    if (textBoxProvincia.Text == string.Empty)
                    {
                        MessageBox.Show("Complete provincia");
                    }
                    else
                    {
                        //Se ve muy feo, pero quería demostrar el constructor
                        tnacional = new TNacional(
                                               Convert.ToInt32(textBoxNTarjeta.Text),
                                               dateTimeVencTarj.Value,
                                               Convert.ToDouble(textBoxSaldoT.Text),
                                               "Baja",
                                               comboBoxRubro.Text,
                                               textBoxProvincia.Text);

                        listBoxTarjetasNac.Items.Add(tnacional);

                        textBoxNTarjeta.Text = string.Empty;
                        textBoxSaldoT.Text = string.Empty;
                        textBoxProvincia.Text = string.Empty;
                    }
                }

                #endregion radiobutton nacional

                #region radiobutton internacional

                if (radioButtonInternacional.Checked)
                {
                    if (textBoxPais.Text == string.Empty)
                    {
                        MessageBox.Show("Seleccione país");
                    }
                    else
                    {
                        tinternacional = new TInternacional();
                        tinternacional.Pais = textBoxPais.Text;
                        tinternacional.Estado = "Baja";
                        tinternacional.FechaVencimiento = dateTimeVencTarj.Value;
                        tinternacional.Numero = Convert.ToInt32(textBoxNTarjeta.Text);
                        tinternacional.Rubro = comboBoxRubro.Text;
                        tinternacional.Saldo = Convert.ToDouble(textBoxSaldoT.Text);

                        listBoxTarjetasInt.Items.Add(tinternacional);

                        textBoxNTarjeta.Text = string.Empty;
                        textBoxSaldoT.Text = string.Empty;
                        textBoxPais.Text = string.Empty;
                    }
                }

                #endregion radiobutton internacional
            }
        }

        private void buttonCargaCliente_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == string.Empty || textBoxApellido.Text == string.Empty || textBoxDNI.Text == string.Empty)
            {
                MessageBox.Show("Faltan campos por completar");
            }
            else
            {
                cliente = new Cliente();

                cliente.Nombre = textBoxNombre.Text;
                cliente.Apellido = textBoxApellido.Text;
                cliente.DNI = Convert.ToInt32(textBoxDNI.Text);
                cliente.FechaNacimiento = dateTimePickerFNacCliente.Value;

                listBoxClientes.Items.Add(cliente);

                textBoxNombre.Text = string.Empty;
                textBoxApellido.Text = string.Empty;
                textBoxDNI.Text = string.Empty;
                //Reseteo el datetime poniendolo a hoy
                dateTimePickerFNacCliente.Value = DateTime.Today;
            }
        }

        #region RadioButtons

        private void radioButtonNacional_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPais.Visible = false;
            textBoxProvincia.Visible = true;
            label17.Visible = true;
            label18.Visible = false;
        }

        private void radioButtonInternacional_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPais.Visible = true;
            textBoxProvincia.Visible = false;
            label17.Visible = false;
            label18.Visible = true;
        }

        #endregion RadioButtons

        private void buttonAsociarTarjeta_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

            #region Tarjetas Internacionales

            if (listBoxTarjetasInt.SelectedItem != null)
            {
                TInternacional tarjInternacional = (TInternacional)listBoxTarjetasInt.SelectedItem;
                tarjInternacional.Estado = "Activa";
                listBoxClientes.Items.Remove(cliente);
                cliente.TarjetaAsociada = tarjInternacional;
                listBoxClientes.Items.Add(cliente);
                listBoxTarjetasInt.ClearSelected();
                MessageBox.Show("Asociada");
            }

            #endregion Tarjetas Internacionales

            #region tarjetas Nacionales

            else if (listBoxTarjetasNac.SelectedItem != null)
            {
                TNacional tarjeta = (TNacional)listBoxTarjetasNac.SelectedItem;
                tarjeta.Estado = "Activa";
                listBoxClientes.Items.Remove(cliente);
                cliente.TarjetaAsociada = tarjeta;
                listBoxClientes.Items.Add(cliente);
                listBoxTarjetasInt.ClearSelected();
                MessageBox.Show("Asociada");
            }

            #endregion tarjetas Nacionales
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null && cliente.TarjetaAsociada != null)
            {
                if (cliente.TarjetaAsociada == tinternacional)
                {
                    if (tinternacional.FechaVencimiento < DateTime.Now)
                    {
                        tinternacional.Estado = "Vencida";
                    }
                    
                    labelProvincia.Text = string.Empty;
                    labelEstado.Text = "Estado: " + tinternacional.Estado;
                    labelDescuentos.Text = "Descuentos: " + tinternacional.Descuentos.ToString();
                    labelPais.Text = "Pais: " + tinternacional.Pais;
                    labelRubro.Text = "Rubro: " + tinternacional.Rubro;
                    labelVencimiento.Text = "Vencimiento: " + tinternacional.FechaVencimiento.ToString();
                    labelSaldo.Text = "Saldo: " + tinternacional.Saldo.ToString();
                }
                else if (cliente.TarjetaAsociada == tnacional)
                {
                    if (tnacional.FechaVencimiento < DateTime.Now)
                    {
                        tnacional.Estado = "Vencida";
                    }
                    labelPais.Text = string.Empty;
                    labelEstado.Text = "Estado: " + tnacional.Estado;
                    labelDescuentos.Text = "Descuentos: " + tnacional.Descuentos.ToString();
                    labelProvincia.Text = "Provincia: " + tnacional.Provincia;
                    labelRubro.Text = "Rubro: " + tnacional.Rubro;
                    labelVencimiento.Text = "Vencimiento: " + tnacional.FechaVencimiento.ToString();
                    labelSaldo.Text = "Saldo: " + tnacional.Saldo.ToString();
                }
            }
        }

   

        private bool VerificarSaldoSuficiente(Cliente cliente)
        {
            return (cliente.TarjetaAsociada.Saldo > Convert.ToInt32(textBoxImporte.Text));
              
        }



        //Hice lo que pude, me hice ensalada y no creo llegar a trabajar como usted quería con la propiedad.
        private void buttonCompra_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null && textBoxImporte.Text != string.Empty)
            {
                Cliente cliente = (Cliente)listBoxClientes.SelectedItem;
                if (!VerificarSaldoSuficiente(cliente))
                {
                    MessageBox.Show("Saldo insuficiente");
                    cliente.TarjetaAsociada.Estado = "Sin saldo";
                }
                else
                {
                    double precio = Convert.ToInt32(textBoxImporte.Text);
                    if (comboBoxCompra.SelectedItem.Equals("Nacional"))
                    {
                        if (comboBoxCompraRubro.Text != "Libre")
                        {
                            if (comboBoxCompraRubro.Text == cliente.TarjetaAsociada.Rubro)
                            {
                                double descuento = cliente.TarjetaAsociada.DescuentoCalculado(precio);
                                cliente.TarjetaAsociada.Saldo -= precio - descuento;
                                cliente.TarjetaAsociada.Descuentos += descuento;
                            }
                            else
                            {
                                MessageBox.Show("Rubro incorrecto");
                            }

                        }
                        else
                        {
                            double descuento = cliente.TarjetaAsociada.DescuentoCalculado(precio);
                            cliente.TarjetaAsociada.Saldo -= precio - descuento;
                            cliente.TarjetaAsociada.Descuentos += descuento;
                        }

                    }
                    else if (comboBoxCompra.SelectedItem.Equals("Internacional"))
                    {
                        if (comboBoxCompraRubro.Text != "Libre")
                        {
                            if (comboBoxCompraRubro.Text == cliente.TarjetaAsociada.Rubro)
                            {
                                double descuento = cliente.TarjetaAsociada.DescuentoCalculado(precio);
                                cliente.TarjetaAsociada.Saldo -= precio - descuento;
                                cliente.TarjetaAsociada.Descuentos += descuento;
                            }
                            else
                            {
                                MessageBox.Show("Rubro incorrecto");
                            }

                        }
                        else
                        {
                            double descuento = cliente.TarjetaAsociada.DescuentoCalculado(precio);
                            cliente.TarjetaAsociada.Saldo -= precio - descuento;
                            cliente.TarjetaAsociada.Descuentos += descuento;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar cliente y completar el importe");
            }
        }
    }
}