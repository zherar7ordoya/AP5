namespace Regex_C
{
    partial class Imagenes
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.btnDeformar = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(12, 224);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(107, 23);
            this.Button2.TabIndex = 25;
            this.Button2.Text = "Transparentar color";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 134);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(28, 13);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Alto:";
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(78, 131);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(41, 20);
            this.txtAlto.TabIndex = 23;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 100);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 13);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Ancho:";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(78, 97);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(41, 20);
            this.txtAncho.TabIndex = 21;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(12, 298);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(107, 23);
            this.Button3.TabIndex = 20;
            this.Button3.Text = "Grabar";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnDeformar
            // 
            this.btnDeformar.Location = new System.Drawing.Point(12, 157);
            this.btnDeformar.Name = "btnDeformar";
            this.btnDeformar.Size = new System.Drawing.Size(107, 23);
            this.btnDeformar.TabIndex = 19;
            this.btnDeformar.Text = "Deformar";
            this.btnDeformar.UseVisualStyleBackColor = true;
            this.btnDeformar.Click += new System.EventHandler(this.btnDeformar_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(107, 23);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "Cargar imagen";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 366);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.btnDeformar);
            this.Controls.Add(this.Button1);
            this.Name = "Imagenes";
            this.Text = "Imagenes";
            this.Load += new System.EventHandler(this.Imagenes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtAlto;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtAncho;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button btnDeformar;
        internal System.Windows.Forms.Button Button1;
    }
}