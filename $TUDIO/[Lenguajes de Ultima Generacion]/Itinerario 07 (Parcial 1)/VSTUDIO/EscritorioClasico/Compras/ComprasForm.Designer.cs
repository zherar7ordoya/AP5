namespace EscritorioClasico.Compras
{
    partial class ComprasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.FechaCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.ImporteCompraTextBox = new System.Windows.Forms.TextBox();
            this.FechaCompraLabel = new System.Windows.Forms.Label();
            this.ImporteCompraLabel = new System.Windows.Forms.Label();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.SaldoLabel = new System.Windows.Forms.Label();
            this.GiftcardTextBox = new System.Windows.Forms.TextBox();
            this.GiftcardLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ClientesDataGridView.ColumnHeadersHeight = 25;
            this.ClientesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesDataGridView.Size = new System.Drawing.Size(600, 300);
            this.ClientesDataGridView.TabIndex = 3;
            this.ClientesDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClientesDataGridView_MouseClick);
            // 
            // FechaCompraDateTimePicker
            // 
            this.FechaCompraDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FechaCompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCompraDateTimePicker.Location = new System.Drawing.Point(618, 193);
            this.FechaCompraDateTimePicker.Name = "FechaCompraDateTimePicker";
            this.FechaCompraDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.FechaCompraDateTimePicker.TabIndex = 79;
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Location = new System.Drawing.Point(618, 287);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(150, 25);
            this.RegistrarButton.TabIndex = 78;
            this.RegistrarButton.Text = "Registrar";
            this.RegistrarButton.UseVisualStyleBackColor = true;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // ImporteCompraTextBox
            // 
            this.ImporteCompraTextBox.Location = new System.Drawing.Point(618, 142);
            this.ImporteCompraTextBox.Name = "ImporteCompraTextBox";
            this.ImporteCompraTextBox.Size = new System.Drawing.Size(150, 20);
            this.ImporteCompraTextBox.TabIndex = 77;
            // 
            // FechaCompraLabel
            // 
            this.FechaCompraLabel.Location = new System.Drawing.Point(618, 165);
            this.FechaCompraLabel.Name = "FechaCompraLabel";
            this.FechaCompraLabel.Size = new System.Drawing.Size(150, 25);
            this.FechaCompraLabel.TabIndex = 76;
            this.FechaCompraLabel.Text = "Fecha de compra";
            this.FechaCompraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImporteCompraLabel
            // 
            this.ImporteCompraLabel.Location = new System.Drawing.Point(618, 114);
            this.ImporteCompraLabel.Name = "ImporteCompraLabel";
            this.ImporteCompraLabel.Size = new System.Drawing.Size(150, 25);
            this.ImporteCompraLabel.TabIndex = 75;
            this.ImporteCompraLabel.Text = "Importe de compra";
            this.ImporteCompraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Location = new System.Drawing.Point(618, 91);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.Size = new System.Drawing.Size(150, 20);
            this.SaldoTextBox.TabIndex = 74;
            // 
            // SaldoLabel
            // 
            this.SaldoLabel.Location = new System.Drawing.Point(618, 63);
            this.SaldoLabel.Name = "SaldoLabel";
            this.SaldoLabel.Size = new System.Drawing.Size(150, 25);
            this.SaldoLabel.TabIndex = 73;
            this.SaldoLabel.Text = "Saldo";
            this.SaldoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GiftcardTextBox
            // 
            this.GiftcardTextBox.Location = new System.Drawing.Point(618, 40);
            this.GiftcardTextBox.Name = "GiftcardTextBox";
            this.GiftcardTextBox.Size = new System.Drawing.Size(150, 20);
            this.GiftcardTextBox.TabIndex = 72;
            // 
            // GiftcardLabel
            // 
            this.GiftcardLabel.Location = new System.Drawing.Point(618, 12);
            this.GiftcardLabel.Name = "GiftcardLabel";
            this.GiftcardLabel.Size = new System.Drawing.Size(150, 25);
            this.GiftcardLabel.TabIndex = 71;
            this.GiftcardLabel.Text = "Gift Card";
            this.GiftcardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.FechaCompraDateTimePicker);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.ImporteCompraTextBox);
            this.Controls.Add(this.FechaCompraLabel);
            this.Controls.Add(this.ImporteCompraLabel);
            this.Controls.Add(this.SaldoTextBox);
            this.Controls.Add(this.SaldoLabel);
            this.Controls.Add(this.GiftcardTextBox);
            this.Controls.Add(this.GiftcardLabel);
            this.Controls.Add(this.ClientesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ComprasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComprasForm_FormClosing);
            this.Load += new System.EventHandler(this.ComprasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ClientesDataGridView;
        public System.Windows.Forms.DateTimePicker FechaCompraDateTimePicker;
        private System.Windows.Forms.Button RegistrarButton;
        public System.Windows.Forms.TextBox ImporteCompraTextBox;
        private System.Windows.Forms.Label FechaCompraLabel;
        private System.Windows.Forms.Label ImporteCompraLabel;
        public System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Label SaldoLabel;
        public System.Windows.Forms.TextBox GiftcardTextBox;
        private System.Windows.Forms.Label GiftcardLabel;
    }
}