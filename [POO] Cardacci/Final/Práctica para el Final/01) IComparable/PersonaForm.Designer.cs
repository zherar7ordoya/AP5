namespace Comparable
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
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonasDgv
            // 
            this.PersonasDgv.AllowUserToAddRows = false;
            this.PersonasDgv.AllowUserToDeleteRows = false;
            this.PersonasDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PersonasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonasDgv.Location = new System.Drawing.Point(12, 12);
            this.PersonasDgv.Name = "PersonasDgv";
            this.PersonasDgv.ReadOnly = true;
            this.PersonasDgv.Size = new System.Drawing.Size(240, 150);
            this.PersonasDgv.TabIndex = 0;
            // 
            // PersonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 204);
            this.Controls.Add(this.PersonasDgv);
            this.Name = "PersonaForm";
            this.Text = "Lista de Personas";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonasDgv;
    }
}

