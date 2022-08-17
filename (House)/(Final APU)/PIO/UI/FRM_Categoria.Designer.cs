
namespace UI
{
    partial class FRM_Categoria
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
            this.CategoriaDGV = new System.Windows.Forms.DataGridView();
            this.AltaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.BajaButton = new System.Windows.Forms.Button();
            this.NombreTextBox = new UI.PlaceHolderTextBox();
            this.CategoriaIDTextBox = new UI.PlaceHolderTextBox();
            this.DescripcionTextBox = new UI.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaDGV
            // 
            this.CategoriaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriaDGV.Location = new System.Drawing.Point(218, 12);
            this.CategoriaDGV.Name = "CategoriaDGV";
            this.CategoriaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriaDGV.Size = new System.Drawing.Size(400, 162);
            this.CategoriaDGV.TabIndex = 7;
            this.CategoriaDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriaDGV_CellContentClick);
            this.CategoriaDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriaDGV_CellContentClick);
            // 
            // AltaButton
            // 
            this.AltaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaButton.Location = new System.Drawing.Point(624, 12);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(100, 50);
            this.AltaButton.TabIndex = 1;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            this.AltaButton.Click += new System.EventHandler(this.AltaButton_Click);
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificacionButton.Location = new System.Drawing.Point(624, 124);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(100, 50);
            this.ModificacionButton.TabIndex = 3;
            this.ModificacionButton.Text = "Modificación";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            this.ModificacionButton.Click += new System.EventHandler(this.ModificacionButton_Click);
            // 
            // BajaButton
            // 
            this.BajaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaButton.Location = new System.Drawing.Point(624, 68);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(100, 50);
            this.BajaButton.TabIndex = 2;
            this.BajaButton.Text = "Baja";
            this.BajaButton.UseVisualStyleBackColor = true;
            this.BajaButton.Click += new System.EventHandler(this.BajaButton_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.NombreTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.NombreTextBox.Location = new System.Drawing.Point(12, 68);
            this.NombreTextBox.Multiline = true;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(200, 50);
            this.NombreTextBox.TabIndex = 5;
            this.NombreTextBox.Text = "Nombre";
            this.NombreTextBox.TextoPlaceHolder = "Nombre";
            // 
            // CategoriaIDTextBox
            // 
            this.CategoriaIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.CategoriaIDTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.CategoriaIDTextBox.Location = new System.Drawing.Point(12, 12);
            this.CategoriaIDTextBox.Multiline = true;
            this.CategoriaIDTextBox.Name = "CategoriaIDTextBox";
            this.CategoriaIDTextBox.Size = new System.Drawing.Size(200, 50);
            this.CategoriaIDTextBox.TabIndex = 4;
            this.CategoriaIDTextBox.Text = "CategoriaID";
            this.CategoriaIDTextBox.TextoPlaceHolder = "CategoriaID";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.DescripcionTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.DescripcionTextBox.Location = new System.Drawing.Point(12, 124);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(200, 50);
            this.DescripcionTextBox.TabIndex = 6;
            this.DescripcionTextBox.Text = "Descripción";
            this.DescripcionTextBox.TextoPlaceHolder = "Descripción";
            // 
            // CategoriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 211);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.CategoriaDGV);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.CategoriaIDTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Name = "CategoriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.CategoriaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceHolderTextBox DescripcionTextBox;
        private PlaceHolderTextBox CategoriaIDTextBox;
        private PlaceHolderTextBox NombreTextBox;
        private System.Windows.Forms.DataGridView CategoriaDGV;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Button BajaButton;
    }
}