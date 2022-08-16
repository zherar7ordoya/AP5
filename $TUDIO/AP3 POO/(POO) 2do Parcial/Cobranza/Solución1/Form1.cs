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

namespace SegundoParcialUrbainskyAlexis
{
    public partial class Form1 : Form
    {
        #region Atributos
        Empresa empresa;
        #endregion

        #region Form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empresa = new Empresa();


            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView3.MultiSelect = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView4.MultiSelect = false;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView5.MultiSelect = false;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        #region ABMClientes
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente auxCliente = new Cliente();

                string legajoInput = Interaction.InputBox("Ingrese Legajo: ");
                validarInputVacios(legajoInput, "Legajo");

                if (legajoInput.Length <= 6)
                {
                    auxCliente.Legajo = legajoInput;
                    if (empresa.ValidarExistenciaCliente(auxCliente))
                    {
                        throw new Exception("Error, Ya existe otro Cliente con el mismo Legajo");
                    }
                } else {
                    throw new Exception("Error, el legajo no puede superar los 6 caracteres");
                }

                string nombre = Interaction.InputBox("Ingrese Nombre: ");
                validarInputVacios(nombre, "Nombre");
                auxCliente.Nombre = nombre;


                empresa.AltaCliente(auxCliente);
               
                Mostrar(dataGridView1, empresa.DevuelveListaClientesClon());
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0) {

                    Cliente auxCliente = empresa.RetornaCliente(DevuelveClienteSeleccionado());
                    if (auxCliente._ListaCobros == null || auxCliente._ListaCobros.Count == 0)
                    {
                        empresa.BajaCliente(auxCliente);
                        Mostrar(dataGridView1, empresa.DevuelveListaClientesClon());
                    } else {
                        throw new Exception("Error, El cliente no puede darse de baja porque tiene Cobros ");
                    }
                }
                else {
                    throw new Exception("Error, La grilla de clientes esta vacia ");
                }


            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    Cliente auxCliente = empresa.RetornaCliente(DevuelveClienteSeleccionado());

                    string nombre = Interaction.InputBox("Ingrese Nombre: ");
                    validarInputVacios(nombre, "Nombre");
                    auxCliente.Nombre = nombre;

                    empresa.ModificarCliente(auxCliente);

