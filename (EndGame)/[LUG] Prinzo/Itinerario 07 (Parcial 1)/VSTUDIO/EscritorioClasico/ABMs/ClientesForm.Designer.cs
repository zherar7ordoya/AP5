namespace EscritorioClasico.ABMs
{
    partial class ClientesForm
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
            this.AltaClienteButton = new System.Windows.Forms.Button();
            this.ClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AltaClienteButton
            // 
            this.AltaClienteButton.Location = new System.Drawing.Point(619, 289);
            this.AltaClienteButton.Name = "AltaClienteButton";
            this.AltaClienteButton.Size = new System.Drawing.Size(75, 23);
            this.AltaClienteButton.TabIndex = 0;
            this.AltaClienteButton.Text = "Alta";
            this.AltaClienteButton.UseVisualStyleBackColor = true;
            this.AltaClienteButton.Click += new System.EventHandler(this.AltaClienteButton_Click);
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ClientesDataGridView.ColumnHeadersHeight = 25;
            this.ClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar,
            this.Editar});
            this.ClientesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.RowTemplate.Height = 32;
            this.ClientesDataGridView.Size = new System.Drawing.Size(600, 300);
            this.ClientesDataGridView.TabIndex = 1;
            this.ClientesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDataGridView_CellContentDoubleClick);
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
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 361);
            this.Controls.Add(this.ClientesDataGridView);
            this.Controls.Add(this.AltaClienteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientesForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AltaClienteButton;
        private System.Windows.Forms.DataGridView ClientesDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}