namespace Activity10_2
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
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnGetData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStores
            // 
            this.dgvStores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Location = new System.Drawing.Point(12, 12);
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.Size = new System.Drawing.Size(415, 177);
            this.dgvStores.TabIndex = 0;
            // 
            // dgvSales
            // 
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(433, 12);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(304, 177);
            this.dgvSales.TabIndex = 1;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(662, 195);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.GetDataButtonClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 229);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.dgvStores);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnGetData;
    }
}