                    Mostrar(dataGridView1, empresa.DevuelveListaClientesClon());
                } else {
                    throw new Exception("Error, La grilla de clientes esta vacia ");
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0 && dataGridView2.Rows.Count > 0)
                {
                    Cobro auxCobro = empresa.RetornaCobro(DevuelveCobroSeleccionado());
                    Cliente auxCliente = DevuelveClienteSeleccionado();
                    

                    if (!auxCobro.EsCancelado()) {

                        if (auxCobro.DevuelveCliente().Legajo == auxCliente.Legajo)
                        {
                            decimal recargo = auxCobro.CalcularAdicionales();
                            decimal totalAbonar = auxCobro.Importe + recargo;

                            if (totalAbonar >= 10000) {
                                auxCobro.ImporteElevado += ImporteElevadoEventArgs;
                                ImporteElevadoEventArgs(this, new ImporteElevadoEventArgs(totalAbonar));
                            }

                            MessageBox.Show("El importe a pagar sera de Importe : $" + auxCobro.Importe + " Recargo: $" + recargo + " siendo un total de: $" + (auxCobro.Importe + recargo));

                            empresa.PagarCobro(auxCobro);
                            MostrarListaCobrosCancelados();
                            MostrarListaCobrosCanceladosDelCliente();
                        } else {
                            throw new Exception("Error, El Cobro seleccionado no puede pagarse, pertenece a otro cliente, Nombre: " + auxCobro.DevuelveCliente().Nombre + " Legajo: " + auxCobro.DevuelveCliente().Legajo);
                        }
                    }else {
                        throw new Exception("Error, el cobro ya se encuentra cancelado ");
                    }
                } else {
                    throw new Exception("Error, La grilla de clientes y/o de Cobros estan vacias ");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private Cliente DevuelveClienteSeleccionado()
        {
            return dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
        }

        private Cobro DevuelveCobroSeleccionado()
        {
            return dataGridView2.SelectedRows[0].DataBoundItem as Cobro;
        }

        #endregion

        #region ABMCobros

        private void btnAltaCobro_Click(object sender, EventArgs e)
        {
            try
            {
                Cobro auxCobro = null;

                if (dataGridView1.Rows.Count > 0)
                {

                    Cliente auxCliente = DevuelveClienteSeleccionado();

                    if (!empresa.PagosPendientesMayorAlLimite(auxCliente))
                    {

                        string tipoCobroInput = Interaction.InputBox("Ingrese Tipo de Cobro, 1 Normal, 2 Especial ");
                        int tipo = 0;

                        if (Information.IsNumeric(tipoCobroInput))
                        {
                            tipo = int.Parse(tipoCobroInput);

                            if (tipo != 0 && tipo <= 2)
                            {

                                switch (tipo)
                                {
                                    case 1:
                                        auxCobro = new Normal();
                                        break;

                                    case 2:
                                        auxCobro = new Especial();
                                        break;
                                }

                                string codigo = Interaction.InputBox("Ingrese Codigo: ");
                                validarInputVacios(codigo, "Codigo");

                                if (codigo.Length <= 6)
                                {
                                    auxCobro.Código = Int32.Parse(codigo);

                                    if (empresa.ValidarExistenciaCobro(auxCobro))
                                    {
                                        throw new Exception("Error, Ya existe otro Cobro con el mismo codigo");
                                    }
                                } else {
                                    throw new Exception("Error, el codigo no puede superar los 6 caracteres");
                                }


                                string nombre = Interaction.InputBox("Ingrese Nombre: ");
                                validarInputVacios(nombre, "Nombre");
                                auxCobro.Nombre = nombre;


                                string fechaVencimiento = Interaction.InputBox("Ingrese Fecha de vencimiento: ");
                                validarInputVacios(fechaVencimiento, "Fecha Vencimiento");

                                if (Information.IsDate(fechaVencimiento))
                                {
                                    auxCobro.FechaVencimiento = Convert.ToDateTime(fechaVencimiento);
                                }
                                else
                                {
                                    throw new Exception("Error, el formato de la fecha es invalido, el formato correcto es por ejemplo 09/07/2021");
                                }

                                string importe = Interaction.InputBox("Ingrese Importe: ");
                                validarInputVacios(importe, "Importe");

                                if (Information.IsNumeric(importe))
                                {
                                    auxCobro.Importe = decimal.Parse(importe);
                                }
                                else
                                {
                                    throw new Exception("Error, debe ingresar un importe de tipo numerico ");
                                }


                                if (!empresa.ValidarExistenciaCobro(auxCobro))
                                {
                                    empresa.AltaCobro(auxCobro, auxCliente);
                                }
                                else
                                {
                                    throw new Exception("Error, Ya existe otro Cobro con el mismo Legajo");
                                }

                                Mostrar(dataGridView1, empresa.DevuelveListaClientesClon());
                                Mostrar(dataGridView2, empresa.DevuelveListaCobrosClon());
                                Mostrar(dataGridView4, DevuelveCobrosOrdenadosMenorOMayor(true));
                                radioBtnMenor.Checked = true;
                            }
                            else
                            {
                                throw new Exception("Error, debe ingresar un tipo de Cobro entre 1 y 2 ");
                            }
                        }
                        else
                        {
                            throw new Exception("Error, debe ingresar un tipo de Cobro valido ");
                        }
                    } else {
                        throw new Exception("El Cliente seleccionado tiene pendiente 2 cobros sin pagar, por lo tanto no puede darse de alta un nuevo cobro");
                    }
                }
                else {
                    throw new Exception("Error, No puede darse de alta un cobro si no existen clientes dados de alta");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Metodos

        private IEnumerable<Cobro> DevuelveListaCobrosPagadosPorCliente() {
            var cobros = (from Cobro p in empresa.DevolverListadoCobros()
                          where p.DevuelveCliente().Legajo == DevuelveClienteSeleccionado().Legajo && p.EsCancelado() == true
                          select p
            );

            return cobros.ToList();
        }

        private void MostrarListaCobrosCancelados()
        {

            var CobrosCancelados = (from Cobro p in empresa.DevolverListadoCobros()
                                    where p.EsCancelado() == true
                                    select new
                                    {
                                        NombreCliente = p.DevuelveCliente().Nombre,
                                        ImporteTotalCancelado = p.RetornaTotalImporteCancelado()
                                    });

            dataGridView5.DataSource = CobrosCancelados.ToList();
        }

        private void MostrarListaCobrosCanceladosDelCliente()
        {
            if (dataGridView1.Rows.Count > 0) { 
                var CobrosCancelados = (from Cobro p in empresa.DevolverListadoCobros()
                                        where p.EsCancelado() == true && p.DevuelveCliente().Legajo == DevuelveClienteSeleccionado().Legajo
                                        select new
                                        {
                                            Tipo = p.GetType().Name,
                                            Código = p.Código,
                                            Nombre = p.Nombre,
                                            FechaVencimiento = p.FechaVencimiento,
                                            Importe = p.Importe,
                                            ImporteCancelado = p.RetornaTotalImporteCancelado()
                                        });

                dataGridView3.DataSource = CobrosCancelados.ToList();
            }
        }
        

        private IEnumerable<Cobro> DevuelveCobrosOrdenadosMenorOMayor(bool pEsMenor) {
            
            Cliente auxCliente = empresa.RetornaCliente(DevuelveClienteSeleccionado());
            List<Cobro> cobros = auxCliente._ListaCobros;
           
            if (pEsMenor) {
                cobros.Sort();
            } else {
                cobros.Reverse();
            }
            

            return cobros;
        }
        #endregion

        #region Formulario
        private void validarInputVacios(string input, string campo)
        {
            if (input.Length == 0)
            {
                throw new Exception("el campo " + campo + " no puede ser vacio");
            }
        }

        private void Mostrar(DataGridView Dgv, Object pO)
        {
            Dgv.DataSource = null;
            Dgv.DataSource = pO;
        }

        #endregion

        #region Eventos

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Mostrar(dataGridView3, DevuelveListaCobrosPagadosPorCliente());
                Mostrar(dataGridView4, DevuelveCobrosOrdenadosMenorOMayor(true));
                MostrarListaCobrosCancelados();
                MostrarListaCobrosCanceladosDelCliente();
                radioBtnMenor.Checked = true;

            } catch (Exception) {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImporteElevadoEventArgs(object sender, ImporteElevadoEventArgs e)
        {
            try
            {
                MessageBox.Show($"El cobro supera el monto de los $10.000, Total a Cobrar: $ {e.ImporteTotal}");
            } catch (Exception) {

            }
        }

        private void radioBtnMenor_Click(object sender, EventArgs e)
        {

            Mostrar(dataGridView4, DevuelveCobrosOrdenadosMenorOMayor(true));
        }

        private void radioBtnMayor_Click(object sender, EventArgs e)
        {
            Mostrar(dataGridView4, DevuelveCobrosOrdenadosMenorOMayor(false));
        }

        #endregion

    }
}
