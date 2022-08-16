
namespace UI
{
    partial class PiedraPapelTijera1JugadorForm
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
            this.components = new System.ComponentModel.Container();
            this.IzquierdaPicturebox = new System.Windows.Forms.PictureBox();
            this.DerechaPicturebox = new System.Windows.Forms.PictureBox();
            this.PiedraButton = new System.Windows.Forms.Button();
            this.PapelButton = new System.Windows.Forms.Button();
            this.TijeraButton = new System.Windows.Forms.Button();
            this.ComputadoraLabel = new System.Windows.Forms.Label();
            this.GanadorLabel = new System.Windows.Forms.Label();
            this.SegundosLabel = new System.Windows.Forms.Label();
            this.RondasLabel = new System.Windows.Forms.Label();
            this.CronometroTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.JugadorCombobox = new System.Windows.Forms.ComboBox();
            this.IniciarJuegoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IzquierdaPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DerechaPicturebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IzquierdaPicturebox
            // 
            this.IzquierdaPicturebox.Image = global::UI.Properties.Resources.Pregunta;
            this.IzquierdaPicturebox.Location = new System.Drawing.Point(182, 38);
            this.IzquierdaPicturebox.Name = "IzquierdaPicturebox";
            this.IzquierdaPicturebox.Size = new System.Drawing.Size(130, 130);
            this.IzquierdaPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IzquierdaPicturebox.TabIndex = 0;
            this.IzquierdaPicturebox.TabStop = false;
            // 
            // DerechaPicturebox
            // 
            this.DerechaPicturebox.Image = global::UI.Properties.Resources.Pregunta;
            this.DerechaPicturebox.Location = new System.Drawing.Point(452, 38);
            this.DerechaPicturebox.Name = "DerechaPicturebox";
            this.DerechaPicturebox.Size = new System.Drawing.Size(130, 130);
            this.DerechaPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DerechaPicturebox.TabIndex = 1;
            this.DerechaPicturebox.TabStop = false;
            // 
            // PiedraButton
            // 
            this.PiedraButton.Location = new System.Drawing.Point(3, 3);
            this.PiedraButton.Name = "PiedraButton";
            this.PiedraButton.Size = new System.Drawing.Size(75, 23);
            this.PiedraButton.TabIndex = 2;
            this.PiedraButton.Text = "Piedra";
            this.PiedraButton.UseVisualStyleBackColor = true;
            this.PiedraButton.Click += new System.EventHandler(this.PiedraButton_Click);
            // 
            // PapelButton
            // 
            this.PapelButton.Location = new System.Drawing.Point(3, 32);
            this.PapelButton.Name = "PapelButton";
            this.PapelButton.Size = new System.Drawing.Size(75, 23);
            this.PapelButton.TabIndex = 3;
            this.PapelButton.Text = "Papel";
            this.PapelButton.UseVisualStyleBackColor = true;
            this.PapelButton.Click += new System.EventHandler(this.PapelButton_Click);
            // 
            // TijeraButton
            // 
            this.TijeraButton.Location = new System.Drawing.Point(3, 61);
            this.TijeraButton.Name = "TijeraButton";
            this.TijeraButton.Size = new System.Drawing.Size(75, 23);
            this.TijeraButton.TabIndex = 4;
            this.TijeraButton.Text = "Tijera";
            this.TijeraButton.UseVisualStyleBackColor = true;
            this.TijeraButton.Click += new System.EventHandler(this.TijeraButton_Click);
            // 
            // ComputadoraLabel
            // 
            this.ComputadoraLabel.AutoSize = true;
            this.ComputadoraLabel.Location = new System.Drawing.Point(459, 13);
            this.ComputadoraLabel.Name = "ComputadoraLabel";
            this.ComputadoraLabel.Size = new System.Drawing.Size(70, 13);
            this.ComputadoraLabel.TabIndex = 9;
            this.ComputadoraLabel.Text = "Computadora";
            // 
            // GanadorLabel
            // 
            this.GanadorLabel.Location = new System.Drawing.Point(313, 38);
            this.GanadorLabel.Name = "GanadorLabel";
            this.GanadorLabel.Size = new System.Drawing.Size(133, 13);
            this.GanadorLabel.TabIndex = 10;
            this.GanadorLabel.Text = "Ganador";
            this.GanadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SegundosLabel
            // 
            this.SegundosLabel.Location = new System.Drawing.Point(313, 84);
            this.SegundosLabel.Name = "SegundosLabel";
            this.SegundosLabel.Size = new System.Drawing.Size(133, 13);
            this.SegundosLabel.TabIndex = 11;
            this.SegundosLabel.Text = "Segundos";
            this.SegundosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RondasLabel
            // 
            this.RondasLabel.Location = new System.Drawing.Point(3, 133);
            this.RondasLabel.Name = "RondasLabel";
            this.RondasLabel.Size = new System.Drawing.Size(75, 13);
            this.RondasLabel.TabIndex = 13;
            this.RondasLabel.Text = "Ronda 3";
            this.RondasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CronometroTimer
            // 
            this.CronometroTimer.Interval = 1000;
            this.CronometroTimer.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PiedraButton);
            this.panel1.Controls.Add(this.RondasLabel);
            this.panel1.Controls.Add(this.PapelButton);
            this.panel1.Controls.Add(this.TijeraButton);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 155);
            this.panel1.TabIndex = 14;
            // 
            // JugadorCombobox
            // 
            this.JugadorCombobox.FormattingEnabled = true;
            this.JugadorCombobox.Location = new System.Drawing.Point(182, 5);
            this.JugadorCombobox.Name = "JugadorCombobox";
            this.JugadorCombobox.Size = new System.Drawing.Size(130, 21);
            this.JugadorCombobox.TabIndex = 15;
            this.JugadorCombobox.SelectedIndexChanged += new System.EventHandler(this.JugadorCombobox_SelectedIndexChanged);
            // 
            // IniciarJuegoButton
            // 
            this.IniciarJuegoButton.Location = new System.Drawing.Point(343, 145);
            this.IniciarJuegoButton.Name = "IniciarJuegoButton";
            this.IniciarJuegoButton.Size = new System.Drawing.Size(75, 23);
            this.IniciarJuegoButton.TabIndex = 16;
            this.IniciarJuegoButton.Text = "Iniciar Juego";
            this.IniciarJuegoButton.UseVisualStyleBackColor = true;
            this.IniciarJuegoButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // PiedraPapelTijera1JugadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 194);
            this.Controls.Add(this.IniciarJuegoButton);
            this.Controls.Add(this.JugadorCombobox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SegundosLabel);
            this.Controls.Add(this.GanadorLabel);
            this.Controls.Add(this.ComputadoraLabel);
            this.Controls.Add(this.DerechaPicturebox);
            this.Controls.Add(this.IzquierdaPicturebox);
            this.Name = "PiedraPapelTijera1JugadorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piedra-Papel-Tijera";
            this.Load += new System.EventHandler(this.PiedraPapelTijera1JugadorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IzquierdaPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DerechaPicturebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IzquierdaPicturebox;
        private System.Windows.Forms.PictureBox DerechaPicturebox;
        private System.Windows.Forms.Button PiedraButton;
        private System.Windows.Forms.Button PapelButton;
        private System.Windows.Forms.Button TijeraButton;
        private System.Windows.Forms.Label ComputadoraLabel;
        private System.Windows.Forms.Label GanadorLabel;
        private System.Windows.Forms.Label SegundosLabel;
        private System.Windows.Forms.Label RondasLabel;
        private System.Windows.Forms.Timer CronometroTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox JugadorCombobox;
        private System.Windows.Forms.Button IniciarJuegoButton;
    }
}

