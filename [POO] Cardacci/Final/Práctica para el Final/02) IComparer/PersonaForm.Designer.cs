namespace Comparer
{
    partial class PersonaForm
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
            this.PersonasDgv = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.EdadDescendenteRadio = new System.Windows.Forms.RadioButton();
            this.NombreDescendenteRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonasDgv
            // 
            this.PersonasDgv.AllowUserToAddRows = false;
            this.PersonasDgv.AllowUserToDeleteRows = false;
            this.PersonasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonasDgv.Location = new System.Drawing.Point(12, 12);
            this.PersonasDgv.Name = "PersonasDgv";
            this.PersonasDgv.ReadOnly = true;
            this.PersonasDgv.Size = new System.Drawing.Size(240, 150);
            this.PersonasDgv.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(258, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Nombre Ascendente";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.NombreAscendenteRadio_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(258, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Edad Ascendente";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.EdadAscendenteRadio_CheckedChanged);
            // 
            // EdadDescendenteRadio
            // 
            this.EdadDescendenteRadio.AutoSize = true;
            this.EdadDescendenteRadio.Location = new System.Drawing.Point(258, 145);
            this.EdadDescendenteRadio.Name = "EdadDescendenteRadio";
            this.EdadDescendenteRadio.Size = new System.Drawing.Size(117, 17);
            this.EdadDescendenteRadio.TabIndex = 4;
            this.EdadDescendenteRadio.Text = "Edad Descendente";
            this.EdadDescendenteRadio.UseVisualStyleBackColor = true;
            this.EdadDescendenteRadio.CheckedChanged += new System.EventHandler(this.EdadDescendenteRadio_CheckedChanged);
            // 
            // NombreDescendenteRadio
            // 
            this.NombreDescendenteRadio.AutoSize = true;
            this.NombreDescendenteRadio.Location = new System.Drawing.Point(258, 122);
            this.NombreDescendenteRadio.Name = "NombreDescendenteRadio";
            this.NombreDescendenteRadio.Size = new System.Drawing.Size(129, 17);
            this.NombreDescendenteRadio.TabIndex = 5;
            this.NombreDescendenteRadio.Text = "Nombre Descendente";
            this.NombreDescendenteRadio.UseVisualStyleBackColor = true;
            this.NombreDescendenteRadio.CheckedChanged += new System.EventHandler(this.NombreDescendenteRadio_CheckedChanged);
            // 
            // PersonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 192);
            this.Controls.Add(this.NombreDescendenteRadio);
            this.Controls.Add(this.EdadDescendenteRadio);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.PersonasDgv);
            this.Name = "PersonaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PersonaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonasDgv;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton EdadDescendenteRadio;
        private System.Windows.Forms.RadioButton NombreDescendenteRadio;
    }
}

