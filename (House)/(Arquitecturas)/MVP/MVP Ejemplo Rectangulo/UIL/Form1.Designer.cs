
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
            this.AreaButton = new System.Windows.Forms.Button();
            this.LongitudTextbox = new UI.CajaTextoProvisional();
            this.AmplitudTextbox = new UI.CajaTextoProvisional();
            this.AreaTextbox = new UI.CajaTextoProvisional();
            this.SuspendLayout();
            // 
            // AreaButton
            // 
            this.AreaButton.Location = new System.Drawing.Point(130, 15);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(49, 49);
            this.AreaButton.TabIndex = 3;
            this.AreaButton.Text = "Area";
            this.AreaButton.UseVisualStyleBackColor = true;
            this.AreaButton.Click += new System.EventHandler(this.AreaButton_Click);
            // 
            // LongitudTextbox
            // 
            this.LongitudTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.LongitudTextbox.ForeColor = System.Drawing.Color.Gray;
            this.LongitudTextbox.Location = new System.Drawing.Point(24, 17);
            this.LongitudTextbox.Name = "LongitudTextbox";
            this.LongitudTextbox.Size = new System.Drawing.Size(100, 20);
            this.LongitudTextbox.TabIndex = 1;
            this.LongitudTextbox.Text = "Longitud";
            this.LongitudTextbox.TextoProvisional = "Longitud";
            // 
            // AmplitudTextbox
            // 
            this.AmplitudTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.AmplitudTextbox.ForeColor = System.Drawing.Color.Gray;
            this.AmplitudTextbox.Location = new System.Drawing.Point(24, 44);
            this.AmplitudTextbox.Name = "AmplitudTextbox";
            this.AmplitudTextbox.Size = new System.Drawing.Size(100, 20);
            this.AmplitudTextbox.TabIndex = 2;
            this.AmplitudTextbox.Text = "Amplitud";
            this.AmplitudTextbox.TextoProvisional = "Amplitud";
            // 
            // AreaTextbox
            // 
            this.AreaTextbox.Enabled = false;
            this.AreaTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.AreaTextbox.ForeColor = System.Drawing.Color.Gray;
            this.AreaTextbox.Location = new System.Drawing.Point(185, 30);
            this.AreaTextbox.Name = "AreaTextbox";
            this.AreaTextbox.Size = new System.Drawing.Size(100, 20);
            this.AreaTextbox.TabIndex = 4;
            this.AreaTextbox.Text = "Resultado";
            this.AreaTextbox.TextoProvisional = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 82);
            this.Controls.Add(this.AreaTextbox);
            this.Controls.Add(this.AmplitudTextbox);
            this.Controls.Add(this.LongitudTextbox);
            this.Controls.Add(this.AreaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AreaButton;
        private UI.CajaTextoProvisional LongitudTextbox;
        private UI.CajaTextoProvisional AmplitudTextbox;
        private UI.CajaTextoProvisional AreaTextbox;
    }
}

