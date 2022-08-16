
namespace PARCIAL_1
{
    partial class CVistaFormulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CVistaFormulario));
            this.dgvBeneficiarios = new System.Windows.Forms.DataGridView();
            this.dgvAdelantos = new System.Windows.Forms.DataGridView();
            this.dgvAdelantosPorBeneficiario = new System.Windows.Forms.DataGridView();
            this.lblBeneficiarios = new System.Windows.Forms.Label();
            this.lblAdelantos = new System.Windows.Forms.Label();
            this.lblAdelantosPorBeneficiario = new System.Windows.Forms.Label();
            this.btnAltaBeneficiario = new System.Windows.Forms.Button();
            this.btnBajaBeneficiario = new System.Windows.Forms.Button();
            this.btnModificacionBeneficiario = new System.Windows.Forms.Button();
            this.btnAltaAdelanto = new System.Windows.Forms.Button();
            this.btnBajaAdelanto = new System.Windows.Forms.Button();
            this.btnModificacionAdelanto = new System.Windows.Forms.Button();
            this.btnAsignarAdelanto = new System.Windows.Forms.Button();
            this.txtTotalAdelantos = new System.Windows.Forms.TextBox();
            this.txtTotalAdeudado = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblTotalAdelantos = new System.Windows.Forms.Label();
            this.lblTotalAdeudado = new System.Windows.Forms.Label();
            this.txtTipoBeneficiario = new System.Windows.Forms.TextBox();
            this.txtNombreBeneficiario = new System.Windows.Forms.TextBox();
            this.txtApellidoBeneficiario = new System.Windows.Forms.TextBox();
            this.txtSueldoBeneficiario = new System.Windows.Forms.TextBox();
            this.txtSaldoAdeudadoAdelanto = new System.Windows.Forms.TextBox();
            this.txtBeneficioAdelanto = new System.Windows.Forms.TextBox();
            this.txtImportePagadoAdelanto = new System.Windows.Forms.TextBox();
            this.txtImporteOtorgadoAdelanto = new System.Windows.Forms.TextBox();
            this.txtFechaCancelacionAdelanto = new System.Windows.Forms.TextBox();
            this.txtFechaOtorgamientoAdelanto = new System.Windows.Forms.TextBox();
            this.txtCodigoAdelanto = new System.Windows.Forms.MaskedTextBox();
            this.txtLegajoBeneficiario = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantosPorBeneficiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeneficiarios
            // 
            this.dgvBeneficiarios.AllowUserToAddRows = false;
            this.dgvBeneficiarios.AllowUserToDeleteRows = false;
            this.dgvBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiarios.Location = new System.Drawing.Point(12, 38);
            this.dgvBeneficiarios.MultiSelect = false;
            this.dgvBeneficiarios.Name = "dgvBeneficiarios";
            this.dgvBeneficiarios.ReadOnly = true;
            this.dgvBeneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBeneficiarios.Size = new System.Drawing.Size(545, 81);
            this.dgvBeneficiarios.TabIndex = 0;
            this.dgvBeneficiarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBeneficiarios_RowEnter);
            // 
            // dgvAdelantos
            // 
            this.dgvAdelantos.AllowUserToAddRows = false;
            this.dgvAdelantos.AllowUserToDeleteRows = false;
            this.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantos.Location = new System.Drawing.Point(12, 206);
            this.dgvAdelantos.MultiSelect = false;
            this.dgvAdelantos.Name = "dgvAdelantos";
            this.dgvAdelantos.ReadOnly = true;
            this.dgvAdelantos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdelantos.Size = new System.Drawing.Size(745, 110);
            this.dgvAdelantos.TabIndex = 23;
            // 
            // dgvAdelantosPorBeneficiario
            // 
            this.dgvAdelantosPorBeneficiario.AllowUserToAddRows = false;
            this.dgvAdelantosPorBeneficiario.AllowUserToDeleteRows = false;
            this.dgvAdelantosPorBeneficiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantosPorBeneficiario.Location = new System.Drawing.Point(12, 403);
            this.dgvAdelantosPorBeneficiario.MultiSelect = false;
            this.dgvAdelantosPorBeneficiario.Name = "dgvAdelantosPorBeneficiario";
            this.dgvAdelantosPorBeneficiario.ReadOnly = true;
            this.dgvAdelantosPorBeneficiario.Size = new System.Drawing.Size(745, 159);
            this.dgvAdelantosPorBeneficiario.TabIndex = 24;
            this.dgvAdelantosPorBeneficiario.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAdelantosPorBeneficiario_RowsAdded);
            // 
            // lblBeneficiarios
            // 
            this.lblBeneficiarios.AutoSize = true;
            this.lblBeneficiarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiarios.Location = new System.Drawing.Point(7, 9);
            this.lblBeneficiarios.Name = "lblBeneficiarios";
            this.lblBeneficiarios.Size = new System.Drawing.Size(236, 26);
            this.lblBeneficiarios.TabIndex = 3;
            this.lblBeneficiarios.Text = "Todos los Beneficiarios";
            // 
            // lblAdelantos
            // 
            this.lblAdelantos.AutoSize = true;
            this.lblAdelantos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdelantos.Location = new System.Drawing.Point(7, 177);
            this.lblAdelantos.Name = "lblAdelantos";
            this.lblAdelantos.Size = new System.Drawing.Size(208, 26);
            this.lblAdelantos.TabIndex = 4;
            this.lblAdelantos.Text = "Todos los Adelantos";
            // 
            // lblAdelantosPorBeneficiario
            // 
            this.lblAdelantosPorBeneficiario.AutoSize = true;
            this.lblAdelantosPorBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdelantosPorBeneficiario.Location = new System.Drawing.Point(7, 374);
            this.lblAdelantosPorBeneficiario.Name = "lblAdelantosPorBeneficiario";
            this.lblAdelantosPorBeneficiario.Size = new System.Drawing.Size(266, 26);
            this.lblAdelantosPorBeneficiario.TabIndex = 5;
            this.lblAdelantosPorBeneficiario.Text = "Adelantos por Beneficiario";
            // 
            // btnAltaBeneficiario
            // 
            this.btnAltaBeneficiario.Location = new System.Drawing.Point(563, 38);
            this.btnAltaBeneficiario.Name = "btnAltaBeneficiario";
            this.btnAltaBeneficiario.Size = new System.Drawing.Size(194, 23);
            this.btnAltaBeneficiario.TabIndex = 6;
            this.btnAltaBeneficiario.Text = "Alta de Beneficiario";
            this.btnAltaBeneficiario.UseVisualStyleBackColor = true;
            this.btnAltaBeneficiario.Click += new System.EventHandler(this.btnAltaBeneficiario_Click);
            // 
            // btnBajaBeneficiario
            // 
            this.btnBajaBeneficiario.Location = new System.Drawing.Point(563, 67);
            this.btnBajaBeneficiario.Name = "btnBajaBeneficiario";
            this.btnBajaBeneficiario.Size = new System.Drawing.Size(194, 23);
            this.btnBajaBeneficiario.TabIndex = 7;
            this.btnBajaBeneficiario.Text = "Baja de Beneficiario";
            this.btnBajaBeneficiario.UseVisualStyleBackColor = true;
            this.btnBajaBeneficiario.Click += new System.EventHandler(this.btnBajaBeneficiario_Click);
            // 
            // btnModificacionBeneficiario
            // 
            this.btnModificacionBeneficiario.Location = new System.Drawing.Point(563, 96);
            this.btnModificacionBeneficiario.Name = "btnModificacionBeneficiario";
            this.btnModificacionBeneficiario.Size = new System.Drawing.Size(194, 23);
            this.btnModificacionBeneficiario.TabIndex = 8;
            this.btnModificacionBeneficiario.Text = "Modificación de Beneficiario";
            this.btnModificacionBeneficiario.UseVisualStyleBackColor = true;
            this.btnModificacionBeneficiario.Click += new System.EventHandler(this.btnModificacionBeneficiario_Click);
            // 
            // btnAltaAdelanto
            // 
            this.btnAltaAdelanto.Location = new System.Drawing.Point(763, 206);
            this.btnAltaAdelanto.Name = "btnAltaAdelanto";
            this.btnAltaAdelanto.Size = new System.Drawing.Size(100, 23);
            this.btnAltaAdelanto.TabIndex = 16;
            this.btnAltaAdelanto.Text = "Alta";
            this.btnAltaAdelanto.UseVisualStyleBackColor = true;
            this.btnAltaAdelanto.Click += new System.EventHandler(this.btnAltaAdelanto_Click);
            // 
            // btnBajaAdelanto
            // 
            this.btnBajaAdelanto.Location = new System.Drawing.Point(763, 235);
            this.btnBajaAdelanto.Name = "btnBajaAdelanto";
            this.btnBajaAdelanto.Size = new System.Drawing.Size(100, 23);
            this.btnBajaAdelanto.TabIndex = 17;
            this.btnBajaAdelanto.Text = "Baja";
            this.btnBajaAdelanto.UseVisualStyleBackColor = true;
            this.btnBajaAdelanto.Click += new System.EventHandler(this.btnBajaAdelanto_Click);
            // 
            // btnModificacionAdelanto
            // 
            this.btnModificacionAdelanto.Location = new System.Drawing.Point(763, 264);
            this.btnModificacionAdelanto.Name = "btnModificacionAdelanto";
            this.btnModificacionAdelanto.Size = new System.Drawing.Size(100, 23);
            this.btnModificacionAdelanto.TabIndex = 18;
            this.btnModificacionAdelanto.Text = "Modificación";
            this.btnModificacionAdelanto.UseVisualStyleBackColor = true;
            this.btnModificacionAdelanto.Click += new System.EventHandler(this.btnModificacionAdelanto_Click);
            // 
            // btnAsignarAdelanto
            // 
            this.btnAsignarAdelanto.Location = new System.Drawing.Point(763, 293);
            this.btnAsignarAdelanto.Name = "btnAsignarAdelanto";
            this.btnAsignarAdelanto.Size = new System.Drawing.Size(100, 23);
            this.btnAsignarAdelanto.TabIndex = 19;
            this.btnAsignarAdelanto.Text = "Asignar";
            this.btnAsignarAdelanto.UseVisualStyleBackColor = true;
            this.btnAsignarAdelanto.Click += new System.EventHandler(this.btnAsignarAdelanto_Click);
            // 
            // txtTotalAdelantos
            // 
            this.txtTotalAdelantos.Location = new System.Drawing.Point(763, 419);
            this.txtTotalAdelantos.Name = "txtTotalAdelantos";
            this.txtTotalAdelantos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAdelantos.TabIndex = 20;
            // 
            // txtTotalAdeudado
            // 
            this.txtTotalAdeudado.Location = new System.Drawing.Point(763, 484);
            this.txtTotalAdeudado.Name = "txtTotalAdeudado";
            this.txtTotalAdeudado.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAdeudado.TabIndex = 21;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(763, 539);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(100, 23);
            this.btnPagar.TabIndex = 22;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblTotalAdelantos
            // 
            this.lblTotalAdelantos.AutoSize = true;
            this.lblTotalAdelantos.Location = new System.Drawing.Point(763, 403);
            this.lblTotalAdelantos.Name = "lblTotalAdelantos";
            this.lblTotalAdelantos.Size = new System.Drawing.Size(80, 13);
            this.lblTotalAdelantos.TabIndex = 17;
            this.lblTotalAdelantos.Text = "Total adelantos";
            // 
            // lblTotalAdeudado
            // 
            this.lblTotalAdeudado.AutoSize = true;
            this.lblTotalAdeudado.Location = new System.Drawing.Point(763, 468);
            this.lblTotalAdeudado.Name = "lblTotalAdeudado";
            this.lblTotalAdeudado.Size = new System.Drawing.Size(82, 13);
            this.lblTotalAdeudado.TabIndex = 18;
            this.lblTotalAdeudado.Text = "Total adeudado";
            // 
            // txtTipoBeneficiario
            // 
            this.txtTipoBeneficiario.Location = new System.Drawing.Point(139, 125);
            this.txtTipoBeneficiario.Name = "txtTipoBeneficiario";
            this.txtTipoBeneficiario.Size = new System.Drawing.Size(100, 20);
            this.txtTipoBeneficiario.TabIndex = 2;
            this.txtTipoBeneficiario.Tag = "Tipo";
            this.txtTipoBeneficiario.Text = "Tipo";
            // 
            // txtNombreBeneficiario
            // 
            this.txtNombreBeneficiario.Location = new System.Drawing.Point(245, 125);
            this.txtNombreBeneficiario.Name = "txtNombreBeneficiario";
            this.txtNombreBeneficiario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreBeneficiario.TabIndex = 3;
            this.txtNombreBeneficiario.Tag = "Nombre";
            this.txtNombreBeneficiario.Text = "Nombre";
            this.txtNombreBeneficiario.TextChanged += new System.EventHandler(this.txtNombreBeneficiario_TextChanged);
            // 
            // txtApellidoBeneficiario
            // 
            this.txtApellidoBeneficiario.Location = new System.Drawing.Point(351, 125);
            this.txtApellidoBeneficiario.Name = "txtApellidoBeneficiario";
            this.txtApellidoBeneficiario.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoBeneficiario.TabIndex = 4;
            this.txtApellidoBeneficiario.Tag = "Apellido";
            this.txtApellidoBeneficiario.Text = "Apellido";
            // 
            // txtSueldoBeneficiario
            // 
            this.txtSueldoBeneficiario.Location = new System.Drawing.Point(457, 125);
            this.txtSueldoBeneficiario.Name = "txtSueldoBeneficiario";
            this.txtSueldoBeneficiario.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoBeneficiario.TabIndex = 5;
            this.txtSueldoBeneficiario.Tag = "Sueldo";
            this.txtSueldoBeneficiario.Text = "Sueldo";
            // 
            // txtSaldoAdeudadoAdelanto
            // 
            this.txtSaldoAdeudadoAdelanto.Location = new System.Drawing.Point(657, 322);
            this.txtSaldoAdeudadoAdelanto.Name = "txtSaldoAdeudadoAdelanto";
            this.txtSaldoAdeudadoAdelanto.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoAdeudadoAdelanto.TabIndex = 15;
            this.txtSaldoAdeudadoAdelanto.Tag = "Saldo adeudado";
            this.txtSaldoAdeudadoAdelanto.Text = "Saldo adeudado";
            // 
            // txtBeneficioAdelanto
            // 
            this.txtBeneficioAdelanto.Location = new System.Drawing.Point(551, 322);
            this.txtBeneficioAdelanto.Name = "txtBeneficioAdelanto";
            this.txtBeneficioAdelanto.Size = new System.Drawing.Size(100, 20);
            this.txtBeneficioAdelanto.TabIndex = 14;
            this.txtBeneficioAdelanto.Tag = "Beneficio";
            this.txtBeneficioAdelanto.Text = "Beneficio";
            // 
            // txtImportePagadoAdelanto
            // 
            this.txtImportePagadoAdelanto.Location = new System.Drawing.Point(445, 322);
            this.txtImportePagadoAdelanto.Name = "txtImportePagadoAdelanto";
            this.txtImportePagadoAdelanto.Size = new System.Drawing.Size(100, 20);
            this.txtImportePagadoAdelanto.TabIndex = 13;
            this.txtImportePagadoAdelanto.Tag = "Importe pagado";
            this.txtImportePagadoAdelanto.Text = "Importe pagado";
            // 
            // txtImporteOtorgadoAdelanto
            // 
            this.txtImporteOtorgadoAdelanto.Location = new System.Drawing.Point(339, 322);
            this.txtImporteOtorgadoAdelanto.Name = "txtImporteOtorgadoAdelanto";
            this.txtImporteOtorgadoAdelanto.Size = new System.Drawing.Size(100, 20);
            this.txtImporteOtorgadoAdelanto.TabIndex = 12;
            this.txtImporteOtorgadoAdelanto.Tag = "Importe otorgado";
            this.txtImporteOtorgadoAdelanto.Text = "Importe otorgado";
            // 
            // txtFechaCancelacionAdelanto
            // 
            this.txtFechaCancelacionAdelanto.Location = new System.Drawing.Point(233, 322);
            this.txtFechaCancelacionAdelanto.Name = "txtFechaCancelacionAdelanto";
            this.txtFechaCancelacionAdelanto.Size = new System.Drawing.Size(100, 20);
            this.txtFechaCancelacionAdelanto.TabIndex = 11;
            this.txtFechaCancelacionAdelanto.Tag = "Fecha cancelación";
            this.txtFechaCancelacionAdelanto.Text = "Fecha cancelación";
            // 
            // txtFechaOtorgamientoAdelanto
            // 
            this.txtFechaOtorgamientoAdelanto.Location = new System.Drawing.Point(127, 322);
            this.txtFechaOtorgamientoAdelanto.Name = "txtFechaOtorgamientoAdelanto";
            this.txtFechaOtorgamientoAdelanto.Size = new System.Drawing.Size(100, 20);
            this.txtFechaOtorgamientoAdelanto.TabIndex = 10;
            this.txtFechaOtorgamientoAdelanto.Tag = "Fecha otorgamiento";
            this.txtFechaOtorgamientoAdelanto.Text = "Fecha otorgamiento";
            // 
            // txtCodigoAdelanto
            // 
            this.txtCodigoAdelanto.Location = new System.Drawing.Point(21, 322);
            this.txtCodigoAdelanto.Mask = "0000LLLL";
            this.txtCodigoAdelanto.Name = "txtCodigoAdelanto";
            this.txtCodigoAdelanto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoAdelanto.TabIndex = 9;
            this.txtCodigoAdelanto.Tag = "";
            // 
            // txtLegajoBeneficiario
            // 
            this.txtLegajoBeneficiario.Location = new System.Drawing.Point(33, 125);
            this.txtLegajoBeneficiario.Mask = "0000";
            this.txtLegajoBeneficiario.Name = "txtLegajoBeneficiario";
            this.txtLegajoBeneficiario.Size = new System.Drawing.Size(100, 20);
            this.txtLegajoBeneficiario.TabIndex = 1;
            this.txtLegajoBeneficiario.Tag = "";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CVistaFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 580);
            this.Controls.Add(this.txtLegajoBeneficiario);
            this.Controls.Add(this.txtCodigoAdelanto);
            this.Controls.Add(this.txtFechaOtorgamientoAdelanto);
            this.Controls.Add(this.txtFechaCancelacionAdelanto);
            this.Controls.Add(this.txtImporteOtorgadoAdelanto);
            this.Controls.Add(this.txtImportePagadoAdelanto);
            this.Controls.Add(this.txtBeneficioAdelanto);
            this.Controls.Add(this.txtSaldoAdeudadoAdelanto);
            this.Controls.Add(this.txtSueldoBeneficiario);
            this.Controls.Add(this.txtApellidoBeneficiario);
            this.Controls.Add(this.txtNombreBeneficiario);
            this.Controls.Add(this.txtTipoBeneficiario);
            this.Controls.Add(this.lblTotalAdeudado);
            this.Controls.Add(this.lblTotalAdelantos);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtTotalAdeudado);
            this.Controls.Add(this.txtTotalAdelantos);
            this.Controls.Add(this.btnAsignarAdelanto);
            this.Controls.Add(this.btnModificacionAdelanto);
            this.Controls.Add(this.btnBajaAdelanto);
            this.Controls.Add(this.btnAltaAdelanto);
            this.Controls.Add(this.btnModificacionBeneficiario);
            this.Controls.Add(this.btnBajaBeneficiario);
            this.Controls.Add(this.btnAltaBeneficiario);
            this.Controls.Add(this.lblAdelantosPorBeneficiario);
            this.Controls.Add(this.lblAdelantos);
            this.Controls.Add(this.lblBeneficiarios);
            this.Controls.Add(this.dgvAdelantosPorBeneficiario);
            this.Controls.Add(this.dgvAdelantos);
            this.Controls.Add(this.dgvBeneficiarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CVistaFormulario";
            this.Text = "Administrador de Adelantos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CAdministradorDeAdelantos_FormClosing);
            this.Load += new System.EventHandler(this.CVistaFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantosPorBeneficiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficiarios;
        private System.Windows.Forms.DataGridView dgvAdelantos;
        private System.Windows.Forms.DataGridView dgvAdelantosPorBeneficiario;
        private System.Windows.Forms.Label lblBeneficiarios;
        private System.Windows.Forms.Label lblAdelantos;
        private System.Windows.Forms.Label lblAdelantosPorBeneficiario;
        private System.Windows.Forms.Button btnAltaBeneficiario;
        private System.Windows.Forms.Button btnBajaBeneficiario;
        private System.Windows.Forms.Button btnModificacionBeneficiario;
        private System.Windows.Forms.Button btnAltaAdelanto;
        private System.Windows.Forms.Button btnBajaAdelanto;
        private System.Windows.Forms.Button btnModificacionAdelanto;
        private System.Windows.Forms.Button btnAsignarAdelanto;
        private System.Windows.Forms.TextBox txtTotalAdelantos;
        private System.Windows.Forms.TextBox txtTotalAdeudado;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblTotalAdelantos;
        private System.Windows.Forms.Label lblTotalAdeudado;
        private System.Windows.Forms.TextBox txtTipoBeneficiario;
        private System.Windows.Forms.TextBox txtNombreBeneficiario;
        private System.Windows.Forms.TextBox txtApellidoBeneficiario;
        private System.Windows.Forms.TextBox txtSueldoBeneficiario;
        private System.Windows.Forms.TextBox txtSaldoAdeudadoAdelanto;
        private System.Windows.Forms.TextBox txtBeneficioAdelanto;
        private System.Windows.Forms.TextBox txtImportePagadoAdelanto;
        private System.Windows.Forms.TextBox txtImporteOtorgadoAdelanto;
        private System.Windows.Forms.TextBox txtFechaCancelacionAdelanto;
        private System.Windows.Forms.TextBox txtFechaOtorgamientoAdelanto;
        private System.Windows.Forms.MaskedTextBox txtCodigoAdelanto;
        private System.Windows.Forms.MaskedTextBox txtLegajoBeneficiario;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

