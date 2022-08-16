namespace WindowsFormsApplication1
{
    partial class frmLimpiar
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
            this.uC_Limpiar21 = new WindowsFormsApplication1.UC_Limpiar2();
            this.uC_Limpiar2 = new WindowsFormsApplication1.UC_Limpiar();
            this.uC_Form1 = new WindowsFormsApplication1.UC_Form();
            this.SuspendLayout();
            // 
            // uC_Limpiar21
            // 
            this.uC_Limpiar21.BackColor = System.Drawing.Color.Maroon;
            this.uC_Limpiar21.Location = new System.Drawing.Point(24, 63);
            this.uC_Limpiar21.Name = "uC_Limpiar21";
            this.uC_Limpiar21.Size = new System.Drawing.Size(426, 166);
            this.uC_Limpiar21.TabIndex = 3;
            // 
            // uC_Limpiar2
            // 
            this.uC_Limpiar2.Location = new System.Drawing.Point(12, 12);
            this.uC_Limpiar2.Name = "uC_Limpiar2";
            this.uC_Limpiar2.Size = new System.Drawing.Size(196, 31);
            this.uC_Limpiar2.TabIndex = 2;
            this.uC_Limpiar2.Load += new System.EventHandler(this.uC_Limpiar2_Load);
            // 
            // uC_Form1
            // 
            this.uC_Form1.Location = new System.Drawing.Point(37, 260);
            this.uC_Form1.Name = "uC_Form1";
            this.uC_Form1.Size = new System.Drawing.Size(230, 61);
            this.uC_Form1.TabIndex = 4;
            // 
            // frmLimpiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 383);
            this.Controls.Add(this.uC_Form1);
            this.Controls.Add(this.uC_Limpiar21);
            this.Controls.Add(this.uC_Limpiar2);
            this.Name = "frmLimpiar";
            this.Text = "frmLimpiar";
            this.ResumeLayout(false);

        }

        #endregion
        private UC_Limpiar uC_Limpiar2;
        private UC_Limpiar2 uC_Limpiar21;
        private UC_Form uC_Form1;
    }
}