using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tonattto_POO_2P.Clases;
using Tonattto_POO_2P.ClasesVista;

namespace Tonattto_POO_2P
{
    public partial class Form1 : Form
    {
        #region Campos
        CEmpresa _cEmpresa = new CEmpresa();
        CPrestamoDolares _prestamoDolares = new CPrestamoDolares();
        CPrestamoPesos _prestamoPesos = new CPrestamoPesos();
        CVistaPrestamosNoPagadosCliente _pNoPagadosClientes = new CVistaPrestamosNoPagadosCliente();
        CVistaPrestamosVencidosCliente _pVencidosCliente = new CVistaPrestamosVencidosCliente();
        CVistaPrestamosPagadosCliente _pPagadosCliente = new CVistaPrestamosPagadosCliente();
        CVistaPrestamosNoPagados _prestamosNoPagados = new CVistaPrestamosNoPagados();
        CVistaPrestamosPagados _prestamosPagados = new CVistaPrestamosPagados();
        CVistaPrestamo _vistaPrestamos = new CVistaPrestamo();
        CVistaPrestamosVencidos _VprestamosVencidos = new CVistaPrestamosVencidos();
        #endregion

        public Form1()
        {
            InitializeComponent();
            _cEmpresa.PrestamoVencido += _cEmpresa_PrestamoVencido;
        }

        private void _cEmpresa_PrestamoVencido(List<CPrestamo> pListaPrestamo)
        {
            //Evento que crea un objeto del formulario 2 y le pasa los prestamos vencidos
            Form2 frm2 = new Form2();
            frm2.grdPrestamosVencidos.DataSource = _VprestamosVencidos.ListaPrestamosVencidos(pListaPrestamo);
            frm2.ShowDialog();
        }

        #region Funciones privadas de servicio
        private void Mostrar(DataGridView pDGV, object pQueMuestro)
        {
            //Este metodo permite mostrar la informacion en las grillas.
            //Limpia la grilla y luego le carga el objeto que llega en su parametro
            pDGV.DataSource = null; pDGV.DataSource = pQueMuestro;
        }

