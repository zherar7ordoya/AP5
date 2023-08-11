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

        #region GLOBALES

        private List<CCliente> clientes  = new List<CCliente>();            
        private CCliente cliente         = null;                            
        private CCobro cobro             = null;                            
        private CPago pago               = null;                            
        private List<CPago> clonada      = new List<CPago>();               
        private List<CPago> ordenable    = new List<CPago>();               
        private List<CReducida> reducida = new List<CReducida>();           
        private string usuario           = string.Empty;                    
        private Control ctrl             = null;

        #endregion

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
                if (String.IsNullOrWhiteSpace(usuario)) { Close(); }
            }
        }

        private void PersonalizaFormulario()
        {
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text           += $" ({usuario})";
            MaximizeBox     = false;
            MinimizeBox     = false;
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

                DgvClientes.DataSource     = clientes;
                DgvPendientes.DataSource   = cliente.VerPendientes();
                DgvCanceladosG3.DataSource = clonada;
                DgvCanceladosG4.DataSource = ordenable;
                DgvCanceladosG5.DataSource = reducida;

                CmdAltaCliente.Enabled            = false;
                CmdModificaCliente.Enabled        = true;
                CmdBajaCliente.Enabled            = true;
                TboxLegajoCliente.Enabled      = false;
                DgvClientes.Rows[0].Selected = true;
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
                LabelInformacion.Text  = "Inicie dando un cliente de alta.\n";
                LabelInformacion.Text += "Click en cabecera de fila para seleccionarlo.\n";
                LabelInformacion.Text += "Click en una celda para habilitar nuevas altas.";
            }
            SimulaPlaceholder();
            EstableceTooltips();
            ctrl = LabelInformacion;
            TboxLegajoCliente.Focus();
        }

        // *--------------------------------------------------------=> Vigencia

        private void EstableceTooltips()
        {
            Tooltip.SetToolTip(
                TboxLegajoCliente,
                "El legajo debe ser único. Le sugerimos un número entero positivo.");
            Tooltip.SetToolTip(
                TboxNombreCliente,
                "Use un nombre convencional que empiece con mayúscula");
            Tooltip.SetToolTip(
                CmdAltaCliente,
                "Antes, asegúrese de haber completado correctamente los datos pedidos.");
            Tooltip.SetToolTip(
                CmdModificaCliente,
                "Modifique el dato que desea actualizar.");
            Tooltip.SetToolTip(
                CmdBajaCliente,
                "Asegúrese que el cliente seleccionado es el que desea eliminar.");
            Tooltip.SetToolTip(
                CboxTipoCobro,
                "Cobros normales y especiales tienen distinta tasa de interés.");
            Tooltip.SetToolTip(
                TboxCodigoCobro,
                "El código debe ser único. Le sugerimos un número entero positivo.");
            Tooltip.SetToolTip(
                TboxNombreCobro,
                "Escriba un ayuda-memoria que le ayude a recordar este cobro.");
            Tooltip.SetToolTip(
                DateVencimientoCobro,
                "Cuándo venció el cobro.");
            Tooltip.SetToolTip(
                TboxImporteCobro,
                "El importe monetario del cobro.");
            Tooltip.SetToolTip(
                CmdAltaCobro,
                "Antes, asegúrese de haber completado correctamente los datos pedidos.");
            Tooltip.SetToolTip(
                CmdPagoCobro,
                "Asegúrese que el cobro seleccionado es el que desea cancelar.");
            Tooltip.SetToolTip(
                RadioAscendente,
                "Ordenará la lista de cobros cancelados en forma ascendente.");
            Tooltip.SetToolTip(
                RadioDescendente,
                "Ordenará la lista de cobros cancelados en forma descendente.");
        }

        private void TboxHolaFoco(object sender, EventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            if (tbox.Text == tbox.Tag.ToString())
            { tbox.Text = String.Empty; }
        }

        private void TboxChauFoco(object sender, EventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            if (String.IsNullOrWhiteSpace(tbox.Text))
            { tbox.Text = tbox.Tag.ToString(); }
        }

        private void SimulaPlaceholder()
        {
            foreach (Control gbox in Controls)
            {
                if (gbox is GroupBox)
                {
                    foreach (Control tbox in gbox.Controls)
                    {
                        if (tbox is TextBox)
                        {
                            tbox.GotFocus  += new EventHandler(TboxHolaFoco);
                            tbox.LostFocus += new EventHandler(TboxChauFoco);
                        }
                    }
                }
            }
        }

        // *--------------------------------------------------------=> Descarga

        private void CFormulario_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (MessageBox.Show
                (
                "¿Desea salir de la aplicación?",
                $"{usuario}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                )
                == DialogResult.No
                )
            { e.Cancel = true; }
        }

        protected override bool ProcessCmdKey(
            ref Message msg,
            Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        #endregion

        ///////////////////////////////////////////////////////////////////////

        #region LATENTE

        private void InformaExcepcion(Control pControl, string pMensaje)
        {
            ErrorProvider.Clear();
            ErrorProvider.SetError
                (
                pControl,
                pMensaje
                );
            LabelInformacion.Text = "ERROR";
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
        
        #endregion

        ///////////////////////////////////////////////////////////////////////

        #region EVENTOS

        // *---------------------------------------------------------=> Grupo 1

        private void DgvListaClientes_RowHeaderMouseClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ctrl = DgvClientes;

                cliente = (CCliente)
                    (DgvClientes.SelectedRows[0].DataBoundItem);

                TboxLegajoCliente.Text = DgvClientes
                    .Rows[e.RowIndex].Cells[0].Value.ToString();
                TboxNombreCliente.Text = DgvClientes
                    .Rows[e.RowIndex].Cells[1].Value.ToString();

                // En G1
                TboxLegajoCliente.Enabled    = false;
                CmdAltaCliente.Enabled       = false;
                CmdModificaCliente.Enabled   = true;
                CmdBajaCliente.Enabled       = true;

                // En G2
                CboxTipoCobro.Enabled        = true;
                TboxCodigoCobro.Enabled      = true;
                TboxNombreCobro.Enabled      = true;
                DateVencimientoCobro.Enabled = true;
                TboxImporteCobro.Enabled     = true;
                CmdAltaCobro.Enabled         = true;
                CmdPagoCobro.Enabled         = false;
                DgvPendientes.DataSource     = null;

                if (cliente.VerPendientes() != null && cliente.VerPendientes().Count > 0)
                { DgvPendientes.DataSource = cliente.VerPendientes(); }
                LabelInformacion.Text  = "Seleccionado el cliente, puede ";
                LabelInformacion.Text += "modificarlo o agregar un cobro.";

                // En G3
                // En G4
                // En G5
                ctrl = DgvCanceladosG3;
                if(cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    clonada   = cliente.VerCancelados().ToList();
                    ordenable = cliente.VerCancelados();
                    reducida  = cliente.VerCancelados().Select(x => new CReducida()
                    {
                        Nombre = x.Cliente,
                        Total  = x.Total
                    }).ToList();
                    DgvCanceladosG3.DataSource = null;
                    DgvCanceladosG4.DataSource = null;
                    DgvCanceladosG5.DataSource = null;

                    DgvCanceladosG3.DataSource = clonada;
                    DgvCanceladosG4.DataSource = ordenable;
                    DgvCanceladosG5.DataSource = reducida;

                    RadioAscendente.Enabled         = true;
                    RadioDescendente.Enabled        = true;
                    RadioAscendente.Checked         = false;
                    RadioDescendente.Checked        = false;
                }
            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }
        }

        private void DgvListaClientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                ctrl = DgvClientes;
                if (DgvClientes.SelectedRows.Count > 0)
                {
                    cliente = (CCliente)DgvClientes.SelectedRows[0].DataBoundItem;
                    if (cliente.VerPendientes().Count > 0)
                    { DgvPendientes.DataSource = cliente.VerPendientes(); }
                }

                // En G1
                DgvPendientes.DataSource   = null;
                TboxLegajoCliente.Text     = TboxLegajoCliente.Tag.ToString();
                TboxNombreCliente.Text     = TboxNombreCliente.Tag.ToString();
                TboxLegajoCliente.Enabled  = true;
                CmdAltaCliente.Enabled     = true;
                CmdModificaCliente.Enabled = false;
                CmdBajaCliente.Enabled     = false;

                // En G2
                CmdAltaCobro.Enabled       = true;
                CmdPagoCobro.Enabled       = false;
                DgvPendientes.DataSource   = null;
                LabelInformacion.Text      = "Deseleccionado el cliente, puede ";
                LabelInformacion.Text     += "agregar otro cliente.";

                // En G3
                DgvCanceladosG3.DataSource = null;

                // En G4
                DgvCanceladosG4.DataSource = null;
                RadioAscendente.Enabled    = false;
                RadioAscendente.Checked    = false;
                RadioDescendente.Enabled   = false;
                RadioDescendente.Checked   = false;

                // En G5
                DgvCanceladosG5.DataSource = null;
            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }
        }

        // *---------------------------------------------------------=> Grupo 2

        private void DgvListaPendientes_RowHeaderMouseClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // Verificación
                ctrl = DgvClientes;
                cliente = (CCliente)
                    (DgvClientes.SelectedRows[0].DataBoundItem);
                ctrl = DgvPendientes;
                cobro = (CCobro)
                    (DgvPendientes.SelectedRows[0].DataBoundItem);

                // En G1
                // En G2
                if (cobro.Tipo == "Especial") { CboxTipoCobro.Checked = true; }
                TboxCodigoCobro.Text       = cobro.Codigo.ToString();
                TboxNombreCobro.Text       = cobro.NombreCobro;
                DateVencimientoCobro.Value = cobro.FechaVencimiento;
                TboxImporteCobro.Text      = cobro.Importe.ToString();
                CmdAltaCobro.Enabled       = false;
                CmdPagoCobro.Enabled       = true;
                LabelInformacion.Text      = "Seleccionado cliente y cobro, ";
                LabelInformacion.Text     += "puede proceder al pago del mismo.";

                // En G3
                // En G4
                // En G5
            }
            catch (Exception ex)
            { 
                InformaExcepcion(
                    ctrl,
                    $"¿Tiene seleccionado un cliente?\n(Fila cliente seleccionada)\n\n{ex.Message}");
            }
        }

        private void DgvListaPendientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                ctrl = DgvPendientes;

                // En G1
                // En G2
                CboxTipoCobro.Checked      = false;
                TboxCodigoCobro.Text       = TboxCodigoCobro.Tag.ToString();
                TboxNombreCobro.Text       = TboxNombreCobro.Tag.ToString();
                DateVencimientoCobro.Value = DateTime.Today.AddDays(-1);
                TboxImporteCobro.Text      = TboxImporteCobro.Tag.ToString();
                CmdAltaCobro.Enabled       = true;
                CmdPagoCobro.Enabled       = false;
                LabelInformacion.Text      = "Deseleccionado un cliente, puede ";
                LabelInformacion.Text     += "proceder al alta de otro cobro.\n";
                LabelInformacion.Text     += "Tip: el nombre de cobro es un ayuda-memoria para usted.";

                // En G3
                // En G4
                // En G5
            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }
        }

        // *---------------------------------------------------------=> Grupo 4
        
        private void RadioAscendente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl = RadioAscendente;

                if(cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    List<CPago> ascendente = cliente.VerCancelados().OrderBy(x => x.Total).ToList();
                    DgvCanceladosG4.DataSource = null;
                    DgvCanceladosG4.DataSource = ascendente;
                }

                // En G1
                // En G2
                LabelInformacion.Text = "Información\n\nLos pagos han sido ordenados de menor a mayor por el total.";

                // En G3
                // En G4
                // En G5

            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }
        }
        
        private void RadioDescendente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl = RadioDescendente;

                if (cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    List<CPago> descendente = cliente.VerCancelados().OrderByDescending(x => x.Total).ToList();
                    DgvCanceladosG4.DataSource = null;
                    DgvCanceladosG4.DataSource = descendente;
                }

                // En G1
                // En G2
                LabelInformacion.Text = "Información\n\nLos pagos han sido ordenados de mayor a menor por el total.";

                // En G3
                // En G4
                // En G5
            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }
        }

        private void DgvClientes_MouseEnter(object sender, EventArgs e)
        {
            LabelInformacion.Text =
                "Para operar con el cliente, haga click en la cabecera de fila.\n" +
                "Para operar con otros clientes, haga click en cualquier celda.";
        }

        private void DgvPendientes_MouseEnter(object sender, EventArgs e)
        {
            LabelInformacion.Text =
                "Para operar con el cobro, haga click en la cabecera de fila.\n" +
                "Para operar con otros cobros, haga click en cualquier celda.";
        }
        
        #endregion

        ///////////////////////////////////////////////////////////////////////

        #region MÉTODOS

        // *---------------------------------------------------------=> Grupo 1

        private void CmdAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                if (
                    TboxLegajoCliente.Text == string.Empty ||
                    TboxLegajoCliente.Text == TboxLegajoCliente.Tag.ToString())
                {
                    ctrl = TboxLegajoCliente;
                    throw new Exception("Es necesario un número de legajo.");
                }
                else if (clientes.Any
                    (x => x.Legajo == Int32.Parse(TboxLegajoCliente.Text)))
                {
                    ctrl = TboxLegajoCliente;
                    throw new Exception("Los números de legajo deben ser diferentes."); 
                }
                else if (
                    TboxNombreCliente.Text == string.Empty ||
                    TboxNombreCliente.Text == TboxNombreCliente.Tag.ToString())
                {
                    ctrl = TboxNombreCliente;
                    throw new Exception("Es necesario un nombre de cliente.");
                }
                else if (
                    !Regex.Match(TboxNombreCliente.Text,
                    "^[A-Z][A-zÀ-ú ]*$").Success
                    )
                {
                    ctrl = TboxNombreCliente;
                    throw new Exception
                        ("Use un nombre propio que empiece con mayúscula.\n" +
                        "\t(Ejemplos: Fulano, Mengano, Zutano...)"); 
                }

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
                    Int32.Parse(TboxLegajoCliente.Text),
                    TboxNombreCliente.Text
                    ));
                    DgvClientes.DataSource = null;
                    DgvClientes.DataSource = clientes;

                    // Adendas
                    DgvListaClientes_CellClick(this, null);
                    LabelInformacion.Text  = "Alta del Cliente realizada exitosamente.\n";
                    LabelInformacion.Text += "Para asignarle un cobro, haga click en la cabecera de fila.";
                    TboxLegajoCliente.Focus();
                }
            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }
        }

        private void CmdBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                if (DgvClientes.SelectedRows.Count == 0)
                {
                    ctrl = DgvClientes;
                    throw new Exception
                        ("Debe seleccionar un cliente.\n" +
                        "Puede hacerlo con un click en su cabecera de fila.");
                }
                cliente = (CCliente)
                    (DgvClientes.SelectedRows[0].DataBoundItem);

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
                    DgvClientes.DataSource = null;
                    DgvClientes.DataSource = clientes;
                }

                // Adendas
                DgvListaClientes_CellClick(this, null);
                LabelInformacion.Text  = "Baja del Cliente realizada exitosamente.\n";
                LabelInformacion.Text += "Para asignarle un cobro, haga click en la cabecera de fila.";
                TboxLegajoCliente.Focus();
            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }
        }

        private void CmdModificaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                if (DgvClientes.SelectedRows.Count == 0)
                {
                    ctrl = DgvClientes;
                    throw new Exception
                        ("Debe seleccionar un cliente.\n" +
                        "Puede hacerlo con un click en su cabecera de fila.");
                }
                cliente = (CCliente)
                    (DgvClientes.SelectedRows[0].DataBoundItem);

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma modificación?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    cliente.NombreCliente = TboxNombreCliente.Text;
                    cliente.ActualizaNombre(TboxNombreCliente.Text);
                    DgvClientes.DataSource = null;
                    DgvClientes.DataSource = clientes;
                }

                // Adendas
                DgvListaClientes_CellClick(this, null);
                LabelInformacion.Text  = "Modificación del Cliente realizada exitosamente.\n";
                LabelInformacion.Text += "Para asignarle un cobro, haga click en la cabecera de fila.";
                TboxLegajoCliente.Focus();
            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }

        }

        // *---------------------------------------------------------=> Grupo 2

        private void CmdAltaCobro_Click(object sender, EventArgs e)
        {
            try
            {
                decimal resultado = 0;

                // Verificaciones
                if (DgvClientes.SelectedRows.Count == 0)
                {
                    ctrl = DgvClientes;
                    throw new Exception("Debe seleccionar un cliente.\n" +
                    "Puede hacerlo con un click en su cabecera de fila."); 
                }
                else if (
                    TboxCodigoCobro.Text == string.Empty ||
                    TboxCodigoCobro.Text == TboxCodigoCobro.Tag.ToString())
                {
                    ctrl = TboxCodigoCobro;
                    throw new Exception("Debe colocar un código.");
                }
                else if (
                    TboxNombreCobro.Text == string.Empty ||
                    TboxNombreCobro.Text == TboxNombreCobro.Tag.ToString())
                {
                    ctrl = TboxNombreCobro;
                    throw new Exception("Debe ponerle un nombre al cobro.");
                }
                else if(
                    TboxImporteCobro.Text == string.Empty ||
                    TboxImporteCobro.Text == TboxImporteCobro.Tag.ToString())
                {
                    ctrl = TboxImporteCobro;
                    throw new Exception("El importe no puede estar vacío.");
                }
                else if (!decimal.TryParse(TboxImporteCobro.Text, out resultado))
                {
                    ctrl = TboxImporteCobro;
                    throw new Exception("El importe debe ser numérico.");
                }

                cliente = (CCliente)DgvClientes.SelectedRows[0].DataBoundItem;
                if(cliente.VerPendientes().Count > 1)
                {
                    ctrl = DgvClientes;
                    throw new Exception("El cliente no puede tener más de dos pendientes"); 
                }

                foreach(var x in clientes)
                {
                    if (x.EsDuplicado(Int32.Parse(TboxCodigoCobro.Text)))
                    {
                        ctrl = LabelInformacion;
                        throw new Exception("Ese código de cobro ya ha sido tomado.\nElija otro.");
                    }
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
                    if (CboxTipoCobro.Checked)
                    {
                        cobro = new CCobroEspecial
                            (
                            cliente.NombreCliente,
                            "Especial",
                            Int32.Parse(TboxCodigoCobro.Text),
                            TboxNombreCobro.Text,
                            DateVencimientoCobro.Value,
                            Decimal.Parse(TboxImporteCobro.Text)
                            );
                        cliente.AltaPendiente(cobro);
                    }
                    else
                    {
                        cobro = new CCobroNormal
                            (
                            cliente.NombreCliente,
                            "Normal",
                            Int32.Parse(TboxCodigoCobro.Text),
                            TboxNombreCobro.Text,
                            DateVencimientoCobro.Value,
                            Decimal.Parse(TboxImporteCobro.Text)
                            );
                        cliente.AltaPendiente(cobro);
                    }
                    DgvPendientes.DataSource = null;
                    if (cliente.VerPendientes() != null && cliente.VerPendientes().Count > 0)
                    { DgvPendientes.DataSource = cliente.VerPendientes(); }

                    // Adendas
                    CboxTipoCobro.Checked = false;
                    TboxCodigoCobro.Text   = String.Empty;
                    TboxNombreCobro.Text   = String.Empty;
                    DateVencimientoCobro.Value = DateTime.Now;
                    TboxImporteCobro.Text       = String.Empty;

                    LabelInformacion.Text  = "Alta de Cobro realizada exitosamente.\n";
                    LabelInformacion.Text += "Para proceder al pago, recuerde:\n";
                    LabelInformacion.Text += "Debe seleccionar tanto cliente como cobro.\n";
                    LabelInformacion.Text += "Se hace haciendo click en la cabecera de fila de cada uno.";
                }
            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }
        }

        private void CmdPagoCobros_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                if (DgvClientes.SelectedRows.Count == 0)
                {
                    ctrl = DgvClientes;
                    throw new Exception("Debe seleccionar un cliente.\n" +
                      "Puede hacerlo con un click en su cabecera de fila.");
                }
                else if (DgvPendientes.SelectedRows.Count == 0)
                {
                    ctrl = DgvPendientes;
                    throw new Exception("Debe seleccionar un cobro.\n" +
                      "Puede hacerlo con un click en su cabecera de fila.");
                }
                cliente = (CCliente)
                   (DgvClientes.SelectedRows[0].DataBoundItem);
                cobro = (CCobro)
                    (DgvPendientes.SelectedRows[0].DataBoundItem);

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

                    DateTime desde = (DateTime)DateVencimientoCobro.Value;
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

                    DgvPendientes.DataSource   = null;
                    DgvCanceladosG3.DataSource = null;
                    DgvCanceladosG4.DataSource = null;
                    DgvCanceladosG5.DataSource = null;

                    DgvPendientes.DataSource   = cliente.VerPendientes();
                    DgvCanceladosG3.DataSource = clonada;
                    DgvCanceladosG4.DataSource = ordenable;
                    DgvCanceladosG5.DataSource = reducida;

                    // Adendas
                    RadioAscendente.Enabled    = true;
                    RadioDescendente.Enabled   = true;

                    RadioAscendente.Checked    = false;
                    RadioDescendente.Checked   = false;

                    CmdPagoCobro.Enabled       = false;
                    CmdAltaCobro.Enabled       = true;

                    CboxTipoCobro.Checked      = false;
                    TboxCodigoCobro.Text       = String.Empty;
                    TboxNombreCobro.Text       = String.Empty;
                    DateVencimientoCobro.Value = DateTime.Now;
                    TboxImporteCobro.Text      = String.Empty;

                    TboxCodigoCobro.Focus();

                    if (pago.Total <= 10000)
                    { LabelInformacion.Text = "Pago realizado exitosamente."; }
                }
            }
            catch (Exception ex)
            { InformaExcepcion(ctrl, ex.Message); }
        }
        
        #endregion
    
    }
}
