namespace Regex_C
{
    partial class Reemplazos
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
            this.txtRemplazo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkPalabra = new System.Windows.Forms.CheckBox();
            this.btnRemplazar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRemplazo
            // 
            this.txtRemplazo.Location = new System.Drawing.Point(292, 16);
            this.txtRemplazo.Name = "txtRemplazo";
            this.txtRemplazo.Size = new System.Drawing.Size(100, 20);
            this.txtRemplazo.TabIndex = 29;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(264, 19);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(22, 13);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "por";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(29, 169);
            this.txtFinal.Multiline = true;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(516, 69);
            this.txtFinal.TabIndex = 27;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(29, 81);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(516, 69);
            this.txtOriginal.TabIndex = 26;
            // 
            // txtPatron
            // 
            this.txtPatron.Location = new System.Drawing.Point(158, 16);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.Size = new System.Drawing.Size(100, 20);
            this.txtPatron.TabIndex = 25;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(101, 19);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Remplazar ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(26, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Texto original";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(-119, 156);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Texto final";
            // 
            // chkPalabra
            // 
            this.chkPalabra.AutoSize = true;
            this.chkPalabra.Location = new System.Drawing.Point(407, 18);
            this.chkPalabra.Name = "chkPalabra";
            this.chkPalabra.Size = new System.Drawing.Size(141, 17);
            this.chkPalabra.TabIndex = 21;
            this.chkPalabra.Text = "Solo palabras completas";
            this.chkPalabra.UseVisualStyleBackColor = true;
            // 
            // btnRemplazar
            // 
            this.btnRemplazar.Location = new System.Drawing.Point(247, 52);
            this.btnRemplazar.Name = "btnRemplazar";
            this.btnRemplazar.Size = new System.Drawing.Size(75, 23);
            this.btnRemplazar.TabIndex = 20;
            this.btnRemplazar.Text = "Remplazar";
            this.btnRemplazar.UseVisualStyleBackColor = true;
            this.btnRemplazar.Click += new System.EventHandler(this.btnRemplazar_Click);
            // 
            // Reemplazos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 261);
            this.Controls.Add(this.txtRemplazo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.txtPatron);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.chkPalabra);
            this.Controls.Add(this.btnRemplazar);
            this.Name = "Reemplazos";
            this.Text = "Reemplazos";
            this.Load += new System.EventHandler(this.Reemplazos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtRemplazo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtFinal;
        internal System.Windows.Forms.TextBox txtOriginal;
        internal System.Windows.Forms.TextBox txtPatron;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox chkPalabra;
        internal System.Windows.Forms.Button btnRemplazar;
    }
}