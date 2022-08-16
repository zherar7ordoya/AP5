namespace Tonattto_POO_2P
{
    partial class Form2
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
            this.grdPrestamosVencidos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosVencidos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPrestamosVencidos
            // 
            this.grdPrestamosVencidos.AllowUserToAddRows = false;
            this.grdPrestamosVencidos.AllowUserToDeleteRows = false;
            this.grdPrestamosVencidos.BackgroundColor = System.Drawing.Color.White;
            this.grdPrestamosVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamosVencidos.Location = new System.Drawing.Point(62, 40);
            this.grdPrestamosVencidos.Name = "grdPrestamosVencidos";
            this.grdPrestamosVencidos.ReadOnly = true;
            this.grdPrestamosVencidos.Size = new System.Drawing.Size(463, 249);
            this.grdPrestamosVencidos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(450, 295);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 359);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grdPrestamosVencidos);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosVencidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView grdPrestamosVencidos;
        private System.Windows.Forms.Button btnCerrar;
    }
}