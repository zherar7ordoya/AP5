namespace EscritorioClasico.Compras
{
    partial class CompraForm
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
            this.ImporteCompraTextBox = new System.Windows.Forms.TextBox();
            this.FechaCompraLabel = new System.Windows.Forms.Label();
            this.ImporteCompraLabel = new System.Windows.Forms.Label();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.SaldoLabel = new System.Windows.Forms.Label();
            this.GiftcardTextBox = new System.Windows.Forms.TextBox();
            this.GiftcardLabel = new System.Windows.Forms.Label();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.FechaCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ImporteCompraTextBox
            // 
            this.ImporteCompraTextBox.Location = new System.Drawing.Point(168, 64);
            this.ImporteCompraTextBox.Name = "ImporteCompraTextBox";
            this.ImporteCompraTextBox.Size = new System.Drawing.Size(150, 20);
            this.ImporteCompraTextBox.TabIndex = 67;
            // 
            // FechaCompraLabel
            // 
            this.FechaCompraLabel.Location = new System.Drawing.Point(12, 87);
            this.FechaCompraLabel.Name = "FechaCompraLabel";
            this.FechaCompraLabel.Size = new System.Drawing.Size(150, 25);
            this.FechaCompraLabel.TabIndex = 65;
            this.FechaCompraLabel.Text = "Fecha de compra";
            this.FechaCompraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImporteCompraLabel
            // 
            this.ImporteCompraLabel.Location = new System.Drawing.Point(12, 61);
            this.ImporteCompraLabel.Name = "ImporteCompraLabel";
            this.ImporteCompraLabel.Size = new System.Drawing.Size(150, 25);
            this.ImporteCompraLabel.TabIndex = 64;
            this.ImporteCompraLabel.Text = "Importe de compra";
            this.ImporteCompraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Location = new System.Drawing.Point(168, 38);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.Size = new System.Drawing.Size(150, 20);
            this.SaldoTextBox.TabIndex = 63;
            // 
            // SaldoLabel
            // 
            this.SaldoLabel.Location = new System.Drawing.Point(12, 35);
            this.SaldoLabel.Name = "SaldoLabel";
            this.SaldoLabel.Size = new System.Drawing.Size(150, 25);
            this.SaldoLabel.TabIndex = 62;
            this.SaldoLabel.Text = "Saldo";
            this.SaldoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GiftcardTextBox
            // 
            this.GiftcardTextBox.Location = new System.Drawing.Point(168, 12);
            this.GiftcardTextBox.Name = "GiftcardTextBox";
            this.GiftcardTextBox.Size = new System.Drawing.Size(150, 20);
            this.GiftcardTextBox.TabIndex = 60;
            // 
            // GiftcardLabel
            // 
            this.GiftcardLabel.Location = new System.Drawing.Point(12, 9);
            this.GiftcardLabel.Name = "GiftcardLabel";
            this.GiftcardLabel.Size = new System.Drawing.Size(150, 25);
            this.GiftcardLabel.TabIndex = 59;
            this.GiftcardLabel.Text = "Gift Card";
            this.GiftcardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Location = new System.Drawing.Point(324, 89);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrarButton.TabIndex = 69;
            this.RegistrarButton.Text = "Registrar";
            this.RegistrarButton.UseVisualStyleBackColor = true;
            // 
            // FechaCompraDateTimePicker
            // 
            this.FechaCompraDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FechaCompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCompraDateTimePicker.Location = new System.Drawing.Point(168, 91);
            this.FechaCompraDateTimePicker.Name = "FechaCompraDateTimePicker";
            this.FechaCompraDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.FechaCompraDateTimePicker.TabIndex = 70;
            // 
            // CompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.FechaCompraDateTimePicker);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.ImporteCompraTextBox);
            this.Controls.Add(this.FechaCompraLabel);
            this.Controls.Add(this.ImporteCompraLabel);
            this.Controls.Add(this.SaldoTextBox);
            this.Controls.Add(this.SaldoLabel);
            this.Controls.Add(this.GiftcardTextBox);
            this.Controls.Add(this.GiftcardLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FechaCompraLabel;
        private System.Windows.Forms.Label ImporteCompraLabel;
        private System.Windows.Forms.Label SaldoLabel;
        private System.Windows.Forms.Label GiftcardLabel;
        private System.Windows.Forms.Button RegistrarButton;
        public System.Windows.Forms.DateTimePicker FechaCompraDateTimePicker;
        public System.Windows.Forms.TextBox ImporteCompraTextBox;
        public System.Windows.Forms.TextBox SaldoTextBox;
        public System.Windows.Forms.TextBox GiftcardTextBox;
    }
}