namespace Regex_C
{
    partial class RegEx2
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
            this.BtnEvaluar = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.cmbRegex = new System.Windows.Forms.ComboBox();
            this.txtPatron = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEvaluar
            // 
            this.BtnEvaluar.Location = new System.Drawing.Point(246, 155);
            this.BtnEvaluar.Name = "BtnEvaluar";
            this.BtnEvaluar.Size = new System.Drawing.Size(108, 23);
            this.BtnEvaluar.TabIndex = 29;
            this.BtnEvaluar.Text = "Evaluar";
            this.BtnEvaluar.UseVisualStyleBackColor = true;
            this.BtnEvaluar.Click += new System.EventHandler(this.BtnEvaluar_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(106, 181);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(144, 13);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "Resultados de la evaluación:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(106, 98);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 13);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Cadena a evaluar:";
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(109, 197);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultados.Size = new System.Drawing.Size(561, 131);
            this.txtResultados.TabIndex = 26;
            // 
            // cmbRegex
            // 
            this.cmbRegex.FormattingEnabled = true;
            this.cmbRegex.Location = new System.Drawing.Point(220, 10);
            this.cmbRegex.Name = "cmbRegex";
            this.cmbRegex.Size = new System.Drawing.Size(478, 21);
            this.cmbRegex.TabIndex = 25;
            this.cmbRegex.SelectedIndexChanged += new System.EventHandler(this.cmbRegex_SelectedIndexChanged);
            // 
            // txtPatron
            // 
            this.txtPatron.Location = new System.Drawing.Point(153, 56);
            this.txtPatron.Name = "txtPatron";
            this.txtPatron.ReadOnly = true;
            this.txtPatron.Size = new System.Drawing.Size(545, 20);
            this.txtPatron.TabIndex = 24;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(109, 114);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(561, 20);
            this.txtTexto.TabIndex = 23;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(65, 13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(149, 13);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Seleccionar expresión regular:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(65, 59);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 13);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Patrón a utilizar:";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(455, 155);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(108, 23);
            this.btnResultado.TabIndex = 20;
            this.btnResultado.Text = "Ver resultados";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // RegEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 339);
            this.Controls.Add(this.BtnEvaluar);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.cmbRegex);
            this.Controls.Add(this.txtPatron);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnResultado);
            this.Name = "RegEx2";
            this.Text = "RegEx2";
            this.Load += new System.EventHandler(this.RegEx2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnEvaluar;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtResultados;
        internal System.Windows.Forms.ComboBox cmbRegex;
        internal System.Windows.Forms.TextBox txtPatron;
        internal System.Windows.Forms.TextBox txtTexto;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnResultado;
    }
}