
namespace SistemaDeCobros
{
    partial class CFormulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GrpGrilla1 = new System.Windows.Forms.GroupBox();
            this.EtiquetaClientes = new System.Windows.Forms.Label();
            this.CmdModificaCliente = new System.Windows.Forms.Button();
            this.CmdBajaCliente = new System.Windows.Forms.Button();
            this.CmdAltaCliente = new System.Windows.Forms.Button();
            this.TextboxNombreCliente = new System.Windows.Forms.TextBox();
            this.TextboxLegajoCliente = new System.Windows.Forms.TextBox();
            this.LabelNombreCliente = new System.Windows.Forms.Label();
            this.LabelLegajo = new System.Windows.Forms.Label();
            this.DgvListaClientes = new System.Windows.Forms.DataGridView();
            this.GrpGrilla2 = new System.Windows.Forms.GroupBox();
            this.CheckTipoEspecial = new System.Windows.Forms.CheckBox();
            this.LabelInformacion = new System.Windows.Forms.Label();
            this.EtiquetaPendientes = new System.Windows.Forms.Label();
            this.CmdPagar = new System.Windows.Forms.Button();
            this.CmdAltaCobro = new System.Windows.Forms.Button();
            this.LabelImporte = new System.Windows.Forms.Label();
            this.LabelFechaVencimiento = new System.Windows.Forms.Label();
            this.LabelNombreCobro = new System.Windows.Forms.Label();
            this.LabelCodigoCobro = new System.Windows.Forms.Label();
            this.TextboxImporte = new System.Windows.Forms.TextBox();
            this.DpickerFVencimiento = new System.Windows.Forms.DateTimePicker();
            this.TextboxNombreCobro = new System.Windows.Forms.TextBox();
            this.TextboxCodigoCobro = new System.Windows.Forms.TextBox();
            this.DgvListaPendientes = new System.Windows.Forms.DataGridView();
            this.GrpGrilla3 = new System.Windows.Forms.GroupBox();
            this.DgvListaCanceladosG3 = new System.Windows.Forms.DataGridView();
            this.GrpGrilla4 = new System.Windows.Forms.GroupBox();
            this.RadioDescendente = new System.Windows.Forms.RadioButton();
            this.RadioAscendente = new System.Windows.Forms.RadioButton();
            this.DgvListaCanceladosG4 = new System.Windows.Forms.DataGridView();
            this.GrpGrilla5 = new System.Windows.Forms.GroupBox();
            this.DgvListaCanceladosG5 = new System.Windows.Forms.DataGridView();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrpGrilla1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).BeginInit();
            this.GrpGrilla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPendientes)).BeginInit();
            this.GrpGrilla3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG3)).BeginInit();
            this.GrpGrilla4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG4)).BeginInit();
            this.GrpGrilla5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpGrilla1
            // 
            this.GrpGrilla1.Controls.Add(this.EtiquetaClientes);
            this.GrpGrilla1.Controls.Add(this.CmdModificaCliente);
            this.GrpGrilla1.Controls.Add(this.CmdBajaCliente);
            this.GrpGrilla1.Controls.Add(this.CmdAltaCliente);
            this.GrpGrilla1.Controls.Add(this.TextboxNombreCliente);
            this.GrpGrilla1.Controls.Add(this.TextboxLegajoCliente);
            this.GrpGrilla1.Controls.Add(this.LabelNombreCliente);
            this.GrpGrilla1.Controls.Add(this.LabelLegajo);
            this.GrpGrilla1.Controls.Add(this.DgvListaClientes);
            this.GrpGrilla1.Location = new System.Drawing.Point(12, 12);
            this.GrpGrilla1.Name = "GrpGrilla1";
            this.GrpGrilla1.Size = new System.Drawing.Size(340, 351);
            this.GrpGrilla1.TabIndex = 0;
            this.GrpGrilla1.TabStop = false;
            this.GrpGrilla1.Text = "Grilla 1: Listado de clientes";
            // 
            // EtiquetaClientes
            // 
            this.EtiquetaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EtiquetaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaClientes.Location = new System.Drawing.Point(6, 279);
            this.EtiquetaClientes.Name = "EtiquetaClientes";
            this.EtiquetaClientes.Size = new System.Drawing.Size(112, 65);
            this.EtiquetaClientes.TabIndex = 15;
            this.EtiquetaClientes.Text = "Alta de clientes. Modifique/elimine con un click en la cabecera de fila.";
            this.EtiquetaClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmdModificaCliente
            // 
            this.CmdModificaCliente.Enabled = false;
            this.CmdModificaCliente.Location = new System.Drawing.Point(255, 19);
            this.CmdModificaCliente.Name = "CmdModificaCliente";
            this.CmdModificaCliente.Size = new System.Drawing.Size(75, 23);
            this.CmdModificaCliente.TabIndex = 7;
            this.CmdModificaCliente.Text = "Modificación";
            this.CmdModificaCliente.UseVisualStyleBackColor = true;
            this.CmdModificaCliente.Click += new System.EventHandler(this.CmdModificaCliente_Click);
            // 
            // CmdBajaCliente
            // 
            this.CmdBajaCliente.Enabled = false;
            this.CmdBajaCliente.Location = new System.Drawing.Point(255, 48);
            this.CmdBajaCliente.Name = "CmdBajaCliente";
            this.CmdBajaCliente.Size = new System.Drawing.Size(75, 23);
            this.CmdBajaCliente.TabIndex = 6;
            this.CmdBajaCliente.Text = "Baja";
            this.CmdBajaCliente.UseVisualStyleBackColor = true;
            this.CmdBajaCliente.Click += new System.EventHandler(this.CmdBajaCliente_Click);
            // 
            // CmdAltaCliente
            // 
            this.CmdAltaCliente.Location = new System.Drawing.Point(255, 321);
            this.CmdAltaCliente.Name = "CmdAltaCliente";
            this.CmdAltaCliente.Size = new System.Drawing.Size(75, 23);
            this.CmdAltaCliente.TabIndex = 5;
            this.CmdAltaCliente.Text = "Alta";
            this.CmdAltaCliente.UseVisualStyleBackColor = true;
            this.CmdAltaCliente.Click += new System.EventHandler(this.CmdAltaCliente_Click);
            // 
            // TextboxNombreCliente
            // 
            this.TextboxNombreCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextboxNombreCliente.Location = new System.Drawing.Point(230, 295);
            this.TextboxNombreCliente.Name = "TextboxNombreCliente";
            this.TextboxNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.TextboxNombreCliente.TabIndex = 4;
            this.TextboxNombreCliente.Tag = "Un nombre propio";
            this.TextboxNombreCliente.Text = "Un nombre propio";
            // 
            // TextboxLegajoCliente
            // 
            this.TextboxLegajoCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextboxLegajoCliente.Location = new System.Drawing.Point(124, 295);
            this.TextboxLegajoCliente.Name = "TextboxLegajoCliente";
            this.TextboxLegajoCliente.Size = new System.Drawing.Size(100, 20);
            this.TextboxLegajoCliente.TabIndex = 3;
            this.TextboxLegajoCliente.Tag = "Deber ser único";
            this.TextboxLegajoCliente.Text = "Deber ser único";
            // 
            // LabelNombreCliente
            // 
            this.LabelNombreCliente.AutoSize = true;
            this.LabelNombreCliente.Location = new System.Drawing.Point(227, 279);
            this.LabelNombreCliente.Name = "LabelNombreCliente";
            this.LabelNombreCliente.Size = new System.Drawing.Size(95, 13);
            this.LabelNombreCliente.TabIndex = 2;
            this.LabelNombreCliente.Text = "Nombre del cliente";
            // 
            // LabelLegajo
            // 
            this.LabelLegajo.AutoSize = true;
            this.LabelLegajo.Location = new System.Drawing.Point(121, 279);
            this.LabelLegajo.Name = "LabelLegajo";
            this.LabelLegajo.Size = new System.Drawing.Size(39, 13);
            this.LabelLegajo.TabIndex = 1;
            this.LabelLegajo.Text = "Legajo";
            // 
            // DgvListaClientes
            // 
            this.DgvListaClientes.AllowUserToAddRows = false;
            this.DgvListaClientes.AllowUserToDeleteRows = false;
            this.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaClientes.Location = new System.Drawing.Point(6, 19);
            this.DgvListaClientes.MultiSelect = false;
            this.DgvListaClientes.Name = "DgvListaClientes";
            this.DgvListaClientes.ReadOnly = true;
            this.DgvListaClientes.Size = new System.Drawing.Size(243, 257);
            this.DgvListaClientes.TabIndex = 0;
            this.DgvListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaClientes_CellClick);
            this.DgvListaClientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListaClientes_RowHeaderMouseClick);
            // 
            // GrpGrilla2
            // 
            this.GrpGrilla2.Controls.Add(this.CheckTipoEspecial);
            this.GrpGrilla2.Controls.Add(this.LabelInformacion);
            this.GrpGrilla2.Controls.Add(this.EtiquetaPendientes);
            this.GrpGrilla2.Controls.Add(this.CmdPagar);
            this.GrpGrilla2.Controls.Add(this.CmdAltaCobro);
            this.GrpGrilla2.Controls.Add(this.LabelImporte);
            this.GrpGrilla2.Controls.Add(this.LabelFechaVencimiento);
            this.GrpGrilla2.Controls.Add(this.LabelNombreCobro);
            this.GrpGrilla2.Controls.Add(this.LabelCodigoCobro);
            this.GrpGrilla2.Controls.Add(this.TextboxImporte);
            this.GrpGrilla2.Controls.Add(this.DpickerFVencimiento);
            this.GrpGrilla2.Controls.Add(this.TextboxNombreCobro);
            this.GrpGrilla2.Controls.Add(this.TextboxCodigoCobro);
            this.GrpGrilla2.Controls.Add(this.DgvListaPendientes);
            this.GrpGrilla2.Location = new System.Drawing.Point(358, 12);
            this.GrpGrilla2.Name = "GrpGrilla2";
            this.GrpGrilla2.Size = new System.Drawing.Size(856, 169);
            this.GrpGrilla2.TabIndex = 1;
            this.GrpGrilla2.TabStop = false;
            this.GrpGrilla2.Text = "Grilla 2: Cobros pendientes del cliente";
            // 
            // CheckTipoEspecial
            // 
            this.CheckTipoEspecial.AutoSize = true;
            this.CheckTipoEspecial.Enabled = false;
            this.CheckTipoEspecial.Location = new System.Drawing.Point(215, 115);
            this.CheckTipoEspecial.Name = "CheckTipoEspecial";
            this.CheckTipoEspecial.Size = new System.Drawing.Size(89, 17);
            this.CheckTipoEspecial.TabIndex = 17;
            this.CheckTipoEspecial.Text = "Tipo especial";
            this.CheckTipoEspecial.UseVisualStyleBackColor = true;
            // 
            // LabelInformacion
            // 
            this.LabelInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelInformacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInformacion.ForeColor = System.Drawing.Color.Red;
            this.LabelInformacion.Location = new System.Drawing.Point(736, 19);
            this.LabelInformacion.Name = "LabelInformacion";
            this.LabelInformacion.Size = new System.Drawing.Size(113, 140);
            this.LabelInformacion.TabIndex = 14;
            this.LabelInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EtiquetaPendientes
            // 
            this.EtiquetaPendientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EtiquetaPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaPendientes.Location = new System.Drawing.Point(6, 97);
            this.EtiquetaPendientes.Name = "EtiquetaPendientes";
            this.EtiquetaPendientes.Size = new System.Drawing.Size(118, 62);
            this.EtiquetaPendientes.TabIndex = 16;
            this.EtiquetaPendientes.Text = "Alta de cobros.\r\nSeleccione cobro con un click en la cabecera de fila.";
            this.EtiquetaPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmdPagar
            // 
            this.CmdPagar.Enabled = false;
            this.CmdPagar.Location = new System.Drawing.Point(655, 19);
            this.CmdPagar.Name = "CmdPagar";
            this.CmdPagar.Size = new System.Drawing.Size(75, 23);
            this.CmdPagar.TabIndex = 13;
            this.CmdPagar.Text = "Pagar";
            this.CmdPagar.UseVisualStyleBackColor = true;
            this.CmdPagar.Click += new System.EventHandler(this.CmdPagar_Click);
            // 
            // CmdAltaCobro
            // 
            this.CmdAltaCobro.Enabled = false;
            this.CmdAltaCobro.Location = new System.Drawing.Point(655, 136);
            this.CmdAltaCobro.Name = "CmdAltaCobro";
            this.CmdAltaCobro.Size = new System.Drawing.Size(75, 23);
            this.CmdAltaCobro.TabIndex = 12;
            this.CmdAltaCobro.Text = "Alta";
            this.CmdAltaCobro.UseVisualStyleBackColor = true;
            this.CmdAltaCobro.Click += new System.EventHandler(this.CmdAltaCobro_Click);
            // 
            // LabelImporte
            // 
            this.LabelImporte.AutoSize = true;
            this.LabelImporte.Location = new System.Drawing.Point(625, 97);
            this.LabelImporte.Name = "LabelImporte";
            this.LabelImporte.Size = new System.Drawing.Size(42, 13);
            this.LabelImporte.TabIndex = 11;
            this.LabelImporte.Text = "Importe";
            // 
            // LabelFechaVencimiento
            // 
            this.LabelFechaVencimiento.AutoSize = true;
            this.LabelFechaVencimiento.Location = new System.Drawing.Point(519, 97);
            this.LabelFechaVencimiento.Name = "LabelFechaVencimiento";
            this.LabelFechaVencimiento.Size = new System.Drawing.Size(97, 13);
            this.LabelFechaVencimiento.TabIndex = 10;
            this.LabelFechaVencimiento.Text = "Fecha vencimiento";
            // 
            // LabelNombreCobro
            // 
            this.LabelNombreCobro.AutoSize = true;
            this.LabelNombreCobro.Location = new System.Drawing.Point(413, 97);
            this.LabelNombreCobro.Name = "LabelNombreCobro";
            this.LabelNombreCobro.Size = new System.Drawing.Size(91, 13);
            this.LabelNombreCobro.TabIndex = 9;
            this.LabelNombreCobro.Text = "Nombre del cobro";
            // 
            // LabelCodigoCobro
            // 
            this.LabelCodigoCobro.AutoSize = true;
            this.LabelCodigoCobro.Location = new System.Drawing.Point(307, 97);
            this.LabelCodigoCobro.Name = "LabelCodigoCobro";
            this.LabelCodigoCobro.Size = new System.Drawing.Size(40, 13);
            this.LabelCodigoCobro.TabIndex = 8;
            this.LabelCodigoCobro.Text = "Código";
            // 
            // TextboxImporte
            // 
            this.TextboxImporte.Enabled = false;
            this.TextboxImporte.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextboxImporte.Location = new System.Drawing.Point(630, 113);
            this.TextboxImporte.Name = "TextboxImporte";
            this.TextboxImporte.Size = new System.Drawing.Size(100, 20);
            this.TextboxImporte.TabIndex = 7;
            this.TextboxImporte.Tag = "Dinero a cobrar";
            this.TextboxImporte.Text = "Dinero a cobrar";
            // 
            // DpickerFVencimiento
            // 
            this.DpickerFVencimiento.Enabled = false;
            this.DpickerFVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpickerFVencimiento.Location = new System.Drawing.Point(522, 113);
            this.DpickerFVencimiento.Name = "DpickerFVencimiento";
            this.DpickerFVencimiento.Size = new System.Drawing.Size(100, 20);
            this.DpickerFVencimiento.TabIndex = 6;
            // 
            // TextboxNombreCobro
            // 
            this.TextboxNombreCobro.Enabled = false;
            this.TextboxNombreCobro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextboxNombreCobro.Location = new System.Drawing.Point(416, 113);
            this.TextboxNombreCobro.Name = "TextboxNombreCobro";
            this.TextboxNombreCobro.Size = new System.Drawing.Size(100, 20);
            this.TextboxNombreCobro.TabIndex = 5;
            this.TextboxNombreCobro.Tag = "Un ayuda-memoria";
            this.TextboxNombreCobro.Text = "Un ayuda-memoria";
            // 
            // TextboxCodigoCobro
            // 
            this.TextboxCodigoCobro.Enabled = false;
            this.TextboxCodigoCobro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextboxCodigoCobro.Location = new System.Drawing.Point(310, 113);
            this.TextboxCodigoCobro.Name = "TextboxCodigoCobro";
            this.TextboxCodigoCobro.Size = new System.Drawing.Size(100, 20);
            this.TextboxCodigoCobro.TabIndex = 4;
            this.TextboxCodigoCobro.Tag = "Deber ser único";
            this.TextboxCodigoCobro.Text = "Deber ser único";
            // 
            // DgvListaPendientes
            // 
            this.DgvListaPendientes.AllowUserToAddRows = false;
            this.DgvListaPendientes.AllowUserToDeleteRows = false;
            this.DgvListaPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaPendientes.Location = new System.Drawing.Point(6, 19);
            this.DgvListaPendientes.MultiSelect = false;
            this.DgvListaPendientes.Name = "DgvListaPendientes";
            this.DgvListaPendientes.ReadOnly = true;
            this.DgvListaPendientes.Size = new System.Drawing.Size(643, 75);
            this.DgvListaPendientes.TabIndex = 1;
            this.DgvListaPendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaPendientes_CellClick);
            this.DgvListaPendientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListaPendientes_RowHeaderMouseClick);
            // 
            // GrpGrilla3
            // 
            this.GrpGrilla3.Controls.Add(this.DgvListaCanceladosG3);
            this.GrpGrilla3.Location = new System.Drawing.Point(358, 187);
            this.GrpGrilla3.Name = "GrpGrilla3";
            this.GrpGrilla3.Size = new System.Drawing.Size(856, 176);
            this.GrpGrilla3.TabIndex = 2;
            this.GrpGrilla3.TabStop = false;
            this.GrpGrilla3.Text = "Grilla 3: Cobros cancelados del cliente";
            // 
            // DgvListaCanceladosG3
            // 
            this.DgvListaCanceladosG3.AllowUserToAddRows = false;
            this.DgvListaCanceladosG3.AllowUserToDeleteRows = false;
            this.DgvListaCanceladosG3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCanceladosG3.Location = new System.Drawing.Point(6, 19);
            this.DgvListaCanceladosG3.MultiSelect = false;
            this.DgvListaCanceladosG3.Name = "DgvListaCanceladosG3";
            this.DgvListaCanceladosG3.ReadOnly = true;
            this.DgvListaCanceladosG3.Size = new System.Drawing.Size(843, 150);
            this.DgvListaCanceladosG3.TabIndex = 2;
            // 
            // GrpGrilla4
            // 
            this.GrpGrilla4.Controls.Add(this.RadioDescendente);
            this.GrpGrilla4.Controls.Add(this.RadioAscendente);
            this.GrpGrilla4.Controls.Add(this.DgvListaCanceladosG4);
            this.GrpGrilla4.Location = new System.Drawing.Point(12, 369);
            this.GrpGrilla4.Name = "GrpGrilla4";
            this.GrpGrilla4.Size = new System.Drawing.Size(947, 177);
            this.GrpGrilla4.TabIndex = 3;
            this.GrpGrilla4.TabStop = false;
            this.GrpGrilla4.Text = "Grilla 4: Cobros cancelados del cliente (ordenados por total)";
            // 
            // RadioDescendente
            // 
            this.RadioDescendente.AutoSize = true;
            this.RadioDescendente.Enabled = false;
            this.RadioDescendente.Location = new System.Drawing.Point(855, 42);
            this.RadioDescendente.Name = "RadioDescendente";
            this.RadioDescendente.Size = new System.Drawing.Size(89, 17);
            this.RadioDescendente.TabIndex = 5;
            this.RadioDescendente.Text = "Descendente";
            this.RadioDescendente.UseVisualStyleBackColor = true;
            this.RadioDescendente.CheckedChanged += new System.EventHandler(this.RadioDescendente_CheckedChanged);
            // 
            // RadioAscendente
            // 
            this.RadioAscendente.AutoSize = true;
            this.RadioAscendente.Enabled = false;
            this.RadioAscendente.Location = new System.Drawing.Point(855, 19);
            this.RadioAscendente.Name = "RadioAscendente";
            this.RadioAscendente.Size = new System.Drawing.Size(82, 17);
            this.RadioAscendente.TabIndex = 4;
            this.RadioAscendente.Text = "Ascendente";
            this.RadioAscendente.UseVisualStyleBackColor = true;
            this.RadioAscendente.CheckedChanged += new System.EventHandler(this.RadioAscendente_CheckedChanged);
            // 
            // DgvListaCanceladosG4
            // 
            this.DgvListaCanceladosG4.AllowUserToAddRows = false;
            this.DgvListaCanceladosG4.AllowUserToDeleteRows = false;
            this.DgvListaCanceladosG4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCanceladosG4.Location = new System.Drawing.Point(6, 19);
            this.DgvListaCanceladosG4.MultiSelect = false;
            this.DgvListaCanceladosG4.Name = "DgvListaCanceladosG4";
            this.DgvListaCanceladosG4.ReadOnly = true;
            this.DgvListaCanceladosG4.Size = new System.Drawing.Size(843, 150);
            this.DgvListaCanceladosG4.TabIndex = 3;
            // 
            // GrpGrilla5
            // 
            this.GrpGrilla5.Controls.Add(this.DgvListaCanceladosG5);
            this.GrpGrilla5.Location = new System.Drawing.Point(959, 369);
            this.GrpGrilla5.Name = "GrpGrilla5";
            this.GrpGrilla5.Size = new System.Drawing.Size(255, 177);
            this.GrpGrilla5.TabIndex = 4;
            this.GrpGrilla5.TabStop = false;
            this.GrpGrilla5.Text = "Grilla 5: Resumen de pagos del cliente";
            // 
            // DgvListaCanceladosG5
            // 
            this.DgvListaCanceladosG5.AllowUserToAddRows = false;
            this.DgvListaCanceladosG5.AllowUserToDeleteRows = false;
            this.DgvListaCanceladosG5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCanceladosG5.Location = new System.Drawing.Point(6, 19);
            this.DgvListaCanceladosG5.MultiSelect = false;
            this.DgvListaCanceladosG5.Name = "DgvListaCanceladosG5";
            this.DgvListaCanceladosG5.ReadOnly = true;
            this.DgvListaCanceladosG5.Size = new System.Drawing.Size(243, 150);
            this.DgvListaCanceladosG5.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // CFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 556);
            this.Controls.Add(this.GrpGrilla5);
            this.Controls.Add(this.GrpGrilla4);
            this.Controls.Add(this.GrpGrilla3);
            this.Controls.Add(this.GrpGrilla2);
            this.Controls.Add(this.GrpGrilla1);
            this.Name = "CFormulario";
            this.Text = "Sistema de Cobros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CFormulario_FormClosing);
            this.Load += new System.EventHandler(this.CFormulario_Load);
            this.GrpGrilla1.ResumeLayout(false);
            this.GrpGrilla1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).EndInit();
            this.GrpGrilla2.ResumeLayout(false);
            this.GrpGrilla2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPendientes)).EndInit();
            this.GrpGrilla3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG3)).EndInit();
            this.GrpGrilla4.ResumeLayout(false);
            this.GrpGrilla4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG4)).EndInit();
            this.GrpGrilla5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpGrilla1;
        private System.Windows.Forms.DataGridView DgvListaClientes;
        private System.Windows.Forms.GroupBox GrpGrilla2;
        private System.Windows.Forms.GroupBox GrpGrilla3;
        private System.Windows.Forms.GroupBox GrpGrilla4;
        private System.Windows.Forms.GroupBox GrpGrilla5;
        private System.Windows.Forms.Button CmdModificaCliente;
        private System.Windows.Forms.Button CmdBajaCliente;
        private System.Windows.Forms.Button CmdAltaCliente;
        private System.Windows.Forms.TextBox TextboxNombreCliente;
        private System.Windows.Forms.TextBox TextboxLegajoCliente;
        private System.Windows.Forms.Label LabelNombreCliente;
        private System.Windows.Forms.Label LabelLegajo;
        private System.Windows.Forms.DataGridView DgvListaPendientes;
        private System.Windows.Forms.Label LabelInformacion;
        private System.Windows.Forms.Button CmdPagar;
        private System.Windows.Forms.Button CmdAltaCobro;
        private System.Windows.Forms.Label LabelImporte;
        private System.Windows.Forms.Label LabelFechaVencimiento;
        private System.Windows.Forms.Label LabelNombreCobro;
        private System.Windows.Forms.Label LabelCodigoCobro;
        private System.Windows.Forms.TextBox TextboxImporte;
        private System.Windows.Forms.DateTimePicker DpickerFVencimiento;
        private System.Windows.Forms.TextBox TextboxNombreCobro;
        private System.Windows.Forms.TextBox TextboxCodigoCobro;
        private System.Windows.Forms.DataGridView DgvListaCanceladosG3;
        private System.Windows.Forms.RadioButton RadioDescendente;
        private System.Windows.Forms.RadioButton RadioAscendente;
        private System.Windows.Forms.DataGridView DgvListaCanceladosG4;
        private System.Windows.Forms.DataGridView DgvListaCanceladosG5;
        private System.Windows.Forms.Label EtiquetaClientes;
        private System.Windows.Forms.Label EtiquetaPendientes;
        private System.Windows.Forms.CheckBox CheckTipoEspecial;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}

