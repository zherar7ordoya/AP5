
namespace UI
{
    partial class FRM_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.XButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.InformacionTextBox = new UI.PlaceHolderTextBox();
            this.ContraseñaTextBox = new UI.PlaceHolderTextBox();
            this.UsuarioTextBox = new UI.PlaceHolderTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.TituloLabel);
            this.panel1.Controls.Add(this.XButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 64);
            this.panel1.TabIndex = 0;
            // 
            // TituloLabel
            // 
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.Color.White;
            this.TituloLabel.Location = new System.Drawing.Point(3, 31);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(194, 33);
            this.TituloLabel.TabIndex = 15;
            this.TituloLabel.Text = "Ingreso a la cuenta";
            this.TituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XButton
            // 
            this.XButton.BackColor = System.Drawing.Color.DarkBlue;
            this.XButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.XButton.FlatAppearance.BorderSize = 0;
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.ForeColor = System.Drawing.Color.White;
            this.XButton.Location = new System.Drawing.Point(172, 3);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(25, 25);
            this.XButton.TabIndex = 14;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.LoginButton.Location = new System.Drawing.Point(12, 275);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(200, 25);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // InformacionTextBox
            // 
            this.InformacionTextBox.Enabled = false;
            this.InformacionTextBox.Font = new System.Drawing.Font("Consolas", 8F);
            this.InformacionTextBox.ForeColor = System.Drawing.Color.Black;
            this.InformacionTextBox.Location = new System.Drawing.Point(12, 144);
            this.InformacionTextBox.Multiline = true;
            this.InformacionTextBox.Name = "InformacionTextBox";
            this.InformacionTextBox.Size = new System.Drawing.Size(200, 125);
            this.InformacionTextBox.TabIndex = 12;
            this.InformacionTextBox.Text = "Información";
            this.InformacionTextBox.TextoPlaceHolder = "Información";
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.ContraseñaTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.ContraseñaTextBox.Location = new System.Drawing.Point(12, 113);
            this.ContraseñaTextBox.Multiline = true;
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(200, 25);
            this.ContraseñaTextBox.TabIndex = 11;
            this.ContraseñaTextBox.Text = "Contraseña";
            this.ContraseñaTextBox.TextoPlaceHolder = "Contraseña";
            this.ContraseñaTextBox.TextChanged += new System.EventHandler(this.ContraseñaTextBox_TextChanged);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.UsuarioTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.UsuarioTextBox.Location = new System.Drawing.Point(12, 82);
            this.UsuarioTextBox.Multiline = true;
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(200, 25);
            this.UsuarioTextBox.TabIndex = 10;
            this.UsuarioTextBox.Text = "Usuario";
            this.UsuarioTextBox.TextoPlaceHolder = "Usuario";
            this.UsuarioTextBox.TextChanged += new System.EventHandler(this.UsuarioTextBox_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 312);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.InformacionTextBox);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticación";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PlaceHolderTextBox InformacionTextBox;
        private PlaceHolderTextBox ContraseñaTextBox;
        private PlaceHolderTextBox UsuarioTextBox;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label TituloLabel;
    }
}