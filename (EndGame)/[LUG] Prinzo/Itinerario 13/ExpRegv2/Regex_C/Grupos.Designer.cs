namespace Regex_C
{
    partial class Grupos
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtCompras = new System.Windows.Forms.TextBox();
            this.grdCompras = new System.Windows.Forms.DataGridView();
            this.lblLst = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompras)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.btnCargar);
            this.GroupBox2.Controls.Add(this.txtCompras);
            this.GroupBox2.Controls.Add(this.grdCompras);
            this.GroupBox2.Controls.Add(this.lblLst);
            this.GroupBox2.Controls.Add(this.lblComp);
            this.GroupBox2.Location = new System.Drawing.Point(12, 134);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(580, 194);
            this.GroupBox2.TabIndex = 10;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Listado de compras";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(6, 45);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(136, 13);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "de a un producto  por línea";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 30);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(179, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "con el formato \"producto : cantidad\"";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(234, 92);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(94, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar >>";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtCompras
            // 
            this.txtCompras.Location = new System.Drawing.Point(9, 58);
            this.txtCompras.Multiline = true;
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCompras.Size = new System.Drawing.Size(219, 130);
            this.txtCompras.TabIndex = 10;
            // 
            // grdCompras
            // 
            this.grdCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCompras.Location = new System.Drawing.Point(334, 45);
            this.grdCompras.Name = "grdCompras";
            this.grdCompras.Size = new System.Drawing.Size(240, 143);
            this.grdCompras.TabIndex = 11;
            // 
            // lblLst
            // 
            this.lblLst.AutoSize = true;
            this.lblLst.Location = new System.Drawing.Point(331, 16);
            this.lblLst.Name = "lblLst";
            this.lblLst.Size = new System.Drawing.Size(102, 13);
            this.lblLst.TabIndex = 9;
            this.lblLst.Text = "Listado de compras:";
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(6, 16);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(192, 13);
            this.lblComp.TabIndex = 8;
            this.lblComp.Text = "Por favor ingrese el listado de compras.";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtExpresion);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtTexto);
            this.GroupBox1.Controls.Add(this.btnEvaluar);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(580, 104);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Nombre y apellido";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 58);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(530, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "(solo su primer nombre y su primer apellido, comenzando con mayúsculas, sin acent" +
    "os ni caracteres especiales)";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(134, 13);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(402, 20);
            this.txtExpresion.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(189, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Por favor, ingrese su nombre y apellido";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(122, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Expresión de validación:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(9, 73);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(290, 20);
            this.txtTexto.TabIndex = 2;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(305, 71);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 0;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 341);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Grupos";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.Grupos_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompras)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnCargar;
        internal System.Windows.Forms.TextBox txtCompras;
        internal System.Windows.Forms.DataGridView grdCompras;
        internal System.Windows.Forms.Label lblLst;
        internal System.Windows.Forms.Label lblComp;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtExpresion;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtTexto;
        internal System.Windows.Forms.Button btnEvaluar;
    }
}