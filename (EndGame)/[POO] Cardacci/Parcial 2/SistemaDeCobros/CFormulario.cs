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
        List<CCliente> clientes  = new List<CCliente>();                    ///
        CCliente cliente         = null;                                    ///
        CCobro cobro             = null;                                    ///
        CPago pago               = null;                                    ///
        List<CPago> clonada      = new List<CPago>();                       ///
        List<CPago> ordenable    = new List<CPago>();                       ///
        List<CReducida> reducida = new List<CReducida>();                   ///
        string usuario           = string.Empty;                            ///
        ///////////////////////////////////////////////////////////////////////

        #region FORMULARIO
        // *--------------------------------------------------------=> Apertura
        public CFormulario() { InitializeComponent(); }
        private void DefineUsuario()
        {
            while (true)
            {
                if (!String.IsNullOrWhiteSpace(usuario)) { break; }
                usuario = Interaction.InputBox
                    (
                    "Ingrese su nombre:",
                    "Usuario",
                    "Gerardo Tordoya"
                    );
                if (String.IsNullOrWhiteSpace(usuario)) { this.Close(); }
            }
        }
        private void PersonalizaFormulario()
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text += $" ({usuario})";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
                cobro   = new CCobroEspecial("Cliente #1", "Especial", 875, "UNO", new DateTime(2014, 10, 25), 1250);
                cliente.AltaPendiente(cobro);
                cobro   = new CCobroNormal(  "Cliente #1", "Normal",   325, "DOS", new DateTime(2021, 8, 26),  7000);
                cliente.AltaPendiente(cobro);
                pago    = new CPago(         "Cliente #1", "Especial", 275, "SPC", new DateTime(2020, 11, 22), 1000, 8300,  9300);
                cliente.AltaCancelado(pago);
                pago    = new CPago(         "Cliente #1", "Normal",   280, "TPC", new DateTime(2020, 10, 21), 1000, 3970,  4970);
                cliente.AltaCancelado(pago);
                pago    = new CPago(         "Cliente #1", "Normal",   285, "UPC", new DateTime(2020, 9, 20),  1000, 4280,  5280);
                cliente.AltaCancelado(pago);
                pago    = new CPago(         "Cliente #1", "Especial", 290, "VPC", new DateTime(2020, 8, 19),  1000, 10200, 11200);
                cliente.AltaCancelado(pago);
                clientes.Add(cliente);

                clonada   = cliente.VerCancelados().ToList();
                ordenable = cliente.VerCancelados();
                reducida  = cliente.VerCancelados().Select(x => new CReducida()
                { Nombre  = x.Cliente, Total = x.Total }).ToList();

                DgvListaClientes.DataSource     = clientes;
                DgvListaPendientes.DataSource   = cliente.VerPendientes();
                DgvListaCanceladosG3.DataSource = clonada;
                DgvListaCanceladosG4.DataSource = ordenable;
                DgvListaCanceladosG5.DataSource = reducida;

                CmdAltaCliente.Enabled            = false;
                CmdModificaCliente.Enabled        = true;
                CmdBajaCliente.Enabled            = true;
                TextboxLegajoCliente.Enabled      = false;
                DgvListaClientes.Rows[0].Selected = true;
                RadioAscendente.Enabled           = true;
                RadioDescendente.Enabled          = true;

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
            if (String.IsNullOrEmpty(LabelInformacion.Text))
            {
                this.LabelInformacion.Text  = "Inicie dando un cliente de alta.\n";
                this.LabelInformacion.Text += "Click en cabecera de fila para seleccionarlo.\n";
                this.LabelInformacion.Text += "Click en una celda para habilitar nuevas altas.";
            }
            SimulaPlaceholder();
            this.TextboxLegajoCliente.Focus();
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
            if (String.IsNullOrWhiteSpace(tbox.Text))
            { tbox.Text = tbox.Tag.ToString(); }
        }

        private void SimulaPlaceholder()
        {
            foreach (Control x in this.Controls)
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
                this.Close();
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
            EtiquetaClientes.Text   = String.Empty;
            EtiquetaPendientes.Text = String.Empty;
            LabelInformacion.Text   = String.Empty;
            try
            {
                cliente = (CCliente)
                    (this.DgvListaClientes.SelectedRows[0].DataBoundItem);

                TextboxLegajoCliente.Text = DgvListaClientes
                    .Rows[e.RowIndex].Cells[0].Value.ToString();
                TextboxNombreCliente.Text = DgvListaClientes
                    .Rows[e.RowIndex].Cells[1].Value.ToString();

                // En G1
                TextboxLegajoCliente.Enabled  = false;
                CmdAltaCliente.Enabled        = false;
                CmdModificaCliente.Enabled    = true;
                CmdBajaCliente.Enabled        = true;

                // En G2
                CheckTipoEspecial.Enabled     = true;
                TextboxCodigoCobro.Enabled    = true;
                TextboxNombreCobro.Enabled    = true;
                DpickerFVencimiento.Enabled   = true;
                TextboxImporte.Enabled        = true;
                CmdAltaCobro.Enabled          = true;
                CmdPagar.Enabled              = false;
                DgvListaPendientes.DataSource = null;

                if (cliente.VerPendientes() != null && cliente.VerPendientes().Count > 0)
                { DgvListaPendientes.DataSource = cliente.VerPendientes(); }
                this.LabelInformacion.Text  = "Seleccionado el cliente, puede ";
                this.LabelInformacion.Text += "modificarlo o agregar un cobro.";

                // En G3
                // En G4
                // En G5
                if(cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    clonada   = cliente.VerCancelados().ToList();
                    ordenable = cliente.VerCancelados();
                    reducida  = cliente.VerCancelados().Select(x => new CReducida()
                    {
                        Nombre = x.Cliente,
                        Total  = x.Total
                    }).ToList();
                    DgvListaCanceladosG3.DataSource = null;
                    DgvListaCanceladosG4.DataSource = null;
                    DgvListaCanceladosG5.DataSource = null;

                    DgvListaCanceladosG3.DataSource = clonada;
                    DgvListaCanceladosG4.DataSource = ordenable;
                    DgvListaCanceladosG5.DataSource = reducida;

                    RadioAscendente.Enabled         = true;
                    RadioDescendente.Enabled        = true;
                    RadioAscendente.Checked         = false;
                    RadioDescendente.Checked        = false;
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
            EtiquetaClientes.Text   = String.Empty;
            EtiquetaPendientes.Text = String.Empty;
            LabelInformacion.Text   = String.Empty;
            try
            {
                if (DgvListaClientes.SelectedRows.Count > 0)
                {
                    cliente = (CCliente)DgvListaClientes.SelectedRows[0].DataBoundItem;
                    if (cliente.VerPendientes().Count > 0)
                    { this.DgvListaPendientes.DataSource = cliente.VerPendientes(); }
                }

                // En G1
                this.DgvListaPendientes.DataSource = null;
                this.TextboxLegajoCliente.Text     = String.Empty;
                this.TextboxNombreCliente.Text     = String.Empty;
                this.TextboxLegajoCliente.Enabled  = true;
                this.CmdAltaCliente.Enabled        = true;
                this.CmdModificaCliente.Enabled    = false;
                this.CmdBajaCliente.Enabled        = false;
                this.EtiquetaClientes.Text         = "Para legajo, le sugerimos un entero positivo";

                // En G2
                this.LabelInformacion.Text         = String.Empty;
                this.CmdAltaCobro.Enabled          = true;
                this.CmdPagar.Enabled              = false;
                this.DgvListaPendientes.DataSource = null;
                this.LabelInformacion.Text         = "Deseleccionado el cliente, puede ";
                this.LabelInformacion.Text        += "agregar otro cliente.";

                // En G3
                this.DgvListaCanceladosG3.DataSource = null;

                // En G4
                this.DgvListaCanceladosG4.DataSource = null;
                this.RadioAscendente.Enabled         = false;
                this.RadioAscendente.Checked         = false;
                this.RadioDescendente.Enabled        = false;
                this.RadioDescendente.Checked        = false;

                // En G5
                this.DgvListaCanceladosG5.DataSource = null;
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
            EtiquetaClientes.Text   = String.Empty;
            EtiquetaPendientes.Text = String.Empty;
            LabelInformacion.Text   = String.Empty;
            try
            {
                // Verificación
                cliente = (CCliente)
                    (this.DgvListaClientes.SelectedRows[0].DataBoundItem);
                cobro = (CCobro)
                    (this.DgvListaPendientes.SelectedRows[0].DataBoundItem);

                // En G1
                // En G2
                if (cobro.Tipo == "Especial") { this.CheckTipoEspecial.Checked = true; }
                TextboxCodigoCobro.Text          = cobro.Codigo.ToString();
                TextboxNombreCobro.Text          = cobro.NombreCobro;
                DpickerFVencimiento.Value = cobro.FechaVencimiento;
                TextboxImporte.Text              = cobro.Importe.ToString();
                CmdAltaCobro.Enabled             = false;
                CmdPagar.Enabled                 = true;
                this.LabelInformacion.Text       = "Seleccionado cliente y cobro, ";
                this.LabelInformacion.Text      += "puede proceder al pago del mismo.";

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
            EtiquetaClientes.Text   = String.Empty;
            EtiquetaPendientes.Text = String.Empty;
            LabelInformacion.Text   = String.Empty;
            try
            {
                // En G1
                // En G2
                this.CheckTipoEspecial.Checked   = false;
                TextboxCodigoCobro.Text          = String.Empty;
                TextboxNombreCobro.Text          = String.Empty;
                DpickerFVencimiento.Value = DateTime.Today.AddDays(-1);
                TextboxImporte.Text              = String.Empty;
                CmdAltaCobro.Enabled             = true;
                CmdPagar.Enabled                 = false;
                this.LabelInformacion.Text       = "Deseleccionado un cliente, puede ";
                this.LabelInformacion.Text      += "proceder al alta de otro cobro.\n";
                this.LabelInformacion.Text      += "Tip: el nombre de cobro es un ayuda-memoria para usted.";
                this.EtiquetaPendientes.Text     = "Para código sugerimos un número entero positivo.\n";

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
            EtiquetaClientes.Text   = String.Empty;
            EtiquetaPendientes.Text = String.Empty;
            LabelInformacion.Text   = String.Empty;

            try
            {
                if(cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    List<CPago> ascendente = cliente.VerCancelados().OrderBy(x => x.Total).ToList();
                    DgvListaCanceladosG4.DataSource = null;
                    DgvListaCanceladosG4.DataSource = ascendente;
                }

                // En G1
                // En G2
                this.LabelInformacion.Text = "Información\n\nLos pagos han sido ordenados de menor a mayor por el total.";

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
            EtiquetaClientes.Text   = String.Empty;
            EtiquetaPendientes.Text = String.Empty;
            LabelInformacion.Text   = String.Empty;
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
                this.LabelInformacion.Text = "Información\n\nLos pagos han sido ordenados de mayor a menor por el total.";

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
            EtiquetaClientes.Text  = "Los legajos deben ser únicos. ";
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
                else if(clientes.Any
                    (x => x.Legajo == Int32.Parse(TextboxLegajoCliente.Text)))
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
                    Int32.Parse(TextboxLegajoCliente.Text),
                    TextboxNombreCliente.Text
                    ));
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;

                    // Adendas
                    DgvListaClientes_CellClick(this, null);
                    LabelInformacion.Text  = "Alta del Cliente realizada exitosamente.\n";
                    LabelInformacion.Text += "Para asignarle un cobro, haga click en la cabecera de fila.";
                    this.TextboxLegajoCliente.Focus();
                }
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }

        private void CmdBajaCliente_Click(object sender, EventArgs e)
        {
            EtiquetaClientes.Text  = "Los legajos deben ser únicos. ";
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
                    (this.DgvListaClientes.SelectedRows[0].DataBoundItem);

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma baja?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    this.clientes.Remove(cliente);
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;
                }

                // Adendas
                DgvListaClientes_CellClick(this, null);
                LabelInformacion.Text  = "Baja del Cliente realizada exitosamente.\n";
                LabelInformacion.Text += "Para asignarle un cobro, haga click en la cabecera de fila.";
                this.TextboxLegajoCliente.Focus();
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }
        }

        private void CmdModificaCliente_Click(object sender, EventArgs e)
        {
            EtiquetaClientes.Text  = "Los legajos deben ser únicos. ";
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
                    (this.DgvListaClientes.SelectedRows[0].DataBoundItem);

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
                LabelInformacion.Text  = "Modificación del Cliente realizada exitosamente.\n";
                LabelInformacion.Text += "Para asignarle un cobro, haga click en la cabecera de fila.";
                this.TextboxLegajoCliente.Focus();
            }
            catch (Exception error)
            { InformaExcepcion(EtiquetaClientes, error.Message); }

        }

        // *---------------------------------------------------------=> Grupo 2
        private void CmdAltaCobro_Click(object sender, EventArgs e)
        {
            EtiquetaPendientes.Text  = "Los códigos deben ser únicos. ";
            EtiquetaPendientes.Text += "Los nombres son un ayuda-memoria.";
            try
            {
                // Verificaciones
                ErrorProvider.Clear();
                if (DgvListaClientes.SelectedRows.Count == 0)
                { throw new Exception("Debe seleccionar un cliente.\n" +
                    "Puede hacerlo con un click en su cabecera de fila."); }
                else if (
                    TextboxCodigoCobro.Text == string.Empty ||
                    TextboxNombreCobro.Text == string.Empty ||
                    TextboxImporte.Text == string.Empty
                    ) { throw new Exception("No pueden haber campos vacíos"); }

                cliente = (CCliente)DgvListaClientes.SelectedRows[0].DataBoundItem;
                if(cliente.VerPendientes().Count > 1)
                { throw new Exception("El cliente no puede tener más de dos pendientes"); }

                foreach(var x in clientes)
                {
                    if (x.EsDuplicado(Int32.Parse(TextboxCodigoCobro.Text)))
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
                            Int32.Parse(TextboxCodigoCobro.Text),
                            TextboxNombreCobro.Text,
                            DpickerFVencimiento.Value,
                            Decimal.Parse(TextboxImporte.Text)
                            );
                        cliente.AltaPendiente(cobro);
                    }
                    else
                    {
                        cobro = new CCobroNormal
                            (
                            TextboxNombreCliente.Text,
                            "Normal",
                            Int32.Parse(TextboxCodigoCobro.Text),
                            TextboxNombreCobro.Text,
                            DpickerFVencimiento.Value,
                            Decimal.Parse(TextboxImporte.Text)
                            );
                        cliente.AltaPendiente(cobro);
                    }
                    this.DgvListaPendientes.DataSource = null;
                    if (cliente.VerPendientes() != null && cliente.VerPendientes().Count > 0)
                    { this.DgvListaPendientes.DataSource = cliente.VerPendientes(); }

                    // Adendas
                    CheckTipoEspecial.Checked = false;
                    TextboxCodigoCobro.Text   = String.Empty;
                    TextboxNombreCobro.Text   = String.Empty;
                    DpickerFVencimiento.Value = DateTime.Now;
                    TextboxImporte.Text       = String.Empty;

                    LabelInformacion.Text  = "Alta de Cobro realizada exitosamente.\n";
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
            EtiquetaPendientes.Text  = "Los códigos deben ser únicos. ";
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
                   (this.DgvListaClientes.SelectedRows[0].DataBoundItem);
                cobro = (CCobro)
                    (this.DgvListaPendientes.SelectedRows[0].DataBoundItem);

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma Pago de Cobro?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    LabelInformacion.Text = String.Empty;

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

                    DgvListaPendientes.DataSource   = null;
                    DgvListaCanceladosG3.DataSource = null;
                    DgvListaCanceladosG4.DataSource = null;
                    DgvListaCanceladosG5.DataSource = null;

                    DgvListaPendientes.DataSource   = cliente.VerPendientes();
                    DgvListaCanceladosG3.DataSource = clonada;
                    DgvListaCanceladosG4.DataSource = ordenable;
                    DgvListaCanceladosG5.DataSource = reducida;

                    // Adendas
                    RadioAscendente.Enabled     = true;
                    RadioDescendente.Enabled    = true;

                    RadioAscendente.Checked     = false;
                    RadioDescendente.Checked    = false;

                    CmdPagar.Enabled            = false;
                    CmdAltaCobro.Enabled        = true;

                    CheckTipoEspecial.Checked   = false;
                    TextboxCodigoCobro.Text     = String.Empty;
                    TextboxNombreCobro.Text     = String.Empty;
                    DpickerFVencimiento.Value   = DateTime.Now;
                    TextboxImporte.Text         = String.Empty;

                    this.TextboxCodigoCobro.Focus();

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
