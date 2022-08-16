namespace WindowsFormsApplication1
{
    partial class frmLoguin
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
            this.uc_Login21 = new WindowsFormsApplication1.uc_Login2();
            this.SuspendLayout();
            // 
            // uc_Login21
            // 
            this.uc_Login21.Location = new System.Drawing.Point(29, 3);
            this.uc_Login21.Name = "uc_Login21";
            this.uc_Login21.Size = new System.Drawing.Size(258, 150);
            this.uc_Login21.TabIndex = 0;
            // 
            // frmLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 150);
            this.Controls.Add(this.uc_Login21);
            this.Name = "frmLoguin";
            this.Text = "frmLoguin";
            this.ResumeLayout(false);

        }

        #endregion

        private uc_Login2 uc_Login21;
    }
}