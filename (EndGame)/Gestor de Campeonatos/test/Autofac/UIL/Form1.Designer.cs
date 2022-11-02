namespace UIL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.CodigoTextbox = new System.Windows.Forms.TextBox();
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.DescripcionTextbox = new System.Windows.Forms.TextBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodigoLabel.Location = new System.Drawing.Point(12, 9);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(100, 23);
            this.CodigoLabel.TabIndex = 0;
            this.CodigoLabel.Text = "Codigo";
            // 
            // CodigoTextbox
            // 
            this.CodigoTextbox.Enabled = false;
            this.CodigoTextbox.Location = new System.Drawing.Point(118, 12);
            this.CodigoTextbox.Name = "CodigoTextbox";
            this.CodigoTextbox.Size = new System.Drawing.Size(100, 20);
            this.CodigoTextbox.TabIndex = 1;
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.Location = new System.Drawing.Point(118, 45);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(100, 20);
            this.NombreTextbox.TabIndex = 3;
            // 
            // NombreLabel
            // 
            this.NombreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreLabel.Location = new System.Drawing.Point(12, 42);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(100, 23);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre";
            // 
            // DescripcionTextbox
            // 
            this.DescripcionTextbox.Location = new System.Drawing.Point(118, 83);
            this.DescripcionTextbox.Name = "DescripcionTextbox";
            this.DescripcionTextbox.Size = new System.Drawing.Size(100, 20);
            this.DescripcionTextbox.TabIndex = 5;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripcionLabel.Location = new System.Drawing.Point(12, 80);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(100, 23);
            this.DescripcionLabel.TabIndex = 4;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // IngresarButton
            // 
            this.IngresarButton.Location = new System.Drawing.Point(13, 135);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(205, 23);
            this.IngresarButton.TabIndex = 6;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 185);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.DescripcionTextbox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.NombreTextbox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.CodigoTextbox);
            this.Controls.Add(this.CodigoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.TextBox CodigoTextbox;
        private System.Windows.Forms.TextBox NombreTextbox;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox DescripcionTextbox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Button IngresarButton;
    }
}

