
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
            this.CmdModificaCliente = new System.Windows.Forms.Button();
            this.CmdBajaCliente = new System.Windows.Forms.Button();
            this.CmdAltaCliente = new System.Windows.Forms.Button();
            this.TboxNombreCliente = new System.Windows.Forms.TextBox();
            this.TboxLegajoCliente = new System.Windows.Forms.TextBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.GrpGrilla2 = new System.Windows.Forms.GroupBox();
            this.CboxTipoCobro = new System.Windows.Forms.CheckBox();
            this.CmdPagoCobro = new System.Windows.Forms.Button();
            this.CmdAltaCobro = new System.Windows.Forms.Button();
            this.TboxImporteCobro = new System.Windows.Forms.TextBox();
            this.DateVencimientoCobro = new System.Windows.Forms.DateTimePicker();
            this.TboxNombreCobro = new System.Windows.Forms.TextBox();
            this.TboxCodigoCobro = new System.Windows.Forms.TextBox();
            this.DgvPendientes = new System.Windows.Forms.DataGridView();
            this.LabelInformacion = new System.Windows.Forms.Label();
            this.GrpGrilla3 = new System.Windows.Forms.GroupBox();
            this.DgvCanceladosG3 = new System.Windows.Forms.DataGridView();
            this.GrpGrilla4 = new System.Windows.Forms.GroupBox();
            this.RadioDescendente = new System.Windows.Forms.RadioButton();
            this.RadioAscendente = new System.Windows.Forms.RadioButton();
            this.DgvCanceladosG4 = new System.Windows.Forms.DataGridView();
            this.GrpGrilla5 = new System.Windows.Forms.GroupBox();
            this.DgvCanceladosG5 = new System.Windows.Forms.DataGridView();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.GrpGrilla1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.GrpGrilla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPendientes)).BeginInit();
            this.GrpGrilla3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCanceladosG3)).BeginInit();
            this.GrpGrilla4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCanceladosG4)).BeginInit();
            this.GrpGrilla5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCanceladosG5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpGrilla1
            // 
            this.GrpGrilla1.Controls.Add(this.CmdModificaCliente);
            this.GrpGrilla1.Controls.Add(this.CmdBajaCliente);
            this.GrpGrilla1.Controls.Add(this.CmdAltaCliente);
            this.GrpGrilla1.Controls.Add(this.TboxNombreCliente);
            this.GrpGrilla1.Controls.Add(this.TboxLegajoCliente);
            this.GrpGrilla1.Controls.Add(this.DgvClientes);
            this.GrpGrilla1.Location = new System.Drawing.Point(12, 12);
            this.GrpGrilla1.Name = "GrpGrilla1";
            this.GrpGrilla1.Size = new System.Drawing.Size(340, 351);
            this.GrpGrilla1.TabIndex = 0;
            this.GrpGrilla1.TabStop = false;
            this.GrpGrilla1.Text = "Grilla 1: ABM Clientes";
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
            this.CmdAltaCliente.Location = new System.Drawing.Point(255, 280);
            this.CmdAltaCliente.Name = "CmdAltaCliente";
            this.CmdAltaCliente.Size = new System.Drawing.Size(75, 23);
            this.CmdAltaCliente.TabIndex = 5;
            this.CmdAltaCliente.Text = "Alta";
            this.CmdAltaCliente.UseVisualStyleBackColor = true;
            this.CmdAltaCliente.Click += new System.EventHandler(this.CmdAltaCliente_Click);
            // 
            // TboxNombreCliente
            // 
            this.TboxNombreCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxNombreCliente.Location = new System.Drawing.Point(149, 282);
            this.TboxNombreCliente.Name = "TboxNombreCliente";
            this.TboxNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.TboxNombreCliente.TabIndex = 4;
            this.TboxNombreCliente.Tag = "Nombre de Cliente";
            this.TboxNombreCliente.Text = "Nombre de Cliente";
            // 
            // TboxLegajoCliente
            // 
            this.TboxLegajoCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxLegajoCliente.Location = new System.Drawing.Point(43, 282);
            this.TboxLegajoCliente.Name = "TboxLegajoCliente";
            this.TboxLegajoCliente.Size = new System.Drawing.Size(100, 20);
            this.TboxLegajoCliente.TabIndex = 3;
            this.TboxLegajoCliente.Tag = "Legajo de Cliente";
            this.TboxLegajoCliente.Text = "Legajo de Cliente";
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(6, 19);
            this.DgvClientes.MultiSelect = false;
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.Size = new System.Drawing.Size(243, 257);
            this.DgvClientes.TabIndex = 0;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaClientes_CellClick);
            this.DgvClientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListaClientes_RowHeaderMouseClick);
            this.DgvClientes.MouseEnter += new System.EventHandler(this.DgvClientes_MouseEnter);
            // 
            // GrpGrilla2
            // 
            this.GrpGrilla2.Controls.Add(this.CboxTipoCobro);
            this.GrpGrilla2.Controls.Add(this.CmdPagoCobro);
            this.GrpGrilla2.Controls.Add(this.CmdAltaCobro);
            this.GrpGrilla2.Controls.Add(this.TboxImporteCobro);
            this.GrpGrilla2.Controls.Add(this.DateVencimientoCobro);
            this.GrpGrilla2.Controls.Add(this.TboxNombreCobro);
            this.GrpGrilla2.Controls.Add(this.TboxCodigoCobro);
            this.GrpGrilla2.Controls.Add(this.DgvPendientes);
            this.GrpGrilla2.Location = new System.Drawing.Point(476, 12);
            this.GrpGrilla2.Name = "GrpGrilla2";
            this.GrpGrilla2.Size = new System.Drawing.Size(738, 169);
            this.GrpGrilla2.TabIndex = 1;
            this.GrpGrilla2.TabStop = false;
            this.GrpGrilla2.Text = "Grilla 2: ABM Cobros";
            // 
            // CboxTipoCobro
            // 
            this.CboxTipoCobro.AutoSize = true;
            this.CboxTipoCobro.Enabled = false;
            this.CboxTipoCobro.Location = new System.Drawing.Point(136, 102);
            this.CboxTipoCobro.Name = "CboxTipoCobro";
            this.CboxTipoCobro.Size = new System.Drawing.Size(89, 17);
            this.CboxTipoCobro.TabIndex = 17;
            this.CboxTipoCobro.Text = "Tipo especial";
            this.CboxTipoCobro.UseVisualStyleBackColor = true;
            // 
            // CmdPagoCobro
            // 
            this.CmdPagoCobro.Enabled = false;
            this.CmdPagoCobro.Location = new System.Drawing.Point(655, 19);
            this.CmdPagoCobro.Name = "CmdPagoCobro";
            this.CmdPagoCobro.Size = new System.Drawing.Size(75, 23);
            this.CmdPagoCobro.TabIndex = 13;
            this.CmdPagoCobro.Text = "Pago";
            this.CmdPagoCobro.UseVisualStyleBackColor = true;
            this.CmdPagoCobro.Click += new System.EventHandler(this.CmdPagoCobros_Click);
            // 
            // CmdAltaCobro
            // 
            this.CmdAltaCobro.Enabled = false;
            this.CmdAltaCobro.Location = new System.Drawing.Point(655, 98);
            this.CmdAltaCobro.Name = "CmdAltaCobro";
            this.CmdAltaCobro.Size = new System.Drawing.Size(75, 23);
            this.CmdAltaCobro.TabIndex = 12;
            this.CmdAltaCobro.Text = "Alta";
            this.CmdAltaCobro.UseVisualStyleBackColor = true;
            this.CmdAltaCobro.Click += new System.EventHandler(this.CmdAltaCobro_Click);
            // 
            // TboxImporteCobro
            // 
            this.TboxImporteCobro.Enabled = false;
            this.TboxImporteCobro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxImporteCobro.Location = new System.Drawing.Point(549, 100);
            this.TboxImporteCobro.Name = "TboxImporteCobro";
            this.TboxImporteCobro.Size = new System.Drawing.Size(100, 20);
            this.TboxImporteCobro.TabIndex = 7;
            this.TboxImporteCobro.Tag = "Nombre de Cobro";
            this.TboxImporteCobro.Text = "Importe de Cobro";
            // 
            // DateVencimientoCobro
            // 
            this.DateVencimientoCobro.Enabled = false;
            this.DateVencimientoCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateVencimientoCobro.Location = new System.Drawing.Point(443, 100);
            this.DateVencimientoCobro.Name = "DateVencimientoCobro";
            this.DateVencimientoCobro.Size = new System.Drawing.Size(100, 20);
            this.DateVencimientoCobro.TabIndex = 6;
            // 
            // TboxNombreCobro
            // 
            this.TboxNombreCobro.Enabled = false;
            this.TboxNombreCobro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxNombreCobro.Location = new System.Drawing.Point(337, 100);
            this.TboxNombreCobro.Name = "TboxNombreCobro";
            this.TboxNombreCobro.Size = new System.Drawing.Size(100, 20);
            this.TboxNombreCobro.TabIndex = 5;
            this.TboxNombreCobro.Tag = "Nombre de Cobro";
            this.TboxNombreCobro.Text = "Nombre de Cobro";
            // 
            // TboxCodigoCobro
            // 
            this.TboxCodigoCobro.Enabled = false;
            this.TboxCodigoCobro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxCodigoCobro.Location = new System.Drawing.Point(231, 100);
            this.TboxCodigoCobro.Name = "TboxCodigoCobro";
            this.TboxCodigoCobro.Size = new System.Drawing.Size(100, 20);
            this.TboxCodigoCobro.TabIndex = 4;
            this.TboxCodigoCobro.Tag = "Código de Cobro";
            this.TboxCodigoCobro.Text = "Código de Cobro";
            // 
            // DgvPendientes
            // 
            this.DgvPendientes.AllowUserToAddRows = false;
            this.DgvPendientes.AllowUserToDeleteRows = false;
            this.DgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPendientes.Location = new System.Drawing.Point(6, 19);
            this.DgvPendientes.MultiSelect = false;
            this.DgvPendientes.Name = "DgvPendientes";
            this.DgvPendientes.ReadOnly = true;
            this.DgvPendientes.Size = new System.Drawing.Size(643, 75);
            this.DgvPendientes.TabIndex = 1;
            this.DgvPendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaPendientes_CellClick);
            this.DgvPendientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListaPendientes_RowHeaderMouseClick);
            this.DgvPendientes.MouseEnter += new System.EventHandler(this.DgvPendientes_MouseEnter);
            // 
            // LabelInformacion
            // 
            this.LabelInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelInformacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInformacion.ForeColor = System.Drawing.Color.Red;
            this.LabelInformacion.Location = new System.Drawing.Point(358, 12);
            this.LabelInformacion.Name = "LabelInformacion";
            this.LabelInformacion.Size = new System.Drawing.Size(112, 169);
            this.LabelInformacion.TabIndex = 14;
            this.LabelInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrpGrilla3
            // 
            this.GrpGrilla3.Controls.Add(this.DgvCanceladosG3);
            this.GrpGrilla3.Location = new System.Drawing.Point(358, 187);
            this.GrpGrilla3.Name = "GrpGrilla3";
            this.GrpGrilla3.Size = new System.Drawing.Size(856, 176);
            this.GrpGrilla3.TabIndex = 2;
            this.GrpGrilla3.TabStop = false;
            this.GrpGrilla3.Text = "Grilla 3: Cobros cancelados del cliente";
            // 
            // DgvCanceladosG3
            // 
            this.DgvCanceladosG3.AllowUserToAddRows = false;
            this.DgvCanceladosG3.AllowUserToDeleteRows = false;
            this.DgvCanceladosG3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCanceladosG3.Location = new System.Drawing.Point(6, 19);
            this.DgvCanceladosG3.MultiSelect = false;
            this.DgvCanceladosG3.Name = "DgvCanceladosG3";
            this.DgvCanceladosG3.ReadOnly = true;
            this.DgvCanceladosG3.Size = new System.Drawing.Size(843, 150);
            this.DgvCanceladosG3.TabIndex = 2;
            // 
            // GrpGrilla4
            // 
            this.GrpGrilla4.Controls.Add(this.RadioDescendente);
            this.GrpGrilla4.Controls.Add(this.RadioAscendente);
            this.GrpGrilla4.Controls.Add(this.DgvCanceladosG4);
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
            // DgvCanceladosG4
            // 
            this.DgvCanceladosG4.AllowUserToAddRows = false;
            this.DgvCanceladosG4.AllowUserToDeleteRows = false;
            this.DgvCanceladosG4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCanceladosG4.Location = new System.Drawing.Point(6, 19);
            this.DgvCanceladosG4.MultiSelect = false;
            this.DgvCanceladosG4.Name = "DgvCanceladosG4";
            this.DgvCanceladosG4.ReadOnly = true;
            this.DgvCanceladosG4.Size = new System.Drawing.Size(843, 150);
            this.DgvCanceladosG4.TabIndex = 3;
            // 
            // GrpGrilla5
            // 
            this.GrpGrilla5.Controls.Add(this.DgvCanceladosG5);
            this.GrpGrilla5.Location = new System.Drawing.Point(959, 369);
            this.GrpGrilla5.Name = "GrpGrilla5";
            this.GrpGrilla5.Size = new System.Drawing.Size(255, 177);
            this.GrpGrilla5.TabIndex = 4;
            this.GrpGrilla5.TabStop = false;
            this.GrpGrilla5.Text = "Grilla 5: Resumen de pagos del cliente";
            // 
            // DgvCanceladosG5
            // 
            this.DgvCanceladosG5.AllowUserToAddRows = false;
            this.DgvCanceladosG5.AllowUserToDeleteRows = false;
            this.DgvCanceladosG5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCanceladosG5.Location = new System.Drawing.Point(6, 19);
            this.DgvCanceladosG5.MultiSelect = false;
            this.DgvCanceladosG5.Name = "DgvCanceladosG5";
            this.DgvCanceladosG5.ReadOnly = true;
            this.DgvCanceladosG5.Size = new System.Drawing.Size(243, 150);
            this.DgvCanceladosG5.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // Tooltip
            // 
            this.Tooltip.AutomaticDelay = 50;
            this.Tooltip.AutoPopDelay = 5000;
            this.Tooltip.InitialDelay = 50;
            this.Tooltip.IsBalloon = true;
            this.Tooltip.ReshowDelay = 10;
            // 
            // CFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 556);
            this.Controls.Add(this.LabelInformacion);
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.GrpGrilla2.ResumeLayout(false);
            this.GrpGrilla2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPendientes)).EndInit();
            this.GrpGrilla3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCanceladosG3)).EndInit();
            this.GrpGrilla4.ResumeLayout(false);
            this.GrpGrilla4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCanceladosG4)).EndInit();
            this.GrpGrilla5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCanceladosG5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpGrilla1;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.GroupBox GrpGrilla2;
        private System.Windows.Forms.GroupBox GrpGrilla3;
        private System.Windows.Forms.GroupBox GrpGrilla4;
        private System.Windows.Forms.GroupBox GrpGrilla5;
        private System.Windows.Forms.Button CmdModificaCliente;
        private System.Windows.Forms.Button CmdBajaCliente;
        private System.Windows.Forms.Button CmdAltaCliente;
        private System.Windows.Forms.TextBox TboxNombreCliente;
        private System.Windows.Forms.TextBox TboxLegajoCliente;
        private System.Windows.Forms.DataGridView DgvPendientes;
        private System.Windows.Forms.Label LabelInformacion;
        private System.Windows.Forms.Button CmdPagoCobro;
        private System.Windows.Forms.Button CmdAltaCobro;
        private System.Windows.Forms.TextBox TboxImporteCobro;
        private System.Windows.Forms.DateTimePicker DateVencimientoCobro;
        private System.Windows.Forms.TextBox TboxNombreCobro;
        private System.Windows.Forms.TextBox TboxCodigoCobro;
        private System.Windows.Forms.DataGridView DgvCanceladosG3;
        private System.Windows.Forms.RadioButton RadioDescendente;
        private System.Windows.Forms.RadioButton RadioAscendente;
        private System.Windows.Forms.DataGridView DgvCanceladosG4;
        private System.Windows.Forms.DataGridView DgvCanceladosG5;
        private System.Windows.Forms.CheckBox CboxTipoCobro;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.ToolTip Tooltip;
    }
}

