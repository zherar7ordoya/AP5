namespace EscritorioClasico.ABMs
{
    partial class GiftcardsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InternacionalesGroupBox = new System.Windows.Forms.GroupBox();
            this.InternacionalesMenorSaldoTextBox = new System.Windows.Forms.TextBox();
            this.InternacionalesDataGridView = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.InternacionalesMenorSaldoLabel = new System.Windows.Forms.Label();
            this.InternacionalesMayorDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.InternacionalesMayorDescuentoLabel = new System.Windows.Forms.Label();
            this.AltaGitfcardButton = new System.Windows.Forms.Button();
            this.NacionalesGroupBox = new System.Windows.Forms.GroupBox();
            this.NacionalesMenorSaldoTextBox = new System.Windows.Forms.TextBox();
            this.NacionalesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.NacionalesMenorSaldoLabel = new System.Windows.Forms.Label();
            this.NacionalesMayorDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.NacionalesMayorDescuentoLabel = new System.Windows.Forms.Label();
            this.InternacionalesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternacionalesDataGridView)).BeginInit();
            this.NacionalesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NacionalesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InternacionalesGroupBox
            // 
            this.InternacionalesGroupBox.Controls.Add(this.InternacionalesMenorSaldoTextBox);
            this.InternacionalesGroupBox.Controls.Add(this.InternacionalesDataGridView);
            this.InternacionalesGroupBox.Controls.Add(this.InternacionalesMenorSaldoLabel);
            this.InternacionalesGroupBox.Controls.Add(this.InternacionalesMayorDescuentoTextBox);
            this.InternacionalesGroupBox.Controls.Add(this.InternacionalesMayorDescuentoLabel);
            this.InternacionalesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InternacionalesGroupBox.Name = "InternacionalesGroupBox";
            this.InternacionalesGroupBox.Size = new System.Drawing.Size(900, 213);
            this.InternacionalesGroupBox.TabIndex = 1;
            this.InternacionalesGroupBox.TabStop = false;
            this.InternacionalesGroupBox.Text = "Internacionales";
            // 
            // InternacionalesMenorSaldoTextBox
            // 
            this.InternacionalesMenorSaldoTextBox.Location = new System.Drawing.Point(690, 174);
            this.InternacionalesMenorSaldoTextBox.Name = "InternacionalesMenorSaldoTextBox";
            this.InternacionalesMenorSaldoTextBox.Size = new System.Drawing.Size(200, 20);
            this.InternacionalesMenorSaldoTextBox.TabIndex = 5;
            // 
            // InternacionalesDataGridView
            // 
            this.InternacionalesDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.InternacionalesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.InternacionalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.InternacionalesDataGridView.ColumnHeadersHeight = 25;
            this.InternacionalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar,
            this.Editar});
            this.InternacionalesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.InternacionalesDataGridView.Name = "InternacionalesDataGridView";
            this.InternacionalesDataGridView.RowTemplate.Height = 32;
            this.InternacionalesDataGridView.Size = new System.Drawing.Size(675, 175);
            this.InternacionalesDataGridView.TabIndex = 3;
            this.InternacionalesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InternacionalesDataGridView_CellContentDoubleClick);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::EscritorioClasico.Properties.Resources.Borrar32x32;
            this.Borrar.Name = "Borrar";
            this.Borrar.Width = 41;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::EscritorioClasico.Properties.Resources.Editar32x32;
            this.Editar.Name = "Editar";
            this.Editar.Width = 40;
            // 
            // InternacionalesMenorSaldoLabel
            // 
            this.InternacionalesMenorSaldoLabel.Location = new System.Drawing.Point(687, 146);
            this.InternacionalesMenorSaldoLabel.Name = "InternacionalesMenorSaldoLabel";
            this.InternacionalesMenorSaldoLabel.Size = new System.Drawing.Size(150, 25);
            this.InternacionalesMenorSaldoLabel.TabIndex = 4;
            this.InternacionalesMenorSaldoLabel.Text = "Gift Card con menor saldo";
            this.InternacionalesMenorSaldoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InternacionalesMayorDescuentoTextBox
            // 
            this.InternacionalesMayorDescuentoTextBox.Location = new System.Drawing.Point(690, 47);
            this.InternacionalesMayorDescuentoTextBox.Name = "InternacionalesMayorDescuentoTextBox";
            this.InternacionalesMayorDescuentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.InternacionalesMayorDescuentoTextBox.TabIndex = 3;
            // 
            // InternacionalesMayorDescuentoLabel
            // 
            this.InternacionalesMayorDescuentoLabel.Location = new System.Drawing.Point(687, 19);
            this.InternacionalesMayorDescuentoLabel.Name = "InternacionalesMayorDescuentoLabel";
            this.InternacionalesMayorDescuentoLabel.Size = new System.Drawing.Size(150, 25);
            this.InternacionalesMayorDescuentoLabel.TabIndex = 2;
            this.InternacionalesMayorDescuentoLabel.Text = "Gift Card con más descuento";
            this.InternacionalesMayorDescuentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AltaGitfcardButton
            // 
            this.AltaGitfcardButton.Location = new System.Drawing.Point(837, 231);
            this.AltaGitfcardButton.Name = "AltaGitfcardButton";
            this.AltaGitfcardButton.Size = new System.Drawing.Size(75, 23);
            this.AltaGitfcardButton.TabIndex = 2;
            this.AltaGitfcardButton.Text = "Alta";
            this.AltaGitfcardButton.UseVisualStyleBackColor = true;
            this.AltaGitfcardButton.Click += new System.EventHandler(this.AltaGitfcardButton_Click);
            // 
            // NacionalesGroupBox
            // 
            this.NacionalesGroupBox.Controls.Add(this.NacionalesMenorSaldoTextBox);
            this.NacionalesGroupBox.Controls.Add(this.NacionalesDataGridView);
            this.NacionalesGroupBox.Controls.Add(this.NacionalesMenorSaldoLabel);
            this.NacionalesGroupBox.Controls.Add(this.NacionalesMayorDescuentoTextBox);
            this.NacionalesGroupBox.Controls.Add(this.NacionalesMayorDescuentoLabel);
            this.NacionalesGroupBox.Location = new System.Drawing.Point(12, 260);
            this.NacionalesGroupBox.Name = "NacionalesGroupBox";
            this.NacionalesGroupBox.Size = new System.Drawing.Size(900, 213);
            this.NacionalesGroupBox.TabIndex = 5;
            this.NacionalesGroupBox.TabStop = false;
            this.NacionalesGroupBox.Text = "Nacionales";
            // 
            // NacionalesMenorSaldoTextBox
            // 
            this.NacionalesMenorSaldoTextBox.Location = new System.Drawing.Point(690, 174);
            this.NacionalesMenorSaldoTextBox.Name = "NacionalesMenorSaldoTextBox";
            this.NacionalesMenorSaldoTextBox.Size = new System.Drawing.Size(200, 20);
            this.NacionalesMenorSaldoTextBox.TabIndex = 5;
            // 
            // NacionalesDataGridView
            // 
            this.NacionalesDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NacionalesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.NacionalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.NacionalesDataGridView.ColumnHeadersHeight = 25;
            this.NacionalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn3,
            this.dataGridViewImageColumn4});
            this.NacionalesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.NacionalesDataGridView.Name = "NacionalesDataGridView";
            this.NacionalesDataGridView.RowTemplate.Height = 32;
            this.NacionalesDataGridView.Size = new System.Drawing.Size(675, 175);
            this.NacionalesDataGridView.TabIndex = 3;
            this.NacionalesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NacionalesDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Borrar";
            this.dataGridViewImageColumn3.Image = global::EscritorioClasico.Properties.Resources.Borrar32x32;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 41;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Editar";
            this.dataGridViewImageColumn4.Image = global::EscritorioClasico.Properties.Resources.Editar32x32;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Width = 40;
            // 
            // NacionalesMenorSaldoLabel
            // 
            this.NacionalesMenorSaldoLabel.Location = new System.Drawing.Point(687, 146);
            this.NacionalesMenorSaldoLabel.Name = "NacionalesMenorSaldoLabel";
            this.NacionalesMenorSaldoLabel.Size = new System.Drawing.Size(150, 25);
            this.NacionalesMenorSaldoLabel.TabIndex = 4;
            this.NacionalesMenorSaldoLabel.Text = "Gift Card con menor saldo";
            this.NacionalesMenorSaldoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NacionalesMayorDescuentoTextBox
            // 
            this.NacionalesMayorDescuentoTextBox.Location = new System.Drawing.Point(690, 47);
            this.NacionalesMayorDescuentoTextBox.Name = "NacionalesMayorDescuentoTextBox";
            this.NacionalesMayorDescuentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.NacionalesMayorDescuentoTextBox.TabIndex = 3;
            // 
            // NacionalesMayorDescuentoLabel
            // 
            this.NacionalesMayorDescuentoLabel.Location = new System.Drawing.Point(687, 19);
            this.NacionalesMayorDescuentoLabel.Name = "NacionalesMayorDescuentoLabel";
            this.NacionalesMayorDescuentoLabel.Size = new System.Drawing.Size(150, 25);
            this.NacionalesMayorDescuentoLabel.TabIndex = 2;
            this.NacionalesMayorDescuentoLabel.Text = "Gift Card con más descuento";
            this.NacionalesMayorDescuentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GiftcardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.NacionalesGroupBox);
            this.Controls.Add(this.InternacionalesGroupBox);
            this.Controls.Add(this.AltaGitfcardButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GiftcardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gift Cards";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GiftcardsForm_FormClosing);
            this.Load += new System.EventHandler(this.GiftcardsForm_Load);
            this.InternacionalesGroupBox.ResumeLayout(false);
            this.InternacionalesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InternacionalesDataGridView)).EndInit();
            this.NacionalesGroupBox.ResumeLayout(false);
            this.NacionalesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NacionalesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox InternacionalesGroupBox;
        private System.Windows.Forms.TextBox InternacionalesMayorDescuentoTextBox;
        private System.Windows.Forms.Label InternacionalesMayorDescuentoLabel;
        private System.Windows.Forms.TextBox InternacionalesMenorSaldoTextBox;
        private System.Windows.Forms.Label InternacionalesMenorSaldoLabel;
        private System.Windows.Forms.DataGridView InternacionalesDataGridView;
        private System.Windows.Forms.Button AltaGitfcardButton;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.GroupBox NacionalesGroupBox;
        private System.Windows.Forms.TextBox NacionalesMenorSaldoTextBox;
        private System.Windows.Forms.DataGridView NacionalesDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Label NacionalesMenorSaldoLabel;
        private System.Windows.Forms.TextBox NacionalesMayorDescuentoTextBox;
        private System.Windows.Forms.Label NacionalesMayorDescuentoLabel;
    }
}