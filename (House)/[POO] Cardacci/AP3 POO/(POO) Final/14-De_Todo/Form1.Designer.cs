namespace _14_De_Todo
{
    partial class Form1
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
            this.Grilla1 = new System.Windows.Forms.DataGridView();
            this.Grilla2 = new System.Windows.Forms.DataGridView();
            this.Grilla3 = new System.Windows.Forms.DataGridView();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnAgregarPais = new System.Windows.Forms.Button();
            this.rbNomAsc = new System.Windows.Forms.RadioButton();
            this.rbIdAsc = new System.Windows.Forms.RadioButton();
            this.rbGroupPais = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla3)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla1
            // 
            this.Grilla1.AllowUserToAddRows = false;
            this.Grilla1.AllowUserToDeleteRows = false;
            this.Grilla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla1.Location = new System.Drawing.Point(48, 67);
            this.Grilla1.MultiSelect = false;
            this.Grilla1.Name = "Grilla1";
            this.Grilla1.ReadOnly = true;
            this.Grilla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla1.Size = new System.Drawing.Size(240, 150);
            this.Grilla1.TabIndex = 0;
            // 
            // Grilla2
            // 
            this.Grilla2.AllowUserToAddRows = false;
            this.Grilla2.AllowUserToDeleteRows = false;
            this.Grilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla2.Location = new System.Drawing.Point(315, 67);
            this.Grilla2.MultiSelect = false;
            this.Grilla2.Name = "Grilla2";
            this.Grilla2.ReadOnly = true;
            this.Grilla2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla2.Size = new System.Drawing.Size(240, 150);
            this.Grilla2.TabIndex = 1;
            // 
            // Grilla3
            // 
            this.Grilla3.AllowUserToAddRows = false;
            this.Grilla3.AllowUserToDeleteRows = false;
            this.Grilla3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grilla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla3.Location = new System.Drawing.Point(315, 259);
            this.Grilla3.MultiSelect = false;
            this.Grilla3.Name = "Grilla3";
            this.Grilla3.ReadOnly = true;
            this.Grilla3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla3.Size = new System.Drawing.Size(240, 150);
            this.Grilla3.TabIndex = 2;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(48, 224);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 3;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnAgregarPais
            // 
            this.btnAgregarPais.Location = new System.Drawing.Point(315, 224);
            this.btnAgregarPais.Name = "btnAgregarPais";
            this.btnAgregarPais.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPais.TabIndex = 4;
            this.btnAgregarPais.Text = "Agregar";
            this.btnAgregarPais.UseVisualStyleBackColor = true;
            this.btnAgregarPais.Click += new System.EventHandler(this.btnAgregarPais_Click);
            // 
            // rbNomAsc
            // 
            this.rbNomAsc.AutoSize = true;
            this.rbNomAsc.Checked = true;
            this.rbNomAsc.Location = new System.Drawing.Point(130, 229);
            this.rbNomAsc.Name = "rbNomAsc";
            this.rbNomAsc.Size = new System.Drawing.Size(83, 17);
            this.rbNomAsc.TabIndex = 5;
            this.rbNomAsc.TabStop = true;
            this.rbNomAsc.Text = "Nombre Asc";
            this.rbNomAsc.UseVisualStyleBackColor = true;
            this.rbNomAsc.CheckedChanged += new System.EventHandler(this.rbNomAsc_CheckedChanged);
            // 
            // rbIdAsc
            // 
            this.rbIdAsc.AutoSize = true;
            this.rbIdAsc.Location = new System.Drawing.Point(130, 252);
            this.rbIdAsc.Name = "rbIdAsc";
            this.rbIdAsc.Size = new System.Drawing.Size(55, 17);
            this.rbIdAsc.TabIndex = 6;
            this.rbIdAsc.Text = "Id Asc";
            this.rbIdAsc.UseVisualStyleBackColor = true;
            this.rbIdAsc.CheckedChanged += new System.EventHandler(this.rbIdAsc_CheckedChanged);
            // 
            // rbGroupPais
            // 
            this.rbGroupPais.AutoSize = true;
            this.rbGroupPais.Location = new System.Drawing.Point(130, 275);
            this.rbGroupPais.Name = "rbGroupPais";
            this.rbGroupPais.Size = new System.Drawing.Size(103, 17);
            this.rbGroupPais.TabIndex = 7;
            this.rbGroupPais.Text = "Agrupar por Pais";
            this.rbGroupPais.UseVisualStyleBackColor = true;
            this.rbGroupPais.CheckedChanged += new System.EventHandler(this.rbGroupPais_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ver Id Sin Guion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbGroupPais);
            this.Controls.Add(this.rbIdAsc);
            this.Controls.Add(this.rbNomAsc);
            this.Controls.Add(this.btnAgregarPais);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.Grilla3);
            this.Controls.Add(this.Grilla2);
            this.Controls.Add(this.Grilla1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla1;
        private System.Windows.Forms.DataGridView Grilla2;
        private System.Windows.Forms.DataGridView Grilla3;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnAgregarPais;
        private System.Windows.Forms.RadioButton rbNomAsc;
        private System.Windows.Forms.RadioButton rbIdAsc;
        private System.Windows.Forms.RadioButton rbGroupPais;
        private System.Windows.Forms.Button button1;
    }
}

