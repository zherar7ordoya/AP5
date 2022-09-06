namespace EscritorioClasico.ABMs
{
    partial class ClienteForm
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
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.DNITextBox = new System.Windows.Forms.TextBox();
            this.DNILabel = new System.Windows.Forms.Label();
            this.FechaNacimientoLabel = new System.Windows.Forms.Label();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.FechaVencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.Location = new System.Drawing.Point(12, 9);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(150, 25);
            this.CodigoLabel.TabIndex = 0;
            this.CodigoLabel.Text = "Código";
            this.CodigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(168, 12);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(150, 20);
            this.CodigoTextBox.TabIndex = 1;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(168, 38);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(150, 20);
            this.NombreTextBox.TabIndex = 3;
            // 
            // NombreLabel
            // 
            this.NombreLabel.Location = new System.Drawing.Point(12, 35);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(150, 25);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre";
            this.NombreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(168, 64);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(150, 20);
            this.ApellidoTextBox.TabIndex = 5;
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.Location = new System.Drawing.Point(12, 61);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(150, 25);
            this.ApellidoLabel.TabIndex = 4;
            this.ApellidoLabel.Text = "Apellido";
            this.ApellidoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DNITextBox
            // 
            this.DNITextBox.Location = new System.Drawing.Point(168, 90);
            this.DNITextBox.Name = "DNITextBox";
            this.DNITextBox.Size = new System.Drawing.Size(150, 20);
            this.DNITextBox.TabIndex = 7;
            // 
            // DNILabel
            // 
            this.DNILabel.Location = new System.Drawing.Point(12, 87);
            this.DNILabel.Name = "DNILabel";
            this.DNILabel.Size = new System.Drawing.Size(150, 25);
            this.DNILabel.TabIndex = 6;
            this.DNILabel.Text = "DNI";
            this.DNILabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FechaNacimientoLabel
            // 
            this.FechaNacimientoLabel.Location = new System.Drawing.Point(12, 113);
            this.FechaNacimientoLabel.Name = "FechaNacimientoLabel";
            this.FechaNacimientoLabel.Size = new System.Drawing.Size(150, 25);
            this.FechaNacimientoLabel.TabIndex = 8;
            this.FechaNacimientoLabel.Text = "Fecha de Nacimiento";
            this.FechaNacimientoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Location = new System.Drawing.Point(324, 115);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrarButton.TabIndex = 12;
            this.RegistrarButton.Text = "Registrar";
            this.RegistrarButton.UseVisualStyleBackColor = true;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // FechaVencimientoDateTimePicker
            // 
            this.FechaVencimientoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FechaVencimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVencimientoDateTimePicker.Location = new System.Drawing.Point(168, 116);
            this.FechaVencimientoDateTimePicker.Name = "FechaVencimientoDateTimePicker";
            this.FechaVencimientoDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.FechaVencimientoDateTimePicker.TabIndex = 13;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 186);
            this.Controls.Add(this.FechaVencimientoDateTimePicker);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.FechaNacimientoLabel);
            this.Controls.Add(this.DNITextBox);
            this.Controls.Add(this.DNILabel);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.ApellidoLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.CodigoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM de Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClienteForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label ApellidoLabel;
        private System.Windows.Forms.Label DNILabel;
        private System.Windows.Forms.Label FechaNacimientoLabel;
        public System.Windows.Forms.TextBox CodigoTextBox;
        public System.Windows.Forms.TextBox NombreTextBox;
        public System.Windows.Forms.TextBox ApellidoTextBox;
        public System.Windows.Forms.TextBox DNITextBox;
        public System.Windows.Forms.Button RegistrarButton;
        public System.Windows.Forms.DateTimePicker FechaVencimientoDateTimePicker;
    }
}