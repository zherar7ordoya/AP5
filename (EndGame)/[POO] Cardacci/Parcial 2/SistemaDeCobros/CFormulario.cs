using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemaDeCobros
{
    public partial class CFormulario : Form
    {
        /////////////////////////////////////////////////////////////// SPUTNIK
        List<CCliente> clientes = new List<CCliente>();                     ///
        CCliente cliente = null;                                            ///
        CCobro cobro = null;                                                ///
        CPago pago = null;                                                  ///
        List<CPago> clonada = new List<CPago>();                            ///
        List<CPago> ordenable = new List<CPago>();                          ///
        List<CReducida> reducida = new List<CReducida>();                   ///
        string usuario = string.Empty;                                      ///
        ///////////////////////////////////////////////////////////////////////

        #region FORMULARIO
        // *--------------------------------------------------------=> Apertura
        public CFormulario() { InitializeComponent(); }
        private void DefineUsuario()
        {
            while (true)
            {
                if (!string.IsNullOrWhiteSpace(usuario)) { break; }
                usuario = Interaction.InputBox
                    (
                    "Ingrese su nombre:",
                    "Usuario",
                    "Gerardo Tordoya"
                    );
                if (string.IsNullOrWhiteSpace(usuario)) { Close(); }
            }
        }
        private void PersonalizaFormulario()
        {
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text += $" ({usuario})";
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private void CargaDemo()
        {
            if (MessageBox.Show
                    (
                    "¿Desea cargar Demo?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
            {
                cliente = new CCliente(100, "Cliente #1");
                cobro = new CCobroEspecial("Cliente #1", "Especial", 875, "UNO", new DateTime(2014, 10, 25), 1250);
                cliente.AltaPendiente(cobro);
                cobro = new CCobroNormal("Cliente #1", "Normal", 325, "DOS", new DateTime(2021, 8, 26), 7000);
                cliente.AltaPendiente(cobro);
                pago = new CPago("Cliente #1", "Especial", 275, "SPC", new DateTime(2020, 11, 22), 1000, 8300, 9300);
                cliente.AltaCancelado(pago);
                pago = new CPago("Cliente #1", "Normal", 280, "TPC", new DateTime(2020, 10, 21), 1000, 3970, 4970);
                cliente.AltaCancelado(pago);
                pago = new CPago("Cliente #1", "Normal", 285, "UPC", new DateTime(2020, 9, 20), 1000, 4280, 5280);
                cliente.AltaCancelado(pago);
                pago = new CPago("Cliente #1", "Especial", 290, "VPC", new DateTime(2020, 8, 19), 1000, 10200, 11200);
                cliente.AltaCancelado(pago);
                clientes.Add(cliente);

                clonada = cliente.VerCancelados().ToList();
                ordenable = cliente.VerCancelados();
                reducida = cliente.VerCancelados().Select(x => new CReducida()
                { Nombre = x.Cliente, Total = x.Total }).ToList();

                DgvListaClientes.DataSource = clientes;
                DgvListaPendientes.DataSource = cliente.VerPendientes();
                DgvListaCanceladosG3.DataSource = clonada;
                DgvListaCanceladosG4.DataSource = ordenable;
                DgvListaCanceladosG5.DataSource = reducida;

                CmdAltaCliente.Enabled = false;
                CmdModificaCliente.Enabled = true;
                CmdBajaCliente.Enabled = true;
                TextboxLegajoCliente.Enabled = false;
                DgvListaClientes.Rows[0].Selected = true;
                RadioAscendente.Enabled = true;
                RadioDescendente.Enabled = true;

                LabelInformacion.Text = "Modo Demo.\n\nExplore, pero le sugerimos que primero se familiarice con la carga.";
            }
        }
        private void IniciaFormulario()
        {
            DefineUsuario();
            PersonalizaFormulario();
            CargaDemo();
        }
        private void CFormulario_Load(object sender, EventArgs e)
        {
            IniciaFormulario();
            if (string.IsNullOrEmpty(LabelInformacion.Text))
            {
                LabelInformacion.Text = "Inicie dando un cliente de alta.\n";
                LabelInformacion.Text += "Click en cabecera de fila para seleccionarlo.\n";
                LabelInformacion.Text += "Click en una celda para habilitar nuevas altas.";
            }
            SimulaPlaceholder();
            TextboxLegajoCliente.Focus();
        }
        // *--------------------------------------------------------=> Vigencia
        public void TboxAdquiereFoco(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            TextBox tbox = (TextBox)sender;
        }

        public void TboxPierdeFoco(object sender, EventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tbox.Text))
            { tbox.Text = tbox.Tag.ToString(); }
        }

        private void SimulaPlaceholder()
        {
            foreach (Control x in Controls)
            {
                if (x is GroupBox)
                {
                    foreach (Control box in x.Controls)
                    {
                        if (box is TextBox)
                        {
                            box.GotFocus += new EventHandler(TboxAdquiereFoco);
                            box.LostFocus += new EventHandler(TboxPierdeFoco);
                        }
                    }
                }
            }
        }

        // *--------------------------------------------------------=> Descarga
        private void CFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show
                    (
                    "¿Desea salir de la aplicación?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.No)
                { e.Cancel = true; }
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region BACKGROUND WORLD
        private void InformaExcepcion(Control pControl, string pMensaje)
        {
            ErrorProvider.SetError
                (
                pControl,
                pMensaje
                );

            MessageBox.Show
                (
                pMensaje,
                "Algo ha fallado...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
        private void Pago_OnTotalChanged(object sender, decimal e)
        {
            try
            {
                var x = (CPago)sender;
                if (x.Total > 10000)
                {
                    MessageBox.Show
                    (
                    "El importe total a pagar supera los $10.000",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    LabelInformacion.Text = "El importe pagado superó los $10.000";
                }
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }
        #endregion

        #region EVENTOS
        // *---------------------------------------------------------=> Grupo 1
        private void DgvListaClientes_RowHeaderMouseClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            ErrorProvider.Clear();
            EtiquetaClientes.Text = string.Empty;
            EtiquetaPendientes.Text = string.Empty;
            LabelInformacion.Text = string.Empty;
            try
            {
                cliente = (CCliente)
                    (DgvListaClientes.SelectedRows[0].DataBoundItem);

                TextboxLegajoCliente.Text = DgvListaClientes
                    .Rows[e.RowIndex].Cells[0].Value.ToString();
                TextboxNombreCliente.Text = DgvListaClientes
                    .Rows[e.RowIndex].Cells[1].Value.ToString();

                // En G1
                TextboxLegajoCliente.Enabled = false;
                CmdAltaCliente.Enabled = false;
                CmdModificaCliente.Enabled = true;
                CmdBajaCliente.Enabled = true;

                // En G2
                CheckTipoEspecial.Enabled = true;
                TextboxCodigoCobro.Enabled = true;
                TextboxNombreCobro.Enabled = true;
                DpickerFVencimiento.Enabled = true;
                TextboxImporte.Enabled = true;
                CmdAltaCobro.Enabled = true;
                CmdPagar.Enabled = false;
                DgvListaPendientes.DataSource = null;

                if (cliente.VerPendientes() != null && cliente.VerPendientes().Count > 0)
                { DgvListaPendientes.DataSource = cliente.VerPendientes(); }
                LabelInformacion.Text = "Seleccionado el cliente, puede ";
                LabelInformacion.Text += "modificarlo o agregar un cobro.";

                // En G3
                // En G4
                // En G5
                if (cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    clonada = cliente.VerCancelados().ToList();
                    ordenable = cliente.VerCancelados();
                    reducida = cliente.VerCancelados().Select(x => new CReducida()
                    {
                        Nombre = x.Cliente,
                        Total = x.Total
                    }).ToList();
                    DgvListaCanceladosG3.DataSource = null;
                    DgvListaCanceladosG4.DataSource = null;
                    DgvListaCanceladosG5.DataSource = null;

                    DgvListaCanceladosG3.DataSource = clonada;
                    DgvListaCanceladosG4.DataSource = ordenable;
                    DgvListaCanceladosG5.DataSource = reducida;

                    RadioAscendente.Enabled = true;
                    RadioDescendente.Enabled = true;
                    RadioAscendente.Checked = false;
                    RadioDescendente.Checked = false;
                }
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }

        private void DgvListaClientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            ErrorProvider.Clear();
            EtiquetaClientes.Text = string.Empty;
            EtiquetaPendientes.Text = string.Empty;
            LabelInformacion.Text = string.Empty;
            try
            {
                if (DgvListaClientes.SelectedRows.Count > 0)
                {
                    cliente = (CCliente)DgvListaClientes.SelectedRows[0].DataBoundItem;
                    if (cliente.VerPendientes().Count > 0)
                    { DgvListaPendientes.DataSource = cliente.VerPendientes(); }
                }

                // En G1
                DgvListaPendientes.DataSource = null;
                TextboxLegajoCliente.Text = string.Empty;
                TextboxNombreCliente.Text = string.Empty;
                TextboxLegajoCliente.Enabled = true;
                CmdAltaCliente.Enabled = true;
                CmdModificaCliente.Enabled = false;
                CmdBajaCliente.Enabled = false;
                EtiquetaClientes.Text = "Para legajo, le sugerimos un entero positivo";

                // En G2
                LabelInformacion.Text = string.Empty;
                CmdAltaCobro.Enabled = true;
                CmdPagar.Enabled = false;
                DgvListaPendientes.DataSource = null;
                LabelInformacion.Text = "Deseleccionado el cliente, puede ";
                LabelInformacion.Text += "agregar otro cliente.";

                // En G3
                DgvListaCanceladosG3.DataSource = null;

                // En G4
                DgvListaCanceladosG4.DataSource = null;
                RadioAscendente.Enabled = false;
                RadioAscendente.Checked = false;
                RadioDescendente.Enabled = false;
                RadioDescendente.Checked = false;

                // En G5
                DgvListaCanceladosG5.DataSource = null;
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }

        // *---------------------------------------------------------=> Grupo 2
        private void DgvListaPendientes_RowHeaderMouseClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            ErrorProvider.Clear();
            EtiquetaClientes.Text = string.Empty;
            EtiquetaPendientes.Text = string.Empty;
            LabelInformacion.Text = string.Empty;
            try
            {
                // Verificación
                cliente = (CCliente)
                    (DgvListaClientes.SelectedRows[0].DataBoundItem);
                cobro = (CCobro)
                    (DgvListaPendientes.SelectedRows[0].DataBoundItem);

                // En G1
                // En G2
                if (cobro.Tipo == "Especial") { CheckTipoEspecial.Checked = true; }
                TextboxCodigoCobro.Text = cobro.Codigo.ToString();
                TextboxNombreCobro.Text = cobro.NombreCobro;
                DpickerFVencimiento.Value = cobro.FechaVencimiento;
                TextboxImporte.Text = cobro.Importe.ToString();
                CmdAltaCobro.Enabled = false;
                CmdPagar.Enabled = true;
                LabelInformacion.Text = "Seleccionado cliente y cobro, ";
                LabelInformacion.Text += "puede proceder al pago del mismo.";

                // En G3
                // En G4
                // En G5
            }
            catch (Exception error)
            {
                InformaExcepcion(
                    EtiquetaClientes,
                    $"¿Tiene seleccionado un cliente?\n(Fila cliente seleccionada)\n\n{error.Message}");
            }
        }

        private void DgvListaPendientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            ErrorProvider.Clear();
            EtiquetaClientes.Text = string.Empty;
            EtiquetaPendientes.Text = string.Empty;
            LabelInformacion.Text = string.Empty;
            try
            {
                // En G1
                // En G2
                CheckTipoEspecial.Checked = false;
                TextboxCodigoCobro.Text = string.Empty;
                TextboxNombreCobro.Text = string.Empty;
                DpickerFVencimiento.Value = DateTime.Today.AddDays(-1);
                TextboxImporte.Text = string.Empty;
                CmdAltaCobro.Enabled = true;
                CmdPagar.Enabled = false;
                LabelInformacion.Text = "Deseleccionado un cliente, puede ";
                LabelInformacion.Text += "proceder al alta de otro cobro.\n";
                LabelInformacion.Text += "Tip: el nombre de cobro es un ayuda-memoria para usted.";
                EtiquetaPendientes.Text = "Para código sugerimos un número entero positivo.\n";

                // En G3
                // En G4
                // En G5
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }

        // *---------------------------------------------------------=> Grupo 4
        private void RadioAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            EtiquetaClientes.Text = string.Empty;
            EtiquetaPendientes.Text = string.Empty;
            LabelInformacion.Text = string.Empty;

            try
            {
                if (cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    List<CPago> ascendente = cliente.VerCancelados().OrderBy(x => x.Total).ToList();
                    DgvListaCanceladosG4.DataSource = null;
                    DgvListaCanceladosG4.DataSource = ascendente;
                }

                // En G1
                // En G2
                LabelInformacion.Text = "Información\n\nLos pagos han sido ordenados de menor a mayor por el total.";

                // En G3
                // En G4
                // En G5

            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }
        private void RadioDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            EtiquetaClientes.Text = string.Empty;
            EtiquetaPendientes.Text = string.Empty;
            LabelInformacion.Text = string.Empty;
            try
            {
                if (cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    List<CPago> descendente = cliente.VerCancelados().OrderByDescending(x => x.Total).ToList();
                    DgvListaCanceladosG4.DataSource = null;
                    DgvListaCanceladosG4.DataSource = descendente;
                }

                // En G1
                // En G2
                LabelInformacion.Text = "Información\n\nLos pagos han sido ordenados de mayor a menor por el total.";

                // En G3
                // En G4
                // En G5
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }
        #endregion

        #region MÉTODOS
        // *---------------------------------------------------------=> Grupo 1
        private void CmdAltaCliente_Click(object sender, EventArgs e)
        {
            EtiquetaClientes.Text = "Los legajos deben ser únicos. ";
            EtiquetaClientes.Text += "Los nombres, convencionales.";
            try
            {
                // Verificaciones
                ErrorProvider.Clear();

                if (
                    TextboxLegajoCliente.Text == string.Empty ||
                    TextboxNombreCliente.Text == string.Empty
                    ) { throw new Exception("No pueden haber campos vacíos"); }
                else if (
                    !Regex.Match(TextboxNombreCliente.Text,
                    "^[A-Z][A-zÀ-ú ]*$").Success
                    )
                {
                    throw new Exception
                        (
                        "Use un nombre propio que empiece con mayúscula.\n" +
                        "\t(Ejemplos: Fulano, Mengano, Zutano...)");
                }
                else if (clientes.Any
                    (x => x.Legajo == int.Parse(TextboxLegajoCliente.Text)))
                { throw new Exception("Los legajos deben ser diferentes."); }

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma Alta de Cliente?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    clientes.Add(new CCliente
                    (
                    int.Parse(TextboxLegajoCliente.Text),
                    TextboxNombreCliente.Text
                    ));
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;

                    // Adendas
                    DgvListaClientes_CellClick(this, null);
                    LabelInformacion.Text = "Alta del Cliente realizada exitosamente.\n";
                    LabelInformacion.Text += "Para asignarle un cobro, haga click en la cabecera de fila.";
                    TextboxLegajoCliente.Focus();
                }
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }

        private void CmdBajaCliente_Click(object sender, EventArgs e)
        {
            EtiquetaClientes.Text = "Los legajos deben ser únicos. ";
            EtiquetaClientes.Text += "Los nombres, convencionales.";
            try
            {
                // Verificaciones
                if (DgvListaClientes.SelectedRows.Count == 0)
                {
                    throw new Exception
                        (
                        "Debe seleccionar un cliente.\n" +
                        "Puede hacerlo con un click en su cabecera de fila."
                        );
                }
                cliente = (CCliente)
                    (DgvListaClientes.SelectedRows[0].DataBoundItem);

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma baja?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    clientes.Remove(cliente);
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;
                }

                // Adendas
                DgvListaClientes_CellClick(this, null);
                LabelInformacion.Text = "Baja del Cliente realizada exitosamente.\n";
                LabelInformacion.Text += "Para asignarle un cobro, haga click en la cabecera de fila.";
                TextboxLegajoCliente.Focus();
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }

        private void CmdModificaCliente_Click(object sender, EventArgs e)
        {
            EtiquetaClientes.Text = "Los legajos deben ser únicos. ";
            EtiquetaClientes.Text += "Los nombres, convencionales.";
            try
            {
                // Verificaciones
                if (DgvListaClientes.SelectedRows.Count == 0)
                {
                    throw new Exception
                        (
                        "Debe seleccionar un cliente.\n" +
                        "Puede hacerlo con un click en su cabecera de fila."
                        );
                }
                cliente = (CCliente)
                    (DgvListaClientes.SelectedRows[0].DataBoundItem);

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma modificación?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    cliente.NombreCliente = TextboxNombreCliente.Text;
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;
                }

                // Adendas
                DgvListaClientes_CellClick(this, null);
                LabelInformacion.Text = "Modificación del Cliente realizada exitosamente.\n";
                LabelInformacion.Text += "Para asignarle un cobro, haga click en la cabecera de fila.";
                TextboxLegajoCliente.Focus();
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }

        }

        // *---------------------------------------------------------=> Grupo 2
        private void CmdAltaCobro_Click(object sender, EventArgs e)
        {
            EtiquetaPendientes.Text = "Los códigos deben ser únicos. ";
            EtiquetaPendientes.Text += "Los nombres son un ayuda-memoria.";
            try
            {
                // Verificaciones
                ErrorProvider.Clear();
                if (DgvListaClientes.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar un cliente.\n" +
                      "Puede hacerlo con un click en su cabecera de fila.");
                }
                else if (
                    TextboxCodigoCobro.Text == string.Empty ||
                    TextboxNombreCobro.Text == string.Empty ||
                    TextboxImporte.Text == string.Empty
                    ) { throw new Exception("No pueden haber campos vacíos"); }

                cliente = (CCliente)DgvListaClientes.SelectedRows[0].DataBoundItem;
                if (cliente.VerPendientes().Count > 1)
                { throw new Exception("El cliente no puede tener más de dos pendientes"); }

                foreach (var x in clientes)
                {
                    if (x.EsDuplicado(int.Parse(TextboxCodigoCobro.Text)))
                    { throw new Exception("Ese código de cobro ya ha sido tomado.\nElija otro."); }
                }

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma Alta de Cobro?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    if (CheckTipoEspecial.Checked)
                    {
                        cobro = new CCobroEspecial
                            (
                            TextboxNombreCliente.Text,
                            "Especial",
                            int.Parse(TextboxCodigoCobro.Text),
                            TextboxNombreCobro.Text,
                            DpickerFVencimiento.Value,
                            decimal.Parse(TextboxImporte.Text)
                            );
                        cliente.AltaPendiente(cobro);
                    }
                    else
                    {
                        cobro = new CCobroNormal
                            (
                            TextboxNombreCliente.Text,
                            "Normal",
                            int.Parse(TextboxCodigoCobro.Text),
                            TextboxNombreCobro.Text,
                            DpickerFVencimiento.Value,
                            decimal.Parse(TextboxImporte.Text)
                            );
                        cliente.AltaPendiente(cobro);
                    }
                    DgvListaPendientes.DataSource = null;
                    if (cliente.VerPendientes() != null && cliente.VerPendientes().Count > 0)
                    { DgvListaPendientes.DataSource = cliente.VerPendientes(); }

                    // Adendas
                    CheckTipoEspecial.Checked = false;
                    TextboxCodigoCobro.Text = string.Empty;
                    TextboxNombreCobro.Text = string.Empty;
                    DpickerFVencimiento.Value = DateTime.Now;
                    TextboxImporte.Text = string.Empty;

                    LabelInformacion.Text = "Alta de Cobro realizada exitosamente.\n";
                    LabelInformacion.Text += "Para proceder al pago, recuerde:\n";
                    LabelInformacion.Text += "Debe seleccionar tanto cliente como cobro.\n";
                    LabelInformacion.Text += "Se hace haciendo click en la cabecera de fila de cada uno.";
                }
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaPendientes, error.Message); }
        }

        private void CmdPagar_Click(object sender, EventArgs e)
        {
            EtiquetaPendientes.Text = "Los códigos deben ser únicos. ";
            EtiquetaPendientes.Text += "Los nombres son un ayuda-memoria.";
            try
            {
                ErrorProvider.Clear();
                // Verificaciones
                if (DgvListaClientes.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar un cliente.\n" +
                      "Puede hacerlo con un click en su cabecera de fila.");
                }
                else if (DgvListaPendientes.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar un cobro.\n" +
                      "Puede hacerlo con un click en su cabecera de fila.");
                }
                cliente = (CCliente)
                   (DgvListaClientes.SelectedRows[0].DataBoundItem);
                cobro = (CCobro)
                    (DgvListaPendientes.SelectedRows[0].DataBoundItem);

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma Pago de Cobro?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    LabelInformacion.Text = string.Empty;

                    DateTime desde = (DateTime)DpickerFVencimiento.Value;
                    DateTime hasta = DateTime.Now.AddDays(-1);
                    int retraso = cobro.CalcularRetrasoEnDias(desde, hasta);
                    decimal recargo = cobro.CalcularRecargo(cobro.Importe, retraso);

                    string advertencia = $"{usuario}, está por ingresar este pago:\n\n";
                    advertencia += $"\tImporte \t {(cobro.Importe).ToString("C")}\n";
                    if (recargo > 0) { advertencia += $"\tRecargo \t {recargo.ToString("C")}\n"; }
                    advertencia += $"\tTotal   \t {(cobro.Importe + recargo).ToString("C")}";

                    MessageBox.Show
                    (
                    advertencia,
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                    pago = new CPago
                        (
                        cobro.Cliente,
                        cobro.Tipo,
                        cobro.Codigo,
                        cobro.NombreCobro,
                        cobro.FechaVencimiento,
                        cobro.Importe,
                        recargo,
                        0
                        );

                    pago.OnTotalChanged += Pago_OnTotalChanged;
                    pago.Total = cobro.Importe + recargo;

                    cliente.AltaCancelado(pago);
                    cliente.BajaPendiente(cobro);

                    clonada = cliente.VerCancelados().ToList();
                    ordenable = cliente.VerCancelados();
                    reducida = cliente.VerCancelados().Select(x => new CReducida()
                    {
                        Nombre = x.Cliente,
                        Total = x.Total
                    }).ToList();

                    DgvListaPendientes.DataSource = null;
                    DgvListaCanceladosG3.DataSource = null;
                    DgvListaCanceladosG4.DataSource = null;
                    DgvListaCanceladosG5.DataSource = null;

                    DgvListaPendientes.DataSource = cliente.VerPendientes();
                    DgvListaCanceladosG3.DataSource = clonada;
                    DgvListaCanceladosG4.DataSource = ordenable;
                    DgvListaCanceladosG5.DataSource = reducida;

                    // Adendas
                    RadioAscendente.Enabled = true;
                    RadioDescendente.Enabled = true;

                    RadioAscendente.Checked = false;
                    RadioDescendente.Checked = false;

                    CmdPagar.Enabled = false;
                    CmdAltaCobro.Enabled = true;

                    CheckTipoEspecial.Checked = false;
                    TextboxCodigoCobro.Text = string.Empty;
                    TextboxNombreCobro.Text = string.Empty;
                    DpickerFVencimiento.Value = DateTime.Now;
                    TextboxImporte.Text = string.Empty;

                    TextboxCodigoCobro.Focus();

                    if (pago.Total <= 10000)
                    { LabelInformacion.Text = "Pago realizado exitosamente."; }
                }
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaPendientes, error.Message); }
        }
        #endregion
    }
}
