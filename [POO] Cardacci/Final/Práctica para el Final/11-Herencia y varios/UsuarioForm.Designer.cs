namespace Herencia
{
    partial class UsuarioForm
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
            this.UsuariosDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosDgv
            // 
            this.UsuariosDgv.AllowUserToAddRows = false;
            this.UsuariosDgv.AllowUserToDeleteRows = false;
            this.UsuariosDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.UsuariosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDgv.Location = new System.Drawing.Point(12, 12);
            this.UsuariosDgv.MultiSelect = false;
            this.UsuariosDgv.Name = "UsuariosDgv";
            this.UsuariosDgv.ReadOnly = true;
            this.UsuariosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsuariosDgv.Size = new System.Drawing.Size(300, 150);
            this.UsuariosDgv.TabIndex = 0;
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 177);
            this.Controls.Add(this.UsuariosDgv);
            this.Name = "UsuarioForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsuariosDgv;
    }
}

