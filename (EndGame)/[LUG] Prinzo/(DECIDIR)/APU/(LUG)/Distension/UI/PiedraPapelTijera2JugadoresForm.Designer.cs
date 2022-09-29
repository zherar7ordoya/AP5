
namespace UI
{
    partial class PiedraPapelTijera2JugadoresForm
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
            this.IniciarButton = new System.Windows.Forms.Button();
            this.IzquierdaCombobox = new System.Windows.Forms.ComboBox();
            this.IzquierdaPanel = new System.Windows.Forms.Panel();
            this.PiedraIzquierdaButton = new System.Windows.Forms.Button();
            this.PapelIzquierdaButton = new System.Windows.Forms.Button();
            this.TijeraIzquierdaButton = new System.Windows.Forms.Button();
            this.RondasLabel = new System.Windows.Forms.Label();
            this.GanadorLabel = new System.Windows.Forms.Label();
            this.DerechaPicturebox = new System.Windows.Forms.PictureBox();
            this.IzquierdaPicturebox = new System.Windows.Forms.PictureBox();
            this.DerechaCombobox = new System.Windows.Forms.ComboBox();
            this.DerechaPanel = new System.Windows.Forms.Panel();
            this.PiedraDerechaButton = new System.Windows.Forms.Button();
            this.PapelDerechaButton = new System.Windows.Forms.Button();
            this.TijeraDerechaButton = new System.Windows.Forms.Button();
            this.CronometroTimer = new System.Windows.Forms.Timer(this.components);
            this.SegundosLabel = new System.Windows.Forms.Label();
            this.IzquierdaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DerechaPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzquierdaPicturebox)).BeginInit();
            this.DerechaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IniciarButton
            // 
            this.IniciarButton.Location = new System.Drawing.Point(292, 152);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(75, 23);
            this.IniciarButton.TabIndex = 24;
            this.IniciarButton.Text = "Iniciar Juego";
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // IzquierdaCombobox
            // 
            this.IzquierdaCombobox.FormattingEnabled = true;
            this.IzquierdaCombobox.Location = new System.Drawing.Point(131, 12);
            this.IzquierdaCombobox.Name = "IzquierdaCombobox";
            this.IzquierdaCombobox.Size = new System.Drawing.Size(130, 21);
            this.IzquierdaCombobox.TabIndex = 23;
            // 
            // IzquierdaPanel
            // 
            this.IzquierdaPanel.Controls.Add(this.PiedraIzquierdaButton);
            this.IzquierdaPanel.Controls.Add(this.PapelIzquierdaButton);
            this.IzquierdaPanel.Controls.Add(this.TijeraIzquierdaButton);
            this.IzquierdaPanel.Location = new System.Drawing.Point(12, 12);
            this.IzquierdaPanel.Name = "IzquierdaPanel";
            this.IzquierdaPanel.Size = new System.Drawing.Size(82, 163);
            this.IzquierdaPanel.TabIndex = 22;
            // 
            // PiedraIzquierdaButton
            // 
            this.PiedraIzquierdaButton.Location = new System.Drawing.Point(3, 3);
            this.PiedraIzquierdaButton.Name = "PiedraIzquierdaButton";
            this.PiedraIzquierdaButton.Size = new System.Drawing.Size(75, 23);
            this.PiedraIzquierdaButton.TabIndex = 2;
            this.PiedraIzquierdaButton.Text = "Piedra";
            this.PiedraIzquierdaButton.UseVisualStyleBackColor = true;
            this.PiedraIzquierdaButton.Click += new System.EventHandler(this.PiedraIzquierdaButton_Click);
            // 
            // PapelIzquierdaButton
            // 
            this.PapelIzquierdaButton.Location = new System.Drawing.Point(3, 32);
            this.PapelIzquierdaButton.Name = "PapelIzquierdaButton";
            this.PapelIzquierdaButton.Size = new System.Drawing.Size(75, 23);
            this.PapelIzquierdaButton.TabIndex = 3;
            this.PapelIzquierdaButton.Text = "Papel";
            this.PapelIzquierdaButton.UseVisualStyleBackColor = true;
            this.PapelIzquierdaButton.Click += new System.EventHandler(this.PapelIzquierdaButton_Click);
            // 
            // TijeraIzquierdaButton
            // 
            this.TijeraIzquierdaButton.Location = new System.Drawing.Point(3, 61);
            this.TijeraIzquierdaButton.Name = "TijeraIzquierdaButton";
            this.TijeraIzquierdaButton.Size = new System.Drawing.Size(75, 23);
            this.TijeraIzquierdaButton.TabIndex = 4;
            this.TijeraIzquierdaButton.Text = "Tijera";
            this.TijeraIzquierdaButton.UseVisualStyleBackColor = true;
            this.TijeraIzquierdaButton.Click += new System.EventHandler(this.TijeraIzquierdaButton_Click);
            // 
            // RondasLabel
            // 
            this.RondasLabel.Location = new System.Drawing.Point(262, 78);
            this.RondasLabel.Name = "RondasLabel";
            this.RondasLabel.Size = new System.Drawing.Size(133, 13);
            this.RondasLabel.TabIndex = 13;
            this.RondasLabel.Text = "Ronda 3";
            this.RondasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GanadorLabel
            // 
            this.GanadorLabel.Location = new System.Drawing.Point(262, 45);
            this.GanadorLabel.Name = "GanadorLabel";
            this.GanadorLabel.Size = new System.Drawing.Size(133, 13);
            this.GanadorLabel.TabIndex = 20;
            this.GanadorLabel.Text = "Ganador";
            this.GanadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DerechaPicturebox
            // 
            this.DerechaPicturebox.Image = global::UI.Properties.Resources.Pregunta;
            this.DerechaPicturebox.Location = new System.Drawing.Point(401, 45);
            this.DerechaPicturebox.Name = "DerechaPicturebox";
            this.DerechaPicturebox.Size = new System.Drawing.Size(130, 130);
            this.DerechaPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DerechaPicturebox.TabIndex = 18;
            this.DerechaPicturebox.TabStop = false;
            // 
            // IzquierdaPicturebox
            // 
            this.IzquierdaPicturebox.Image = global::UI.Properties.Resources.Pregunta;
            this.IzquierdaPicturebox.Location = new System.Drawing.Point(131, 45);
            this.IzquierdaPicturebox.Name = "IzquierdaPicturebox";
            this.IzquierdaPicturebox.Size = new System.Drawing.Size(130, 130);
            this.IzquierdaPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IzquierdaPicturebox.TabIndex = 17;
            this.IzquierdaPicturebox.TabStop = false;
            // 
            // DerechaCombobox
            // 
            this.DerechaCombobox.FormattingEnabled = true;
            this.DerechaCombobox.Location = new System.Drawing.Point(401, 12);
            this.DerechaCombobox.Name = "DerechaCombobox";
            this.DerechaCombobox.Size = new System.Drawing.Size(130, 21);
            this.DerechaCombobox.TabIndex = 25;
            // 
            // DerechaPanel
            // 
            this.DerechaPanel.Controls.Add(this.PiedraDerechaButton);
            this.DerechaPanel.Controls.Add(this.PapelDerechaButton);
            this.DerechaPanel.Controls.Add(this.TijeraDerechaButton);
            this.DerechaPanel.Location = new System.Drawing.Point(567, 12);
            this.DerechaPanel.Name = "DerechaPanel";
            this.DerechaPanel.Size = new System.Drawing.Size(82, 163);
            this.DerechaPanel.TabIndex = 26;
            // 
            // PiedraDerechaButton
            // 
            this.PiedraDerechaButton.Location = new System.Drawing.Point(3, 3);
            this.PiedraDerechaButton.Name = "PiedraDerechaButton";
            this.PiedraDerechaButton.Size = new System.Drawing.Size(75, 23);
            this.PiedraDerechaButton.TabIndex = 2;
            this.PiedraDerechaButton.Text = "Piedra";
            this.PiedraDerechaButton.UseVisualStyleBackColor = true;
            this.PiedraDerechaButton.Click += new System.EventHandler(this.PiedraDerechaButton_Click);
            // 
            // PapelDerechaButton
            // 
            this.PapelDerechaButton.Location = new System.Drawing.Point(3, 32);
            this.PapelDerechaButton.Name = "PapelDerechaButton";
            this.PapelDerechaButton.Size = new System.Drawing.Size(75, 23);
            this.PapelDerechaButton.TabIndex = 3;
            this.PapelDerechaButton.Text = "Papel";
            this.PapelDerechaButton.UseVisualStyleBackColor = true;
            this.PapelDerechaButton.Click += new System.EventHandler(this.PapelDerechaButton_Click);
            // 
            // TijeraDerechaButton
            // 
            this.TijeraDerechaButton.Location = new System.Drawing.Point(3, 61);
            this.TijeraDerechaButton.Name = "TijeraDerechaButton";
            this.TijeraDerechaButton.Size = new System.Drawing.Size(75, 23);
            this.TijeraDerechaButton.TabIndex = 4;
            this.TijeraDerechaButton.Text = "Tijera";
            this.TijeraDerechaButton.UseVisualStyleBackColor = true;
            this.TijeraDerechaButton.Click += new System.EventHandler(this.TijeraDerechaButton_Click);
            // 
            // CronometroTimer
            // 
            this.CronometroTimer.Interval = 7000;
            this.CronometroTimer.Tick += new System.EventHandler(this.CronometroTimer_Tick);
            // 
            // SegundosLabel
            // 
            this.SegundosLabel.Location = new System.Drawing.Point(262, 110);
            this.SegundosLabel.Name = "SegundosLabel";
            this.SegundosLabel.Size = new System.Drawing.Size(133, 13);
            this.SegundosLabel.TabIndex = 27;
            this.SegundosLabel.Text = "Segundos";
            this.SegundosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PiedraPapelTijera2JugadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 193);
            this.Controls.Add(this.SegundosLabel);
            this.Controls.Add(this.DerechaPanel);
            this.Controls.Add(this.RondasLabel);
            this.Controls.Add(this.DerechaCombobox);
            this.Controls.Add(this.IniciarButton);
            this.Controls.Add(this.IzquierdaCombobox);
            this.Controls.Add(this.IzquierdaPanel);
            this.Controls.Add(this.GanadorLabel);
            this.Controls.Add(this.DerechaPicturebox);
            this.Controls.Add(this.IzquierdaPicturebox);
            this.Name = "PiedraPapelTijera2JugadoresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PiedraPapelTijera2JugadoresForm";
            this.Load += new System.EventHandler(this.PiedraPapelTijera2JugadoresForm_Load);
            this.IzquierdaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DerechaPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzquierdaPicturebox)).EndInit();
            this.DerechaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.ComboBox IzquierdaCombobox;
        private System.Windows.Forms.Panel IzquierdaPanel;
        private System.Windows.Forms.Button PiedraIzquierdaButton;
        private System.Windows.Forms.Label RondasLabel;
        private System.Windows.Forms.Button PapelIzquierdaButton;
        private System.Windows.Forms.Button TijeraIzquierdaButton;
        private System.Windows.Forms.Label GanadorLabel;
        private System.Windows.Forms.PictureBox DerechaPicturebox;
        private System.Windows.Forms.PictureBox IzquierdaPicturebox;
        private System.Windows.Forms.ComboBox DerechaCombobox;
        private System.Windows.Forms.Panel DerechaPanel;
        private System.Windows.Forms.Button PiedraDerechaButton;
        private System.Windows.Forms.Button PapelDerechaButton;
        private System.Windows.Forms.Button TijeraDerechaButton;
        private System.Windows.Forms.Timer CronometroTimer;
        private System.Windows.Forms.Label SegundosLabel;
    }
}