namespace EscritorioClasico.ABMs
{
    partial class GiftcardForm
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
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.FechaVencimientoLabel = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.RubroLabel = new System.Windows.Forms.Label();
            this.PaisLabel = new System.Windows.Forms.Label();
            this.ProvinciaLabel = new System.Windows.Forms.Label();
            this.ProvinciaComboBox = new System.Windows.Forms.ComboBox();
            this.PaisComboBox = new System.Windows.Forms.ComboBox();
            this.RubroComboBox = new System.Windows.Forms.ComboBox();
            this.FechaVencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Location = new System.Drawing.Point(324, 144);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrarButton.TabIndex = 25;
            this.RegistrarButton.Text = "Registrar";
            this.RegistrarButton.UseVisualStyleBackColor = true;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // FechaVencimientoLabel
            // 
            this.FechaVencimientoLabel.Location = new System.Drawing.Point(12, 61);
            this.FechaVencimientoLabel.Name = "FechaVencimientoLabel";
            this.FechaVencimientoLabel.Size = new System.Drawing.Size(150, 25);
            this.FechaVencimientoLabel.TabIndex = 19;
            this.FechaVencimientoLabel.Text = "Fecha de Vencimiento";
            this.FechaVencimientoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(168, 38);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(150, 20);
            this.NumeroTextBox.TabIndex = 18;
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.Location = new System.Drawing.Point(12, 35);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(150, 25);
            this.NumeroLabel.TabIndex = 17;
            this.NumeroLabel.Text = "Número";
            this.NumeroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(168, 12);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(150, 20);
            this.CodigoTextBox.TabIndex = 14;
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.Location = new System.Drawing.Point(12, 9);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(150, 25);
            this.CodigoLabel.TabIndex = 13;
            this.CodigoLabel.Text = "Código";
            this.CodigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RubroLabel
            // 
            this.RubroLabel.Location = new System.Drawing.Point(12, 87);
            this.RubroLabel.Name = "RubroLabel";
            this.RubroLabel.Size = new System.Drawing.Size(150, 25);
            this.RubroLabel.TabIndex = 26;
            this.RubroLabel.Text = "Rubro";
            this.RubroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PaisLabel
            // 
            this.PaisLabel.Location = new System.Drawing.Point(12, 114);
            this.PaisLabel.Name = "PaisLabel";
            this.PaisLabel.Size = new System.Drawing.Size(150, 25);
            this.PaisLabel.TabIndex = 30;
            this.PaisLabel.Text = "País";
            this.PaisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProvinciaLabel
            // 
            this.ProvinciaLabel.Location = new System.Drawing.Point(12, 140);
            this.ProvinciaLabel.Name = "ProvinciaLabel";
            this.ProvinciaLabel.Size = new System.Drawing.Size(150, 25);
            this.ProvinciaLabel.TabIndex = 32;
            this.ProvinciaLabel.Text = "Provincia";
            this.ProvinciaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProvinciaComboBox
            // 
            this.ProvinciaComboBox.FormattingEnabled = true;
            this.ProvinciaComboBox.Location = new System.Drawing.Point(168, 144);
            this.ProvinciaComboBox.Name = "ProvinciaComboBox";
            this.ProvinciaComboBox.Size = new System.Drawing.Size(150, 21);
            this.ProvinciaComboBox.TabIndex = 34;
            // 
            // PaisComboBox
            // 
            this.PaisComboBox.FormattingEnabled = true;
            this.PaisComboBox.Location = new System.Drawing.Point(168, 117);
            this.PaisComboBox.Name = "PaisComboBox";
            this.PaisComboBox.Size = new System.Drawing.Size(150, 21);
            this.PaisComboBox.TabIndex = 35;
            // 
            // RubroComboBox
            // 
            this.RubroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RubroComboBox.FormattingEnabled = true;
            this.RubroComboBox.Location = new System.Drawing.Point(168, 90);
            this.RubroComboBox.Name = "RubroComboBox";
            this.RubroComboBox.Size = new System.Drawing.Size(150, 21);
            this.RubroComboBox.TabIndex = 36;
            // 
            // FechaVencimientoDateTimePicker
            // 
            this.FechaVencimientoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FechaVencimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVencimientoDateTimePicker.Location = new System.Drawing.Point(168, 64);
            this.FechaVencimientoDateTimePicker.Name = "FechaVencimientoDateTimePicker";
            this.FechaVencimientoDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.FechaVencimientoDateTimePicker.TabIndex = 38;
            // 
            // GiftcardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 186);
            this.Controls.Add(this.FechaVencimientoDateTimePicker);
            this.Controls.Add(this.RubroComboBox);
            this.Controls.Add(this.PaisComboBox);
            this.Controls.Add(this.ProvinciaComboBox);
            this.Controls.Add(this.ProvinciaLabel);
            this.Controls.Add(this.PaisLabel);
            this.Controls.Add(this.RubroLabel);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.FechaVencimientoLabel);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.NumeroLabel);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.CodigoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GiftcardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de Gift Card";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GiftcardForm_FormClosing);
            this.Load += new System.EventHandler(this.GiftcardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrarButton;
        private System.Windows.Forms.Label FechaVencimientoLabel;
        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.Label RubroLabel;
        private System.Windows.Forms.Label PaisLabel;
        private System.Windows.Forms.Label ProvinciaLabel;
        public System.Windows.Forms.DateTimePicker FechaVencimientoDateTimePicker;
        public System.Windows.Forms.TextBox NumeroTextBox;
        public System.Windows.Forms.TextBox CodigoTextBox;
        public System.Windows.Forms.ComboBox ProvinciaComboBox;
        public System.Windows.Forms.ComboBox PaisComboBox;
        public System.Windows.Forms.ComboBox RubroComboBox;
    }
}