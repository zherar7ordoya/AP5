namespace UI
{
    partial class RepuestosRepetidos
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
            this.dgvRepuestoRepetido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestoRepetido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepuestoRepetido
            // 
            this.dgvRepuestoRepetido.AllowUserToAddRows = false;
            this.dgvRepuestoRepetido.AllowUserToDeleteRows = false;
            this.dgvRepuestoRepetido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRepuestoRepetido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestoRepetido.Location = new System.Drawing.Point(12, 86);
            this.dgvRepuestoRepetido.Name = "dgvRepuestoRepetido";
            this.dgvRepuestoRepetido.ReadOnly = true;
            this.dgvRepuestoRepetido.Size = new System.Drawing.Size(328, 48);
            this.dgvRepuestoRepetido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Repuesto mas repetido por marca y modelo";
            // 
            // RepuestosRepetidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRepuestoRepetido);
            this.Name = "RepuestosRepetidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepuestosRepetidos";
            this.Load += new System.EventHandler(this.RepuestosRepetidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestoRepetido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRepuestoRepetido;
        private System.Windows.Forms.Label label1;
    }
}