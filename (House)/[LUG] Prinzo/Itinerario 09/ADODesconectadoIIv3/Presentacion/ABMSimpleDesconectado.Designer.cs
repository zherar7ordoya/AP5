namespace Presentacion
{
    partial class ABMSimpleDesconectado
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
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.mGrilla = new System.Windows.Forms.DataGridView();
            this.rdbPersona = new System.Windows.Forms.RadioButton();
            this.rdbAuto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(245, 326);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(192, 27);
            this.btnDescartar.TabIndex = 44;
            this.btnDescartar.Text = "Descartar cambios";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(457, 326);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(190, 27);
            this.btnCargar.TabIndex = 43;
            this.btnCargar.Text = "Cargar datos nuevamente";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.CargarGrilla_ButtonClick);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(32, 326);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(194, 27);
            this.btnGrabar.TabIndex = 42;
            this.btnGrabar.Text = "Grabar cambios en Base de datos";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // mGrilla
            // 
            this.mGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.mGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGrilla.Location = new System.Drawing.Point(32, 26);
            this.mGrilla.Name = "mGrilla";
            this.mGrilla.Size = new System.Drawing.Size(615, 255);
            this.mGrilla.TabIndex = 41;
            // 
            // rdbPersona
            // 
            this.rdbPersona.AutoSize = true;
            this.rdbPersona.Location = new System.Drawing.Point(245, 298);
            this.rdbPersona.Name = "rdbPersona";
            this.rdbPersona.Size = new System.Drawing.Size(64, 17);
            this.rdbPersona.TabIndex = 45;
            this.rdbPersona.TabStop = true;
            this.rdbPersona.Text = "Persona";
            this.rdbPersona.UseVisualStyleBackColor = true;
            // 
            // rdbAuto
            // 
            this.rdbAuto.AutoSize = true;
            this.rdbAuto.Location = new System.Drawing.Point(328, 299);
            this.rdbAuto.Name = "rdbAuto";
            this.rdbAuto.Size = new System.Drawing.Size(47, 17);
            this.rdbAuto.TabIndex = 46;
            this.rdbAuto.TabStop = true;
            this.rdbAuto.Text = "Auto";
            this.rdbAuto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Seleccione la tabla";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 27);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cargar Tabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CargarGrilla_ButtonClick);
            // 
            // ABMSimpleDesconectado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbAuto);
            this.Controls.Add(this.rdbPersona);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.mGrilla);
            this.Name = "ABMSimpleDesconectado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMSimpleDesconectado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABMSimpleDesconectado_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.mGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnDescartar;
        internal System.Windows.Forms.Button btnCargar;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.DataGridView mGrilla;
        private System.Windows.Forms.RadioButton rdbPersona;
        private System.Windows.Forms.RadioButton rdbAuto;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button button1;
    }
}