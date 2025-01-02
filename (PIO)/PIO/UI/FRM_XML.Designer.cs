
namespace UI
{
    partial class FRM_XML
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
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.DesdeDTP = new System.Windows.Forms.DateTimePicker();
            this.HastaDTP = new System.Windows.Forms.DateTimePicker();
            this.GenerarXMLButton = new System.Windows.Forms.Button();
            this.AuditoriaDGV = new System.Windows.Forms.DataGridView();
            this.EmpleadoLabel = new System.Windows.Forms.Label();
            this.EmpleadoComboBox = new System.Windows.Forms.ComboBox();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.RendidoLabel = new System.Windows.Forms.Label();
            this.PlazaLabel = new System.Windows.Forms.Label();
            this.DiferenciaLabel = new System.Windows.Forms.Label();
            this.DiferenciaTextBox = new System.Windows.Forms.TextBox();
            this.RendidoTextBox = new System.Windows.Forms.TextBox();
            this.PlazaTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AuditoriaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // HastaLabel
            // 
            this.HastaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HastaLabel.Location = new System.Drawing.Point(118, 9);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(100, 20);
            this.HastaLabel.TabIndex = 38;
            this.HastaLabel.Text = "Hasta";
            this.HastaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DesdeLabel.Location = new System.Drawing.Point(12, 9);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(100, 20);
            this.DesdeLabel.TabIndex = 37;
            this.DesdeLabel.Text = "Desde";
            this.DesdeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DesdeDTP
            // 
            this.DesdeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDTP.Location = new System.Drawing.Point(12, 32);
            this.DesdeDTP.Name = "DesdeDTP";
            this.DesdeDTP.Size = new System.Drawing.Size(100, 20);
            this.DesdeDTP.TabIndex = 33;
            // 
            // HastaDTP
            // 
            this.HastaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDTP.Location = new System.Drawing.Point(118, 32);
            this.HastaDTP.Name = "HastaDTP";
            this.HastaDTP.Size = new System.Drawing.Size(100, 20);
            this.HastaDTP.TabIndex = 34;
            // 
            // GenerarXMLButton
            // 
            this.GenerarXMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarXMLButton.Location = new System.Drawing.Point(224, 9);
            this.GenerarXMLButton.Name = "GenerarXMLButton";
            this.GenerarXMLButton.Size = new System.Drawing.Size(100, 43);
            this.GenerarXMLButton.TabIndex = 35;
            this.GenerarXMLButton.Text = "Generar XML";
            this.GenerarXMLButton.UseVisualStyleBackColor = true;
            this.GenerarXMLButton.Click += new System.EventHandler(this.GenerarXMLButton_Click);
            // 
            // AuditoriaDGV
            // 
            this.AuditoriaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AuditoriaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuditoriaDGV.Location = new System.Drawing.Point(12, 58);
            this.AuditoriaDGV.Name = "AuditoriaDGV";
            this.AuditoriaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuditoriaDGV.Size = new System.Drawing.Size(710, 292);
            this.AuditoriaDGV.TabIndex = 39;
            this.AuditoriaDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AuditoriaDGV_CellContentClick);
            // 
            // EmpleadoLabel
            // 
            this.EmpleadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpleadoLabel.Location = new System.Drawing.Point(12, 353);
            this.EmpleadoLabel.Name = "EmpleadoLabel";
            this.EmpleadoLabel.Size = new System.Drawing.Size(100, 20);
            this.EmpleadoLabel.TabIndex = 40;
            this.EmpleadoLabel.Text = "Empleado";
            this.EmpleadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmpleadoComboBox
            // 
            this.EmpleadoComboBox.FormattingEnabled = true;
            this.EmpleadoComboBox.Location = new System.Drawing.Point(12, 376);
            this.EmpleadoComboBox.Name = "EmpleadoComboBox";
            this.EmpleadoComboBox.Size = new System.Drawing.Size(100, 21);
            this.EmpleadoComboBox.TabIndex = 41;
            this.EmpleadoComboBox.SelectedIndexChanged += new System.EventHandler(this.EmpleadoComboBox_SelectedIndexChanged);
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Enabled = false;
            this.ProductoTextBox.Location = new System.Drawing.Point(118, 354);
            this.ProductoTextBox.Multiline = true;
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(604, 43);
            this.ProductoTextBox.TabIndex = 43;
            // 
            // RendidoLabel
            // 
            this.RendidoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RendidoLabel.Location = new System.Drawing.Point(410, 9);
            this.RendidoLabel.Name = "RendidoLabel";
            this.RendidoLabel.Size = new System.Drawing.Size(100, 20);
            this.RendidoLabel.TabIndex = 44;
            this.RendidoLabel.Text = "Total rendido";
            this.RendidoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlazaLabel
            // 
            this.PlazaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlazaLabel.Location = new System.Drawing.Point(516, 9);
            this.PlazaLabel.Name = "PlazaLabel";
            this.PlazaLabel.Size = new System.Drawing.Size(100, 20);
            this.PlazaLabel.TabIndex = 45;
            this.PlazaLabel.Text = "Valor en plaza";
            this.PlazaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiferenciaLabel
            // 
            this.DiferenciaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiferenciaLabel.Location = new System.Drawing.Point(622, 9);
            this.DiferenciaLabel.Name = "DiferenciaLabel";
            this.DiferenciaLabel.Size = new System.Drawing.Size(100, 20);
            this.DiferenciaLabel.TabIndex = 46;
            this.DiferenciaLabel.Text = "Diferencia";
            this.DiferenciaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DiferenciaTextBox
            // 
            this.DiferenciaTextBox.Enabled = false;
            this.DiferenciaTextBox.Location = new System.Drawing.Point(622, 32);
            this.DiferenciaTextBox.Name = "DiferenciaTextBox";
            this.DiferenciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiferenciaTextBox.TabIndex = 47;
            // 
            // RendidoTextBox
            // 
            this.RendidoTextBox.Enabled = false;
            this.RendidoTextBox.Location = new System.Drawing.Point(410, 32);
            this.RendidoTextBox.Name = "RendidoTextBox";
            this.RendidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.RendidoTextBox.TabIndex = 48;
            // 
            // PlazaTextBox
            // 
            this.PlazaTextBox.Location = new System.Drawing.Point(516, 32);
            this.PlazaTextBox.Name = "PlazaTextBox";
            this.PlazaTextBox.Size = new System.Drawing.Size(100, 20);
            this.PlazaTextBox.TabIndex = 49;
            this.PlazaTextBox.TextChanged += new System.EventHandler(this.PlazaTextBox_TextChanged);
            // 
            // FRM_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.PlazaTextBox);
            this.Controls.Add(this.RendidoTextBox);
            this.Controls.Add(this.DiferenciaTextBox);
            this.Controls.Add(this.DiferenciaLabel);
            this.Controls.Add(this.PlazaLabel);
            this.Controls.Add(this.RendidoLabel);
            this.Controls.Add(this.ProductoTextBox);
            this.Controls.Add(this.EmpleadoComboBox);
            this.Controls.Add(this.EmpleadoLabel);
            this.Controls.Add(this.AuditoriaDGV);
            this.Controls.Add(this.HastaLabel);
            this.Controls.Add(this.DesdeLabel);
            this.Controls.Add(this.DesdeDTP);
            this.Controls.Add(this.HastaDTP);
            this.Controls.Add(this.GenerarXMLButton);
            this.Name = "FRM_XML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoría de importes declarados";
            ((System.ComponentModel.ISupportInitialize)(this.AuditoriaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.DateTimePicker DesdeDTP;
        private System.Windows.Forms.DateTimePicker HastaDTP;
        private System.Windows.Forms.Button GenerarXMLButton;
        private System.Windows.Forms.DataGridView AuditoriaDGV;
        private System.Windows.Forms.Label EmpleadoLabel;
        private System.Windows.Forms.ComboBox EmpleadoComboBox;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.Label RendidoLabel;
        private System.Windows.Forms.Label PlazaLabel;
        private System.Windows.Forms.Label DiferenciaLabel;
        private System.Windows.Forms.TextBox DiferenciaTextBox;
        private System.Windows.Forms.TextBox RendidoTextBox;
        private System.Windows.Forms.TextBox PlazaTextBox;
    }
}