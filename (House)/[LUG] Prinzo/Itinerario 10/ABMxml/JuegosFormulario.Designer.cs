namespace ABMxml
{
    partial class JuegosFormulario
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
            this.JuegosDGV = new System.Windows.Forms.DataGridView();
            this.AltaButton = new System.Windows.Forms.Button();
            this.BajaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.GeneroTextBox = new System.Windows.Forms.TextBox();
            this.GeneroLabel = new System.Windows.Forms.Label();
            this.PlataformaTextBox = new System.Windows.Forms.TextBox();
            this.PlataformaLabel = new System.Windows.Forms.Label();
            this.CompaniaTextBox = new System.Windows.Forms.TextBox();
            this.CompañiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JuegosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // JuegosDGV
            // 
            this.JuegosDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.JuegosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JuegosDGV.Location = new System.Drawing.Point(12, 168);
            this.JuegosDGV.Name = "JuegosDGV";
            this.JuegosDGV.Size = new System.Drawing.Size(550, 275);
            this.JuegosDGV.TabIndex = 0;
            // 
            // AltaButton
            // 
            this.AltaButton.Location = new System.Drawing.Point(324, 112);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(75, 23);
            this.AltaButton.TabIndex = 1;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            this.AltaButton.Click += new System.EventHandler(this.AltaButton_Click);
            // 
            // BajaButton
            // 
            this.BajaButton.Location = new System.Drawing.Point(405, 112);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(75, 23);
            this.BajaButton.TabIndex = 2;
            this.BajaButton.Text = "Baja";
            this.BajaButton.UseVisualStyleBackColor = true;
            this.BajaButton.Click += new System.EventHandler(this.BajaButton_Click);
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Location = new System.Drawing.Point(486, 112);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(75, 23);
            this.ModificacionButton.TabIndex = 3;
            this.ModificacionButton.Text = "Modificacion";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            this.ModificacionButton.Click += new System.EventHandler(this.ModificacionButton_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(12, 9);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(100, 20);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "Id";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(118, 10);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(200, 20);
            this.IdTextBox.TabIndex = 5;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(118, 36);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.NombreTextBox.TabIndex = 7;
            // 
            // NombreLabel
            // 
            this.NombreLabel.Location = new System.Drawing.Point(12, 35);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(100, 20);
            this.NombreLabel.TabIndex = 6;
            this.NombreLabel.Text = "Nombre";
            this.NombreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GeneroTextBox
            // 
            this.GeneroTextBox.Location = new System.Drawing.Point(118, 62);
            this.GeneroTextBox.Name = "GeneroTextBox";
            this.GeneroTextBox.Size = new System.Drawing.Size(200, 20);
            this.GeneroTextBox.TabIndex = 9;
            // 
            // GeneroLabel
            // 
            this.GeneroLabel.Location = new System.Drawing.Point(12, 61);
            this.GeneroLabel.Name = "GeneroLabel";
            this.GeneroLabel.Size = new System.Drawing.Size(100, 20);
            this.GeneroLabel.TabIndex = 8;
            this.GeneroLabel.Text = "Género";
            this.GeneroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlataformaTextBox
            // 
            this.PlataformaTextBox.Location = new System.Drawing.Point(118, 88);
            this.PlataformaTextBox.Name = "PlataformaTextBox";
            this.PlataformaTextBox.Size = new System.Drawing.Size(200, 20);
            this.PlataformaTextBox.TabIndex = 11;
            // 
            // PlataformaLabel
            // 
            this.PlataformaLabel.Location = new System.Drawing.Point(12, 87);
            this.PlataformaLabel.Name = "PlataformaLabel";
            this.PlataformaLabel.Size = new System.Drawing.Size(100, 20);
            this.PlataformaLabel.TabIndex = 10;
            this.PlataformaLabel.Text = "Plataforma";
            this.PlataformaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompaniaTextBox
            // 
            this.CompaniaTextBox.Location = new System.Drawing.Point(118, 114);
            this.CompaniaTextBox.Name = "CompaniaTextBox";
            this.CompaniaTextBox.Size = new System.Drawing.Size(200, 20);
            this.CompaniaTextBox.TabIndex = 13;
            // 
            // CompañiaLabel
            // 
            this.CompañiaLabel.Location = new System.Drawing.Point(12, 113);
            this.CompañiaLabel.Name = "CompañiaLabel";
            this.CompañiaLabel.Size = new System.Drawing.Size(100, 20);
            this.CompañiaLabel.TabIndex = 12;
            this.CompañiaLabel.Text = "Compañía";
            this.CompañiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // JuegosFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 459);
            this.Controls.Add(this.CompaniaTextBox);
            this.Controls.Add(this.CompañiaLabel);
            this.Controls.Add(this.PlataformaTextBox);
            this.Controls.Add(this.PlataformaLabel);
            this.Controls.Add(this.GeneroTextBox);
            this.Controls.Add(this.GeneroLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.JuegosDGV);
            this.Name = "JuegosFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juegos";
            this.Load += new System.EventHandler(this.JuegosFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JuegosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JuegosDGV;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.Button BajaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox GeneroTextBox;
        private System.Windows.Forms.Label GeneroLabel;
        private System.Windows.Forms.TextBox PlataformaTextBox;
        private System.Windows.Forms.Label PlataformaLabel;
        private System.Windows.Forms.TextBox CompaniaTextBox;
        private System.Windows.Forms.Label CompañiaLabel;
    }
}

