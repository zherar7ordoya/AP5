namespace Enumerable
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
            this.PersonaProductosDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductosDgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.PersonasDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaProductosDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonaProductosDgv
            // 
            this.PersonaProductosDgv.AllowUserToAddRows = false;
            this.PersonaProductosDgv.AllowUserToDeleteRows = false;
            this.PersonaProductosDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PersonaProductosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonaProductosDgv.Location = new System.Drawing.Point(12, 28);
            this.PersonaProductosDgv.Name = "PersonaProductosDgv";
            this.PersonaProductosDgv.ReadOnly = true;
            this.PersonaProductosDgv.Size = new System.Drawing.Size(240, 150);
            this.PersonaProductosDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos de Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // ProductosDgv
            // 
            this.ProductosDgv.AllowUserToAddRows = false;
            this.ProductosDgv.AllowUserToDeleteRows = false;
            this.ProductosDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ProductosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDgv.Location = new System.Drawing.Point(285, 28);
            this.ProductosDgv.Name = "ProductosDgv";
            this.ProductosDgv.ReadOnly = true;
            this.ProductosDgv.Size = new System.Drawing.Size(240, 150);
            this.ProductosDgv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Persona";
            // 
            // PersonasDgv
            // 
            this.PersonasDgv.AllowUserToAddRows = false;
            this.PersonasDgv.AllowUserToDeleteRows = false;
            this.PersonasDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PersonasDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonasDgv.Location = new System.Drawing.Point(12, 220);
            this.PersonasDgv.Name = "PersonasDgv";
            this.PersonasDgv.ReadOnly = true;
            this.PersonasDgv.Size = new System.Drawing.Size(240, 150);
            this.PersonasDgv.TabIndex = 4;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PersonasDgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductosDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonaProductosDgv);
            this.Name = "ClienteForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PersonaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonaProductosDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonaProductosDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductosDgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PersonasDgv;
    }
}

