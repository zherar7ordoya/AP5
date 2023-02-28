namespace Final_POO_Practica
{
    partial class ListaPersonasForm
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
            this.ListaPersonasDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPersonasDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaPersonasDgv
            // 
            this.ListaPersonasDgv.AllowUserToAddRows = false;
            this.ListaPersonasDgv.AllowUserToDeleteRows = false;
            this.ListaPersonasDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaPersonasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPersonasDgv.Location = new System.Drawing.Point(12, 12);
            this.ListaPersonasDgv.Name = "ListaPersonasDgv";
            this.ListaPersonasDgv.ReadOnly = true;
            this.ListaPersonasDgv.Size = new System.Drawing.Size(240, 150);
            this.ListaPersonasDgv.TabIndex = 0;
            // 
            // ListaPersonasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 204);
            this.Controls.Add(this.ListaPersonasDgv);
            this.Name = "ListaPersonasForm";
            this.Text = "Lista de Personas";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaPersonasDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaPersonasDgv;
    }
}

