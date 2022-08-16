
namespace Monocapa
{
    partial class MainForm
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
            this.CorazonesBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CorazonesBoton
            // 
            this.CorazonesBoton.Location = new System.Drawing.Point(12, 12);
            this.CorazonesBoton.Name = "CorazonesBoton";
            this.CorazonesBoton.Size = new System.Drawing.Size(75, 75);
            this.CorazonesBoton.TabIndex = 0;
            this.CorazonesBoton.Text = "Corazones";
            this.CorazonesBoton.UseVisualStyleBackColor = true;
            this.CorazonesBoton.Click += new System.EventHandler(this.CorazonesBoton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 106);
            this.Controls.Add(this.CorazonesBoton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cita";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CorazonesBoton;
    }
}

