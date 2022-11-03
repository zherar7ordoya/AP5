namespace UIL
{
    partial class ProductoForm
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
            this.ProductosDGV = new System.Windows.Forms.DataGridView();
            this.ConteoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.ProductosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDGV.Location = new System.Drawing.Point(12, 12);
            this.ProductosDGV.Name = "dataGridView1";
            this.ProductosDGV.Size = new System.Drawing.Size(480, 300);
            this.ProductosDGV.TabIndex = 7;
            // 
            // lblTotalRecords
            // 
            this.ConteoLabel.AutoSize = true;
            this.ConteoLabel.Location = new System.Drawing.Point(12, 315);
            this.ConteoLabel.Name = "lblTotalRecords";
            this.ConteoLabel.Size = new System.Drawing.Size(83, 13);
            this.ConteoLabel.TabIndex = 8;
            this.ConteoLabel.Text = "Total Records >";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 355);
            this.Controls.Add(this.ConteoLabel);
            this.Controls.Add(this.ProductosDGV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProductoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductosDGV;
        private System.Windows.Forms.Label ConteoLabel;
    }
}

