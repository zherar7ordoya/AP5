namespace Captura
{
    partial class AltaForm
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
            this.CebraRadio = new System.Windows.Forms.RadioButton();
            this.CiervoRadio = new System.Windows.Forms.RadioButton();
            this.LeonRadio = new System.Windows.Forms.RadioButton();
            this.TigreRadio = new System.Windows.Forms.RadioButton();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CebraRadio
            // 
            this.CebraRadio.AutoSize = true;
            this.CebraRadio.Location = new System.Drawing.Point(12, 12);
            this.CebraRadio.Name = "CebraRadio";
            this.CebraRadio.Size = new System.Drawing.Size(65, 23);
            this.CebraRadio.TabIndex = 1;
            this.CebraRadio.TabStop = true;
            this.CebraRadio.Text = "Cebra";
            this.CebraRadio.UseVisualStyleBackColor = true;
            this.CebraRadio.CheckedChanged += new System.EventHandler(this.CebraRadio_CheckedChanged);
            // 
            // CiervoRadio
            // 
            this.CiervoRadio.AutoSize = true;
            this.CiervoRadio.Location = new System.Drawing.Point(12, 41);
            this.CiervoRadio.Name = "CiervoRadio";
            this.CiervoRadio.Size = new System.Drawing.Size(68, 23);
            this.CiervoRadio.TabIndex = 2;
            this.CiervoRadio.TabStop = true;
            this.CiervoRadio.Text = "Ciervo";
            this.CiervoRadio.UseVisualStyleBackColor = true;
            this.CiervoRadio.CheckedChanged += new System.EventHandler(this.CiervoRadio_CheckedChanged);
            // 
            // LeonRadio
            // 
            this.LeonRadio.AutoSize = true;
            this.LeonRadio.Location = new System.Drawing.Point(12, 70);
            this.LeonRadio.Name = "LeonRadio";
            this.LeonRadio.Size = new System.Drawing.Size(58, 23);
            this.LeonRadio.TabIndex = 3;
            this.LeonRadio.TabStop = true;
            this.LeonRadio.Text = "León";
            this.LeonRadio.UseVisualStyleBackColor = true;
            this.LeonRadio.CheckedChanged += new System.EventHandler(this.LeonRadio_CheckedChanged);
            // 
            // TigreRadio
            // 
            this.TigreRadio.AutoSize = true;
            this.TigreRadio.Location = new System.Drawing.Point(12, 99);
            this.TigreRadio.Name = "TigreRadio";
            this.TigreRadio.Size = new System.Drawing.Size(60, 23);
            this.TigreRadio.TabIndex = 4;
            this.TigreRadio.TabStop = true;
            this.TigreRadio.Text = "Tigre";
            this.TigreRadio.UseVisualStyleBackColor = true;
            this.TigreRadio.CheckedChanged += new System.EventHandler(this.TigreRadio_CheckedChanged);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(12, 128);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(100, 30);
            this.AgregarBtn.TabIndex = 0;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // AltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(122, 175);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.TigreRadio);
            this.Controls.Add(this.LeonRadio);
            this.Controls.Add(this.CiervoRadio);
            this.Controls.Add(this.CebraRadio);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AltaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaForm";
            this.Load += new System.EventHandler(this.AltaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CebraRadio;
        private System.Windows.Forms.RadioButton CiervoRadio;
        private System.Windows.Forms.RadioButton LeonRadio;
        private System.Windows.Forms.RadioButton TigreRadio;
        private System.Windows.Forms.Button AgregarBtn;
    }
}