        public void ConfigurarGrilla(List<DataGridView> _pLDGV)
        {
            //Metodo que configura las grillas
            foreach (DataGridView _dataGridView in _pLDGV)
            {
                _dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                _dataGridView.MultiSelect = false;
                _dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                _dataGridView.EnableHeadersVisualStyles = false;
                _dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
                _dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                _dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
                _dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
                _dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                _dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public void IngresarDatos(CPrestamo pPrestamo)
        {
            //ingresa los daots de prestamo
            pPrestamo.Capital = Convert.ToDecimal(Interaction.InputBox("Capital: ", ""));
            pPrestamo.FechaAdjudicacion = Convert.ToDateTime(Interaction.InputBox("Fecha de adjudicacion", ""));
            pPrestamo.FechaDevolucion = Convert.ToDateTime("1/1");
            pPrestamo.Plazo = Convert.ToInt32(Interaction.InputBox("Plazo: ", ""));
            pPrestamo.TasaInteres = Convert.ToDecimal(Interaction.InputBox("Tasa de interes: ", ""));
        }

        public void IngresarNombreApellido(CCliente pCliente)
        {
            //Metodo que permite ingresar el nomnre y apellido del cliente
            pCliente.Nombre = Interaction.InputBox("Nombre: ", "");
            pCliente.Apellido = Interaction.InputBox("Apellido: ", "");
        }

        public void ActualizarGrillasClientes(CCliente pCliente)
        {
            try
            {
                //Actualiza la grilla de prestamos pagados, no pagados y vencidos del cliente seleccionado
                Mostrar(grdPrestamosNoPagadosCliente, _pNoPagadosClientes.PrestamosPagadosCliente(pCliente.RetornaPrestamosNoPagados()));
                Mostrar(grdPrestamosVencidosCliente, _pVencidosCliente.PrestamosVencidosCliente(pCliente.RetornaPrestamosVencidos()));
                Mostrar(grdPrestamosPagadosCliente, _pPagadosCliente.PrestamosPagadosCliente(pCliente.RetornaPrestamosPagados()));
            }
            catch { }
        }

        public void ActualizarGrillas()
        {
            try
            {
                //Crea un clon de la clase empresa y actualiza las grillas 2, 3 y 4
                CEmpresa _empresaClon = (CEmpresa)_cEmpresa.Clone();
                Mostrar(grdPrestamos, _vistaPrestamos.ListaPrestamos(_empresaClon.ListaPrestamos()));
                Mostrar(grdPrestamosNoPagados, _prestamosNoPagados.PrestamosNoPagados(_empresaClon.ListaPrestamosNoPagados()));
                Mostrar(grdPrestamosPagados, _prestamosPagados.RetornaPrestamosPagados(_empresaClon.ListaPrestamosPagados()));
            }
            catch (Exception) { }
        }

        private void ModificarDatosPrestamo(CPrestamo pPrestamo)
        {
            //Metodo para modificar los datos del prestamo
            pPrestamo.Capital = Convert.ToDecimal(Interaction.InputBox("Capital: ", "", Convert.ToString(pPrestamo.Capital)));
            pPrestamo.FechaAdjudicacion = Convert.ToDateTime(Interaction.InputBox("Fecha adjudicacion: ", "", Convert.ToString(pPrestamo.FechaAdjudicacion)));
            pPrestamo.Plazo = Convert.ToInt32(Interaction.InputBox("Plazo en meses: ", "", Convert.ToString(pPrestamo.Plazo)));
            pPrestamo.TasaInteres = Convert.ToInt32(Interaction.InputBox("Tasa interes: ", "", Convert.ToString(pPrestamo.TasaInteres)));
            //Con los datos ya modificados llama los siguientes metodos para calcular interes, seguros, etc. otra vez
            pPrestamo.CalcularPlazo(pPrestamo);
            pPrestamo.GastoAdministrativo(pPrestamo);
            pPrestamo.SeguroObligatorio(pPrestamo);
            pPrestamo.CalcularInteres(pPrestamo);
            pPrestamo.CalcularTotal(pPrestamo);
            MessageBox.Show("Prestamo modificado correctamente", "POO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Clientes
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Crea un objeto de cliente nuevo y completa su DNI
                CCliente _auxCliente = new CCliente(Interaction.InputBox("Documento: ", ""), "", "");
                //Pregunta si existe un cliente con ese DNI
                if (!_cEmpresa.ClienteExiste(_auxCliente) == true)
                {
                    this.IngresarNombreApellido(_auxCliente);
                    //Agrega el cliente y lo muestra en su respectiva grilla
                    _cEmpresa.AgregarCliente(_auxCliente);
                    Mostrar(grdClientes, _cEmpresa.ListaClientes());
                }
                else { MessageBox.Show("Ya existe un cliente con el documento seleccionado", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdClientes.Rows.Count > 0)
                {
                    //Carga el objeto de cliente ya creado y lo elimina
                    //Elimina sus prestamos si es que posee
                    CCliente _auxCliente = (CCliente)grdClientes.SelectedRows[0].DataBoundItem;
                    _cEmpresa.EliminarCliente(_auxCliente);
                    _auxCliente.EliminarTitular();
                    _auxCliente.EliminaPrestamosCliente();
                    //Actualiza las grillas
                    Mostrar(grdClientes, _cEmpresa.ListaClientes());
                    this.ActualizarGrillasClientes(_auxCliente);
                }
                else { }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdClientes.Rows.Count > 0)
                {
                    //Selecciona un cliente, y se modifica
                    CCliente _auxCliente = (CCliente)grdClientes.SelectedRows[0].DataBoundItem;
                    _auxCliente.Nombre = Interaction.InputBox("Nombre: ", "", _auxCliente.Nombre);
                    _auxCliente.Apellido = Interaction.InputBox("Apellido: ", "", _auxCliente.Apellido);
                    MessageBox.Show("Cliente modificado exitosamente", "POO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Mostrar(grdClientes, _cEmpresa.ListaClientes());
                }
                else { MessageBox.Show("No hay clientes para modificar", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion

        #region Prestamo
        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                //Pregunta si el cliente quiere un prestamo en dolares o pesos
                string num = (Interaction.InputBox("1- Dolares   2- Pesos", ""));
                if (num == "1")
                {
                    CPrestamoDolares _auxPrestamosDolares = new CPrestamoDolares(Interaction.InputBox("Identificador", ""), Convert.ToDecimal(0), Convert.ToDateTime("1/1"), Convert.ToInt32(0), Convert.ToDecimal(0), Convert.ToDecimal(0), false, false);
                    //Verifica que el identificador sea correcto
                    if (_cEmpresa.VerificarIdentificador(_auxPrestamosDolares) == true)
                    {
                        //verifica que el identificador no exista
                        if (!_cEmpresa.PrestamoExiste(_auxPrestamosDolares) == true)
                        {
                            //Carga los datos del prestamo, calcula, y lo agrega
                            this.IngresarDatos(_auxPrestamosDolares);
                            _prestamoDolares.CalcularPlazo(_auxPrestamosDolares);
                            _prestamoDolares.GastoAdministrativo(_auxPrestamosDolares);
                            _prestamoDolares.SeguroObligatorio(_auxPrestamosDolares);
                            _prestamoDolares.CalcularInteres(_auxPrestamosDolares);
                            _prestamoDolares.CalcularTotal(_auxPrestamosDolares);
                            _cEmpresa.AgregarPrestamo(_auxPrestamosDolares);
                            this.ActualizarGrillas();
                        }
                        else { MessageBox.Show("Ya existe un prestamo con el identificador seleccionado", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("El identificador ingresado no cumple con las normas", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else if (num == "2")
                {
                    CPrestamoPesos _auxPrestamosPesos = new CPrestamoPesos(Interaction.InputBox("Identificador", ""), Convert.ToDecimal(0), Convert.ToDateTime("1/1"), Convert.ToInt32(0), Convert.ToDecimal(0), Convert.ToDecimal(0), false, false);
                    if (_cEmpresa.VerificarIdentificador(_auxPrestamosPesos) == true)
                    {
                        if (!_cEmpresa.PrestamoExiste(_auxPrestamosPesos) == true)
                        {
                            this.IngresarDatos(_auxPrestamosPesos);
                            _prestamoPesos.CalcularPlazo(_auxPrestamosPesos);
                            _prestamoPesos.GastoAdministrativo(_auxPrestamosPesos);
                            _prestamoPesos.SeguroObligatorio(_auxPrestamosPesos);
                            _prestamoPesos.CalcularInteres(_auxPrestamosPesos);
                            _prestamoPesos.CalcularTotal(_auxPrestamosPesos);
                            _cEmpresa.AgregarPrestamo(_auxPrestamosPesos);
                            this.ActualizarGrillas();
                        }
                        else { MessageBox.Show("Ya existe un prestamo con el identificador seleccionado", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("El identificador ingresado no cumple con las normas", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Numero ingresado no es correcto", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdPrestamos.Rows.Count > 0)
                {
                    //Crea un obejeto vista, y a partir de el, trae el objeto original
                    CVistaPrestamo _auxVistaPrestamo = (CVistaPrestamo)grdPrestamos.SelectedRows[0].DataBoundItem;
                    CPrestamo _auxPrestamo = (CPrestamo)_cEmpresa.RetornaPrestamo(_auxVistaPrestamo);
                    //Elimina el objeto original
                    _cEmpresa.EliminarPrestamo(_auxPrestamo);
                    if (_auxPrestamo.RetornaTitular() == null) { }
                    else
                    {
                        CCliente _auxCliente = (CCliente)_auxPrestamo.RetornaTitular();
                        _auxCliente.EliminaPrestamosCliente();
                        //Actualiza la grilla de clientes
                        this.ActualizarGrillasClientes(_auxCliente);
                    }
                    //Actualiza las demas grillas
                    this.ActualizarGrillas();
                    MessageBox.Show("Prestamo eliminado correctamente", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { MessageBox.Show("No hay prestamos para eliminar", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                //pregunta si hay prestamos para seleccionar
                if (grdPrestamos.Rows.Count > 0)
                {
                    //Crea un objeto vista y trae el objeto original
                    CVistaPrestamo _vistaPrestamo = (CVistaPrestamo)grdPrestamos.SelectedRows[0].DataBoundItem;
                    CPrestamo _auxPrestamo = (CPrestamo)_cEmpresa.RetornaPrestamo(_vistaPrestamo);
                    //Modifica el objeto y actualiza las grillas
                    this.ModificarDatosPrestamo(_auxPrestamo);
                    this.ActualizarGrillas();
                }
                else { MessageBox.Show("No hay prestamos para seleccionar", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Boton Asignar y Pagar
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdClientes.Rows.Count > 0)
                {
                    //Llama un objeto cliente con el cliente seleccionado
                    CCliente _auxCliente = (CCliente)grdClientes.SelectedRows[0].DataBoundItem;
                    if (grdPrestamos.Rows.Count > 0)
                    {
                        CVistaPrestamo _auxVistaPrestamo = (CVistaPrestamo)grdPrestamos.SelectedRows[0].DataBoundItem;
                        CPrestamo _auxPrestamo = (CPrestamo)_cEmpresa.RetornaPrestamo(_auxVistaPrestamo);
                        if (_auxPrestamo.Vencido == false)
                        {
                            //Pregunta si tiene titular
                            if (_auxPrestamo.RetornaTitular() == null)
                            {
                                //Si no tiene titular permite asignar el cliente seleccionado como titular del prestamo
                                _auxCliente.AsignarPrestamo(_auxPrestamo);
                                _auxPrestamo.AsignarTitular(_auxCliente);
                                MessageBox.Show("Prestamo " + _auxPrestamo.Identificador + " asignado a " + _auxCliente.Nombre + " " + _auxCliente.Apellido + " correctamente", "POO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Actualiza las grillas
                                this.ActualizarGrillasClientes(_auxCliente);
                                this.ActualizarGrillas();
                            }
                            else { MessageBox.Show("El prestamo " + _auxPrestamo.Identificador + " ya esta asignado", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        else { MessageBox.Show("El prestamo " + _auxPrestamo.Identificador + " esta vencido, no se le puede asignar un titular"); }
                    }
                    else { MessageBox.Show("No hay prestamos para seleccionar", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("No hay clientes para seleccionar", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdPrestamos.Rows.Count > 0)
                {
                    CVistaPrestamo _auxVistaPrestamo = (CVistaPrestamo)grdPrestamos.SelectedRows[0].DataBoundItem;
                    CPrestamo _auxPrestamo = (CPrestamo)_cEmpresa.RetornaPrestamo(_auxVistaPrestamo);
                    //Pregunta si esta vencido, si no lo esta y tiene un titular permite realizar el pago del prestamo
                    if (_auxPrestamo.Vencido == false)
                    {
                        if (_auxPrestamo.RetornaTitular() == null) { MessageBox.Show("El prestamo no se puede pagar porque no tiene un titular", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        else
                        {
                            if (_auxPrestamo.Pagado == true) { MessageBox.Show("El prestamo ya se pago", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            else
                            {
                                CCliente _auxCliente = (CCliente)_auxPrestamo.RetornaTitular();
                                _auxPrestamo.Pagado = true;
                                //Actualiza las grillas
                                this.ActualizarGrillasClientes(_auxCliente);
                                this.ActualizarGrillas();
                                MessageBox.Show("El prestamo " + _auxPrestamo.Identificador + " se pagó exitosamente", "POO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else { MessageBox.Show("El prestamo esta vencido, no se puede pagar", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("No hay prestamos para pagar"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion

        private void txtFecha_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //Pregunta si la fecha presionada es un enter
                if ((int)e.KeyValue == (int)Keys.Enter)
                {
                    //Verifica que el texto ingresado tenga formato fecha
                    if (Regex.IsMatch(txtFecha.Text, @"\A[0-9]{2}[/]{1}[0-9]{2}[/]{1}[0-9]{4}\Z"))
                    {
                        //Ejecuta el metodo para verificar que prestamos vencen y cuales vuelven a la normalidad
                        _cEmpresa.PrestamoVence(Convert.ToDateTime(txtFecha.Text));
                        _cEmpresa.PrestamoDesvence(Convert.ToDateTime(txtFecha.Text));
                        this.ActualizarGrillas();
                        if (grdClientes.Rows.Count > 0)
                        {
                            CCliente _auxCliente = (CCliente)grdClientes.SelectedRows[0].DataBoundItem;
                            this.ActualizarGrillasClientes(_auxCliente);
                        }
                    }
                    else { MessageBox.Show("El texto ingresado no es una fecha valida"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void grdClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdClientes.Rows.Count > 0)
                {
                    //Se presiona la celda, sea llama al objeto cliente del que se selecciono en la grilla y actualiza las
                    //grillas de cliente
                    CCliente _auxCliente = (CCliente)grdClientes.SelectedRows[0].DataBoundItem;
                    this.ActualizarGrillasClientes(_auxCliente);
                }
                else { MessageBox.Show("No hay clientes para seleccionar", "POO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Pasa al metodo configurar grillas, todas las grillas para que sean configuradas
            ConfigurarGrilla(new List<DataGridView>() { grdClientes, grdPrestamos, grdPrestamosNoPagadosCliente, grdPrestamosPagadosCliente, grdPrestamosVencidosCliente, grdPrestamosNoPagados, grdPrestamosPagados });
        }
    }
}
