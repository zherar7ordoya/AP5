
namespace UIL
{
    partial class CalculadoraForm
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
            this.SumarButton = new System.Windows.Forms.Button();
            this.ReiniciarButton = new System.Windows.Forms.Button();
            this.Valor1Textbox = new UI.CajaTextoProvisional();
            this.Valor2Textbox = new UI.CajaTextoProvisional();
            this.Valor3Textbox = new UI.CajaTextoProvisional();
            this.TotalTextbox = new UI.CajaTextoProvisional();
            this.AcumuladoTextbox = new UI.CajaTextoProvisional();
            this.SuspendLayout();
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(143, 38);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(75, 23);
            this.SumarButton.TabIndex = 0;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            // 
            // ReiniciarButton
            // 
            this.ReiniciarButton.Location = new System.Drawing.Point(249, 38);
            this.ReiniciarButton.Name = "ReiniciarButton";
            this.ReiniciarButton.Size = new System.Drawing.Size(75, 23);
            this.ReiniciarButton.TabIndex = 1;
            this.ReiniciarButton.Text = "Reiniciar";
            this.ReiniciarButton.UseVisualStyleBackColor = true;
            // 
            // Valor1Textbox
            // 
            this.Valor1Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Valor1Textbox.ForeColor = System.Drawing.Color.Gray;
            this.Valor1Textbox.Location = new System.Drawing.Point(12, 12);
            this.Valor1Textbox.Name = "Valor1Textbox";
            this.Valor1Textbox.Size = new System.Drawing.Size(100, 20);
            this.Valor1Textbox.TabIndex = 7;
            this.Valor1Textbox.Text = "Ingrese valor 1";
            this.Valor1Textbox.TextoProvisional = "Ingrese valor 1";
            // 
            // Valor2Textbox
            // 
            this.Valor2Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Valor2Textbox.ForeColor = System.Drawing.Color.Gray;
            this.Valor2Textbox.Location = new System.Drawing.Point(12, 38);
            this.Valor2Textbox.Name = "Valor2Textbox";
            this.Valor2Textbox.Size = new System.Drawing.Size(100, 20);
            this.Valor2Textbox.TabIndex = 8;
            this.Valor2Textbox.Text = "Ingrese valor 2";
            this.Valor2Textbox.TextoProvisional = "Ingrese valor 2";
            // 
            // Valor3Textbox
            // 
            this.Valor3Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Valor3Textbox.ForeColor = System.Drawing.Color.Gray;
            this.Valor3Textbox.Location = new System.Drawing.Point(12, 64);
            this.Valor3Textbox.Name = "Valor3Textbox";
            this.Valor3Textbox.Size = new System.Drawing.Size(100, 20);
            this.Valor3Textbox.TabIndex = 9;
            this.Valor3Textbox.Text = "Ingrese valor 3";
            this.Valor3Textbox.TextoProvisional = "Ingrese valor 3";
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.TotalTextbox.ForeColor = System.Drawing.Color.Gray;
            this.TotalTextbox.Location = new System.Drawing.Point(118, 12);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextbox.TabIndex = 10;
            this.TotalTextbox.Text = "Total";
            this.TotalTextbox.TextoProvisional = "Total";
            // 
            // AcumuladoTextbox
            // 
            this.AcumuladoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.AcumuladoTextbox.ForeColor = System.Drawing.Color.Gray;
            this.AcumuladoTextbox.Location = new System.Drawing.Point(224, 12);
            this.AcumuladoTextbox.Name = "AcumuladoTextbox";
            this.AcumuladoTextbox.Size = new System.Drawing.Size(100, 20);
            this.AcumuladoTextbox.TabIndex = 11;
            this.AcumuladoTextbox.Text = "Acumulado";
            this.AcumuladoTextbox.TextoProvisional = "Acumulado";
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 106);
            this.Controls.Add(this.AcumuladoTextbox);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.Valor3Textbox);
            this.Controls.Add(this.Valor2Textbox);
            this.Controls.Add(this.Valor1Textbox);
            this.Controls.Add(this.ReiniciarButton);
            this.Controls.Add(this.SumarButton);
            this.Name = "CalculadoraForm";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.Button ReiniciarButton;
        private UI.CajaTextoProvisional Valor1Textbox;
        private UI.CajaTextoProvisional Valor2Textbox;
        private UI.CajaTextoProvisional Valor3Textbox;
        private UI.CajaTextoProvisional TotalTextbox;
        private UI.CajaTextoProvisional AcumuladoTextbox;
    }
}

