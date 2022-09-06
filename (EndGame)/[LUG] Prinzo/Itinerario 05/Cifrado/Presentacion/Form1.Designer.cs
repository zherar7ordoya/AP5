namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEncripta = new System.Windows.Forms.Button();
            this.Btn_Desencripta = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMD5 = new System.Windows.Forms.Button();
            this.BtnSHA = new System.Windows.Forms.Button();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(27, 193);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(106, 13);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Texto Desencriptado";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.BtnEncripta);
            this.GroupBox2.Controls.Add(this.Btn_Desencripta);
            this.GroupBox2.Location = new System.Drawing.Point(409, 106);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(200, 117);
            this.GroupBox2.TabIndex = 20;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Casero";
            // 
            // BtnEncripta
            // 
            this.BtnEncripta.Location = new System.Drawing.Point(36, 29);
            this.BtnEncripta.Name = "BtnEncripta";
            this.BtnEncripta.Size = new System.Drawing.Size(109, 23);
            this.BtnEncripta.TabIndex = 7;
            this.BtnEncripta.Text = "Encriptar";
            this.BtnEncripta.UseVisualStyleBackColor = true;
            this.BtnEncripta.Click += new System.EventHandler(this.BtnEncripta_Click);
            // 
            // Btn_Desencripta
            // 
            this.Btn_Desencripta.Location = new System.Drawing.Point(36, 77);
            this.Btn_Desencripta.Name = "Btn_Desencripta";
            this.Btn_Desencripta.Size = new System.Drawing.Size(109, 23);
            this.Btn_Desencripta.TabIndex = 8;
            this.Btn_Desencripta.Text = "Desencriptar";
            this.Btn_Desencripta.UseVisualStyleBackColor = true;
            this.Btn_Desencripta.Click += new System.EventHandler(this.Btn_Desencripta_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BtnMD5);
            this.GroupBox1.Controls.Add(this.BtnSHA);
            this.GroupBox1.Location = new System.Drawing.Point(409, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(200, 100);
            this.GroupBox1.TabIndex = 19;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Hash";
            // 
            // BtnMD5
            // 
            this.BtnMD5.Location = new System.Drawing.Point(36, 19);
            this.BtnMD5.Name = "BtnMD5";
            this.BtnMD5.Size = new System.Drawing.Size(109, 23);
            this.BtnMD5.TabIndex = 2;
            this.BtnMD5.Text = "MD5";
            this.BtnMD5.UseVisualStyleBackColor = true;
            this.BtnMD5.Click += new System.EventHandler(this.BtnMD5_Click);
            // 
            // BtnSHA
            // 
            this.BtnSHA.Location = new System.Drawing.Point(36, 58);
            this.BtnSHA.Name = "BtnSHA";
            this.BtnSHA.Size = new System.Drawing.Size(109, 23);
            this.BtnSHA.TabIndex = 9;
            this.BtnSHA.Text = "SHA";
            this.BtnSHA.UseVisualStyleBackColor = true;
            this.BtnSHA.Click += new System.EventHandler(this.BtnSHA_Click);
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(26, 209);
            this.TextBox3.Multiline = true;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(351, 57);
            this.TextBox3.TabIndex = 18;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(445, 243);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(109, 23);
            this.BtnLimpiar.TabIndex = 17;
            this.BtnLimpiar.Text = "Limpiar Todo";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(27, 106);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Texto Encriptado";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(26, 122);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(351, 56);
            this.TextBox2.TabIndex = 15;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(26, 29);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(350, 54);
            this.TextBox1.TabIndex = 14;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(27, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(114, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Ingrese el texto a cifrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 289);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button BtnEncripta;
        internal System.Windows.Forms.Button Btn_Desencripta;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button BtnMD5;
        internal System.Windows.Forms.Button BtnSHA;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Button BtnLimpiar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
    }
}

