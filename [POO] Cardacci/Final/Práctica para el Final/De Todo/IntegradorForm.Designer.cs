namespace Integrador
{
    partial class IntegradorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.btnModPersona = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Grilla2 = new System.Windows.Forms.DataGridView();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.btnPatente = new System.Windows.Forms.Button();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbViejos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAutosNuevos = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grilla1
            // 
            this.Grilla1.AllowUserToAddRows = false;
            this.Grilla1.AllowUserToDeleteRows = false;
            this.Grilla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla1.Location = new System.Drawing.Point(26, 42);
            this.Grilla1.MultiSelect = false;
            this.Grilla1.Name = "Grilla1";
            this.Grilla1.ReadOnly = true;
            this.Grilla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla1.Size = new System.Drawing.Size(318, 150);
            this.Grilla1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personas";
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(26, 211);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPersona.TabIndex = 2;
            this.btnAgregarPersona.Text = "Agregar";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(121, 237);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(88, 17);
            this.RB2.TabIndex = 3;
            this.RB2.Text = "Nombre desc";
            this.RB2.UseVisualStyleBackColor = true;
            this.RB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Checked = true;
            this.RB1.Location = new System.Drawing.Point(121, 214);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(83, 17);
            this.RB1.TabIndex = 4;
            this.RB1.TabStop = true;
            this.RB1.Text = "Nombre Asc";
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(121, 260);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(71, 17);
            this.RB3.TabIndex = 5;
            this.RB3.Text = "Edad Asc";
            this.RB3.UseVisualStyleBackColor = true;
            this.RB3.CheckedChanged += new System.EventHandler(this.RB3_CheckedChanged);
            // 
            // btnModPersona
            // 
            this.btnModPersona.Location = new System.Drawing.Point(215, 214);
            this.btnModPersona.Name = "btnModPersona";
            this.btnModPersona.Size = new System.Drawing.Size(75, 23);
            this.btnModPersona.TabIndex = 6;
            this.btnModPersona.Text = "Modificar";
            this.btnModPersona.UseVisualStyleBackColor = true;
            this.btnModPersona.Click += new System.EventHandler(this.btnModPersona_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Autos";
            // 
            // Grilla2
            // 
            this.Grilla2.AllowUserToAddRows = false;
            this.Grilla2.AllowUserToDeleteRows = false;
            this.Grilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla2.Location = new System.Drawing.Point(450, 42);
            this.Grilla2.MultiSelect = false;
            this.Grilla2.Name = "Grilla2";
            this.Grilla2.ReadOnly = true;
            this.Grilla2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grilla2.Size = new System.Drawing.Size(318, 150);
            this.Grilla2.TabIndex = 7;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(453, 208);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAuto.TabIndex = 9;
            this.btnAgregarAuto.Text = "Agregar ";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // btnPatente
            // 
            this.btnPatente.Location = new System.Drawing.Point(554, 208);
            this.btnPatente.Name = "btnPatente";
            this.btnPatente.Size = new System.Drawing.Size(198, 23);
            this.btnPatente.TabIndex = 10;
            this.btnPatente.Text = "Mostrar Patente por Partes";
            this.btnPatente.UseVisualStyleBackColor = true;
            this.btnPatente.Click += new System.EventHandler(this.btnPatente_Click);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(22, 19);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(101, 17);
            this.rbTodos.TabIndex = 11;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los Autos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbViejos
            // 
            this.rbViejos.AutoSize = true;
            this.rbViejos.Location = new System.Drawing.Point(22, 42);
            this.rbViejos.Name = "rbViejos";
            this.rbViejos.Size = new System.Drawing.Size(140, 17);
            this.rbViejos.TabIndex = 12;
            this.rbViejos.Text = "Autos Anteriores al 2000";
            this.rbViejos.UseVisualStyleBackColor = true;
            this.rbViejos.CheckedChanged += new System.EventHandler(this.rbViejos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAutosNuevos);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.rbViejos);
            this.groupBox1.Location = new System.Drawing.Point(437, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 93);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rbAutosNuevos
            // 
            this.rbAutosNuevos.AutoSize = true;
            this.rbAutosNuevos.Location = new System.Drawing.Point(142, 19);
            this.rbAutosNuevos.Name = "rbAutosNuevos";
            this.rbAutosNuevos.Size = new System.Drawing.Size(92, 17);
            this.rbAutosNuevos.TabIndex = 16;
            this.rbAutosNuevos.Text = "Autos Nuevos";
            this.rbAutosNuevos.UseVisualStyleBackColor = true;
            this.rbAutosNuevos.CheckedChanged += new System.EventHandler(this.rbAutosNuevos_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.Text = "Mostrar Autos y Titulares";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Func";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPatente);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grilla2);
            this.Controls.Add(this.btnModPersona);
            this.Controls.Add(this.RB3);
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.Button btnModPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grilla2;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Button btnPatente;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbViejos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbAutosNuevos;
        private System.Windows.Forms.Button button1;
    }
}

