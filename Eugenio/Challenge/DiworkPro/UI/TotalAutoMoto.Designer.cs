namespace UI
{
    partial class TotalAutoMoto
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
            this.dgvAuto = new System.Windows.Forms.DataGridView();
            this.dgvMoto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuto
            // 
            this.dgvAuto.AllowUserToAddRows = false;
            this.dgvAuto.AllowUserToDeleteRows = false;
            this.dgvAuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuto.Location = new System.Drawing.Point(12, 124);
            this.dgvAuto.Name = "dgvAuto";
            this.dgvAuto.ReadOnly = true;
            this.dgvAuto.Size = new System.Drawing.Size(269, 41);
            this.dgvAuto.TabIndex = 0;
            // 
            // dgvMoto
            // 
            this.dgvMoto.AllowUserToAddRows = false;
            this.dgvMoto.AllowUserToDeleteRows = false;
            this.dgvMoto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoto.Location = new System.Drawing.Point(287, 124);
            this.dgvMoto.Name = "dgvMoto";
            this.dgvMoto.ReadOnly = true;
            this.dgvMoto.Size = new System.Drawing.Size(269, 41);
            this.dgvMoto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total presupuestos de autos y motos";
            // 
            // TotalAutoMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMoto);
            this.Controls.Add(this.dgvAuto);
            this.Name = "TotalAutoMoto";
            this.Text = "TotalAutoMoto";
            this.Load += new System.EventHandler(this.TotalAutoMoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuto;
        private System.Windows.Forms.DataGridView dgvMoto;
        private System.Windows.Forms.Label label1;
    }
}