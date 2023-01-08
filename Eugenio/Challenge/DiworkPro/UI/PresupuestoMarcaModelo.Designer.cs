namespace UI
{
    partial class PresupuestoMarcaModelo
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
            this.dgvPresupestos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPresupestos
            // 
            this.dgvPresupestos.AllowUserToAddRows = false;
            this.dgvPresupestos.AllowUserToDeleteRows = false;
            this.dgvPresupestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresupestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupestos.Location = new System.Drawing.Point(40, 102);
            this.dgvPresupestos.Name = "dgvPresupestos";
            this.dgvPresupestos.ReadOnly = true;
            this.dgvPresupestos.Size = new System.Drawing.Size(305, 289);
            this.dgvPresupestos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Presupuesto por Marca y Modelo";
            // 
            // PresupuestoMarcaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPresupestos);
            this.Name = "PresupuestoMarcaModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PresupuestoMarcaModelo";
            this.Load += new System.EventHandler(this.PresupuestoMarcaModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPresupestos;
        private System.Windows.Forms.Label label1;
    }
}