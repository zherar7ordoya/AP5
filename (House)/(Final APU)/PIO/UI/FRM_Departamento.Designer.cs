
namespace UI
{
    partial class FRM_Departamento
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
            this.BajaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.AltaButton = new System.Windows.Forms.Button();
            this.DepartamentoDGV = new System.Windows.Forms.DataGridView();
            this.NombreTextBox = new UI.PlaceHolderTextBox();
            this.DepartamentoIDTextBox = new UI.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BajaButton
            // 
            this.BajaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaButton.Location = new System.Drawing.Point(624, 68);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(100, 50);
            this.BajaButton.TabIndex = 9;
            this.BajaButton.Text = "Baja";
            this.BajaButton.UseVisualStyleBackColor = true;
            this.BajaButton.Click += new System.EventHandler(this.BajaButton_Click);
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificacionButton.Location = new System.Drawing.Point(624, 124);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(100, 50);
            this.ModificacionButton.TabIndex = 10;
            this.ModificacionButton.Text = "Modificación";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            this.ModificacionButton.Click += new System.EventHandler(this.ModificacionButton_Click);
            // 
            // AltaButton
            // 
            this.AltaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaButton.Location = new System.Drawing.Point(624, 12);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(100, 50);
            this.AltaButton.TabIndex = 8;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            this.AltaButton.Click += new System.EventHandler(this.AltaButton_Click);
            // 
            // DepartamentoDGV
            // 
            this.DepartamentoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepartamentoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartamentoDGV.Location = new System.Drawing.Point(218, 12);
            this.DepartamentoDGV.Name = "DepartamentoDGV";
            this.DepartamentoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepartamentoDGV.Size = new System.Drawing.Size(400, 162);
            this.DepartamentoDGV.TabIndex = 14;
            this.DepartamentoDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartamentoDGV_CellContentClick);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.NombreTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.NombreTextBox.Location = new System.Drawing.Point(12, 68);
            this.NombreTextBox.Multiline = true;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(200, 50);
            this.NombreTextBox.TabIndex = 12;
            this.NombreTextBox.Text = "Nombre";
            this.NombreTextBox.TextoPlaceHolder = "Nombre";
            // 
            // DepartamentoIDTextBox
            // 
            this.DepartamentoIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.DepartamentoIDTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.DepartamentoIDTextBox.Location = new System.Drawing.Point(12, 12);
            this.DepartamentoIDTextBox.Multiline = true;
            this.DepartamentoIDTextBox.Name = "DepartamentoIDTextBox";
            this.DepartamentoIDTextBox.Size = new System.Drawing.Size(200, 50);
            this.DepartamentoIDTextBox.TabIndex = 11;
            this.DepartamentoIDTextBox.Text = "DepartamentoID";
            this.DepartamentoIDTextBox.TextoPlaceHolder = "DepartamentoID";
            // 
            // DepartamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 211);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.DepartamentoDGV);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.DepartamentoIDTextBox);
            this.Name = "DepartamentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.DepartamentoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BajaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.DataGridView DepartamentoDGV;
        private PlaceHolderTextBox NombreTextBox;
        private PlaceHolderTextBox DepartamentoIDTextBox;
    }
}