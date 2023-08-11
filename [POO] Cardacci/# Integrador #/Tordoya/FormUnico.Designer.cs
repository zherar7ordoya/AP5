
namespace Integrador
{
    partial class FormUnico
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.Personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxPersonas = new System.Windows.Forms.GroupBox();
            this.btnModificacionPersona = new System.Windows.Forms.Button();
            this.btnBajaPersona = new System.Windows.Forms.Button();
            this.btnAltaPersona = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.gbxAutos = new System.Windows.Forms.GroupBox();
            this.btnModificacionAuto = new System.Windows.Forms.Button();
            this.btnBajaAuto = new System.Windows.Forms.Button();
            this.btnAltaAuto = new System.Windows.Forms.Button();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.Autos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAutosDePersona = new System.Windows.Forms.DataGridView();
            this.AutosDePersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvDatosDeAuto = new System.Windows.Forms.DataGridView();
            this.DatosDeAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.gbxPersonas.SuspendLayout();
            this.gbxAutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDePersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDeAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personas,
            this.DNI});
            this.dgvPersonas.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(143, 286);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.SelectionChanged += new System.EventHandler(this.dgvPersonas_SelectionChanged);
            // 
            // Personas
            // 
            this.Personas.HeaderText = "Personas";
            this.Personas.Name = "Personas";
            // 
            // gbxPersonas
            // 
            this.gbxPersonas.Controls.Add(this.btnModificacionPersona);
            this.gbxPersonas.Controls.Add(this.btnBajaPersona);
            this.gbxPersonas.Controls.Add(this.btnAltaPersona);
            this.gbxPersonas.Location = new System.Drawing.Point(12, 304);
            this.gbxPersonas.Name = "gbxPersonas";
            this.gbxPersonas.Size = new System.Drawing.Size(143, 55);
            this.gbxPersonas.TabIndex = 1;
            this.gbxPersonas.TabStop = false;
            this.gbxPersonas.Text = "ABM";
            // 
            // btnModificacionPersona
            // 
            this.btnModificacionPersona.Location = new System.Drawing.Point(90, 20);
            this.btnModificacionPersona.Name = "btnModificacionPersona";
            this.btnModificacionPersona.Size = new System.Drawing.Size(23, 23);
            this.btnModificacionPersona.TabIndex = 2;
            this.btnModificacionPersona.Text = "M";
            this.btnModificacionPersona.UseVisualStyleBackColor = true;
            this.btnModificacionPersona.Click += new System.EventHandler(this.btnModificacionPersona_Click);
            // 
            // btnBajaPersona
            // 
            this.btnBajaPersona.Location = new System.Drawing.Point(60, 20);
            this.btnBajaPersona.Name = "btnBajaPersona";
            this.btnBajaPersona.Size = new System.Drawing.Size(23, 23);
            this.btnBajaPersona.TabIndex = 1;
            this.btnBajaPersona.Text = "B";
            this.btnBajaPersona.UseVisualStyleBackColor = true;
            this.btnBajaPersona.Click += new System.EventHandler(this.btnBajaPersona_Click);
            // 
            // btnAltaPersona
            // 
            this.btnAltaPersona.Location = new System.Drawing.Point(30, 20);
            this.btnAltaPersona.Name = "btnAltaPersona";
            this.btnAltaPersona.Size = new System.Drawing.Size(23, 23);
            this.btnAltaPersona.TabIndex = 0;
            this.btnAltaPersona.Text = "A";
            this.btnAltaPersona.UseVisualStyleBackColor = true;
            this.btnAltaPersona.Click += new System.EventHandler(this.btnAltaPersona_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(12, 365);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(292, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar Auto a Persona";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // gbxAutos
            // 
            this.gbxAutos.Controls.Add(this.btnModificacionAuto);
            this.gbxAutos.Controls.Add(this.btnBajaAuto);
            this.gbxAutos.Controls.Add(this.btnAltaAuto);
            this.gbxAutos.Location = new System.Drawing.Point(161, 304);
            this.gbxAutos.Name = "gbxAutos";
            this.gbxAutos.Size = new System.Drawing.Size(143, 55);
            this.gbxAutos.TabIndex = 6;
            this.gbxAutos.TabStop = false;
            this.gbxAutos.Text = "ABM";
            // 
            // btnModificacionAuto
            // 
            this.btnModificacionAuto.Location = new System.Drawing.Point(90, 20);
            this.btnModificacionAuto.Name = "btnModificacionAuto";
            this.btnModificacionAuto.Size = new System.Drawing.Size(23, 23);
            this.btnModificacionAuto.TabIndex = 2;
            this.btnModificacionAuto.Text = "M";
            this.btnModificacionAuto.UseVisualStyleBackColor = true;
            this.btnModificacionAuto.Click += new System.EventHandler(this.btnModificacionAuto_Click);
            // 
            // btnBajaAuto
            // 
            this.btnBajaAuto.Location = new System.Drawing.Point(60, 20);
            this.btnBajaAuto.Name = "btnBajaAuto";
            this.btnBajaAuto.Size = new System.Drawing.Size(23, 23);
            this.btnBajaAuto.TabIndex = 1;
            this.btnBajaAuto.Text = "B";
            this.btnBajaAuto.UseVisualStyleBackColor = true;
            this.btnBajaAuto.Click += new System.EventHandler(this.btnBajaAuto_Click);
            // 
            // btnAltaAuto
            // 
            this.btnAltaAuto.Location = new System.Drawing.Point(30, 20);
            this.btnAltaAuto.Name = "btnAltaAuto";
            this.btnAltaAuto.Size = new System.Drawing.Size(23, 23);
            this.btnAltaAuto.TabIndex = 0;
            this.btnAltaAuto.Text = "A";
            this.btnAltaAuto.UseVisualStyleBackColor = true;
            this.btnAltaAuto.Click += new System.EventHandler(this.btnAltaAuto_Click);
            // 
            // dgvAutos
            // 
            this.dgvAutos.AllowUserToAddRows = false;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Autos,
            this.Patente});
            this.dgvAutos.Location = new System.Drawing.Point(161, 12);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.Size = new System.Drawing.Size(143, 286);
            this.dgvAutos.TabIndex = 5;
            this.dgvAutos.SelectionChanged += new System.EventHandler(this.dgvAutos_SelectionChanged);
            // 
            // Autos
            // 
            this.Autos.HeaderText = "Autos";
            this.Autos.Name = "Autos";
            // 
            // dgvAutosDePersona
            // 
            this.dgvAutosDePersona.AllowUserToAddRows = false;
            this.dgvAutosDePersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutosDePersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AutosDePersona,
            this.Precio});
            this.dgvAutosDePersona.Location = new System.Drawing.Point(310, 12);
            this.dgvAutosDePersona.Name = "dgvAutosDePersona";
            this.dgvAutosDePersona.Size = new System.Drawing.Size(143, 286);
            this.dgvAutosDePersona.TabIndex = 7;
            // 
            // AutosDePersona
            // 
            this.AutosDePersona.HeaderText = "Autos de Persona";
            this.AutosDePersona.Name = "AutosDePersona";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(377, 304);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Precio Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvDatosDeAuto
            // 
            this.dgvDatosDeAuto.AllowUserToAddRows = false;
            this.dgvDatosDeAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosDeAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatosDeAuto});
            this.dgvDatosDeAuto.Location = new System.Drawing.Point(459, 12);
            this.dgvDatosDeAuto.Name = "dgvDatosDeAuto";
            this.dgvDatosDeAuto.Size = new System.Drawing.Size(143, 286);
            this.dgvDatosDeAuto.TabIndex = 9;
            // 
            // DatosDeAuto
            // 
            this.DatosDeAuto.HeaderText = "Datos de Auto";
            this.DatosDeAuto.Name = "DatosDeAuto";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Patente
            // 
            this.Patente.HeaderText = "Patente";
            this.Patente.Name = "Patente";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // FormUnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 400);
            this.Controls.Add(this.dgvDatosDeAuto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvAutosDePersona);
            this.Controls.Add(this.gbxAutos);
            this.Controls.Add(this.dgvAutos);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.gbxPersonas);
            this.Controls.Add(this.dgvPersonas);
            this.Name = "FormUnico";
            this.Text = "Integrador I";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUnico_FormClosing);
            this.Load += new System.EventHandler(this.FormUnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.gbxPersonas.ResumeLayout(false);
            this.gbxAutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutosDePersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDeAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.GroupBox gbxPersonas;
        private System.Windows.Forms.Button btnModificacionPersona;
        private System.Windows.Forms.Button btnBajaPersona;
        private System.Windows.Forms.Button btnAltaPersona;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.GroupBox gbxAutos;
        private System.Windows.Forms.Button btnModificacionAuto;
        private System.Windows.Forms.Button btnBajaAuto;
        private System.Windows.Forms.Button btnAltaAuto;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.DataGridView dgvAutosDePersona;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvDatosDeAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autos;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutosDePersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosDeAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}

