
namespace GCWinforms
{
    partial class VisorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorForm));
            this.CampeonatoLabel = new System.Windows.Forms.Label();
            this.CampeonatoNombreLabel = new System.Windows.Forms.Label();
            this.RondaLabel = new System.Windows.Forms.Label();
            this.RondaCombobox = new System.Windows.Forms.ComboBox();
            this.NoJugadosCheckbox = new System.Windows.Forms.CheckBox();
            this.PartidosListbox = new System.Windows.Forms.ListBox();
            this.Equipo1Label = new System.Windows.Forms.Label();
            this.Puntaje1Label = new System.Windows.Forms.Label();
            this.Puntaje1Textbox = new System.Windows.Forms.TextBox();
            this.Puntaje2Textbox = new System.Windows.Forms.TextBox();
            this.Puntaje2Label = new System.Windows.Forms.Label();
            this.Equipo2Label = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.PuntajeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CampeonatoLabel
            // 
            this.CampeonatoLabel.AutoSize = true;
            this.CampeonatoLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampeonatoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CampeonatoLabel.Location = new System.Drawing.Point(24, 23);
            this.CampeonatoLabel.Name = "CampeonatoLabel";
            this.CampeonatoLabel.Size = new System.Drawing.Size(232, 50);
            this.CampeonatoLabel.TabIndex = 0;
            this.CampeonatoLabel.Text = "Campeonato:";
            // 
            // CampeonatoNombreLabel
            // 
            this.CampeonatoNombreLabel.AutoSize = true;
            this.CampeonatoNombreLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CampeonatoNombreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CampeonatoNombreLabel.Location = new System.Drawing.Point(244, 23);
            this.CampeonatoNombreLabel.Name = "CampeonatoNombreLabel";
            this.CampeonatoNombreLabel.Size = new System.Drawing.Size(115, 50);
            this.CampeonatoNombreLabel.TabIndex = 1;
            this.CampeonatoNombreLabel.Text = "<--->";
            // 
            // RondaLabel
            // 
            this.RondaLabel.AutoSize = true;
            this.RondaLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RondaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RondaLabel.Location = new System.Drawing.Point(26, 94);
            this.RondaLabel.Name = "RondaLabel";
            this.RondaLabel.Size = new System.Drawing.Size(93, 37);
            this.RondaLabel.TabIndex = 2;
            this.RondaLabel.Text = "Ronda";
            // 
            // RondaCombobox
            // 
            this.RondaCombobox.FormattingEnabled = true;
            this.RondaCombobox.Location = new System.Drawing.Point(126, 93);
            this.RondaCombobox.Name = "RondaCombobox";
            this.RondaCombobox.Size = new System.Drawing.Size(268, 38);
            this.RondaCombobox.TabIndex = 3;
            // 
            // NoJugadosCheckbox
            // 
            this.NoJugadosCheckbox.AutoSize = true;
            this.NoJugadosCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoJugadosCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoJugadosCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.NoJugadosCheckbox.Location = new System.Drawing.Point(126, 137);
            this.NoJugadosCheckbox.Name = "NoJugadosCheckbox";
            this.NoJugadosCheckbox.Size = new System.Drawing.Size(174, 41);
            this.NoJugadosCheckbox.TabIndex = 4;
            this.NoJugadosCheckbox.Text = "No Jugados";
            this.NoJugadosCheckbox.UseVisualStyleBackColor = true;
            // 
            // PartidosListbox
            // 
            this.PartidosListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartidosListbox.FormattingEnabled = true;
            this.PartidosListbox.ItemHeight = 30;
            this.PartidosListbox.Location = new System.Drawing.Point(33, 214);
            this.PartidosListbox.Name = "PartidosListbox";
            this.PartidosListbox.Size = new System.Drawing.Size(361, 272);
            this.PartidosListbox.TabIndex = 5;
            // 
            // Equipo1Label
            // 
            this.Equipo1Label.AutoSize = true;
            this.Equipo1Label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipo1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Equipo1Label.Location = new System.Drawing.Point(431, 214);
            this.Equipo1Label.Name = "Equipo1Label";
            this.Equipo1Label.Size = new System.Drawing.Size(159, 37);
            this.Equipo1Label.TabIndex = 6;
            this.Equipo1Label.Text = "<Equipo 1>";
            // 
            // Puntaje1Label
            // 
            this.Puntaje1Label.AutoSize = true;
            this.Puntaje1Label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntaje1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Puntaje1Label.Location = new System.Drawing.Point(431, 251);
            this.Puntaje1Label.Name = "Puntaje1Label";
            this.Puntaje1Label.Size = new System.Drawing.Size(106, 37);
            this.Puntaje1Label.TabIndex = 7;
            this.Puntaje1Label.Text = "Puntaje";
            // 
            // Puntaje1Textbox
            // 
            this.Puntaje1Textbox.Location = new System.Drawing.Point(519, 253);
            this.Puntaje1Textbox.Name = "Puntaje1Textbox";
            this.Puntaje1Textbox.Size = new System.Drawing.Size(100, 35);
            this.Puntaje1Textbox.TabIndex = 8;
            // 
            // Puntaje2Textbox
            // 
            this.Puntaje2Textbox.Location = new System.Drawing.Point(519, 412);
            this.Puntaje2Textbox.Name = "Puntaje2Textbox";
            this.Puntaje2Textbox.Size = new System.Drawing.Size(100, 35);
            this.Puntaje2Textbox.TabIndex = 11;
            // 
            // Puntaje2Label
            // 
            this.Puntaje2Label.AutoSize = true;
            this.Puntaje2Label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntaje2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Puntaje2Label.Location = new System.Drawing.Point(431, 410);
            this.Puntaje2Label.Name = "Puntaje2Label";
            this.Puntaje2Label.Size = new System.Drawing.Size(106, 37);
            this.Puntaje2Label.TabIndex = 10;
            this.Puntaje2Label.Text = "Puntaje";
            // 
            // Equipo2Label
            // 
            this.Equipo2Label.AutoSize = true;
            this.Equipo2Label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipo2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Equipo2Label.Location = new System.Drawing.Point(431, 373);
            this.Equipo2Label.Name = "Equipo2Label";
            this.Equipo2Label.Size = new System.Drawing.Size(159, 37);
            this.Equipo2Label.TabIndex = 9;
            this.Equipo2Label.Text = "<Equipo 2>";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusLabel.ForeColor = System.Drawing.Color.Black;
            this.VersusLabel.Location = new System.Drawing.Point(477, 316);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(114, 37);
            this.VersusLabel.TabIndex = 12;
            this.VersusLabel.Text = "-Versus-";
            // 
            // PuntajeButton
            // 
            this.PuntajeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.PuntajeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PuntajeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PuntajeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PuntajeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntajeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PuntajeButton.Location = new System.Drawing.Point(656, 306);
            this.PuntajeButton.Name = "PuntajeButton";
            this.PuntajeButton.Size = new System.Drawing.Size(115, 62);
            this.PuntajeButton.TabIndex = 13;
            this.PuntajeButton.Text = "Score";
            this.PuntajeButton.UseVisualStyleBackColor = true;
            // 
            // VisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(815, 536);
            this.Controls.Add(this.PuntajeButton);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.Puntaje2Textbox);
            this.Controls.Add(this.Puntaje2Label);
            this.Controls.Add(this.Equipo2Label);
            this.Controls.Add(this.Puntaje1Textbox);
            this.Controls.Add(this.Puntaje1Label);
            this.Controls.Add(this.Equipo1Label);
            this.Controls.Add(this.PartidosListbox);
            this.Controls.Add(this.NoJugadosCheckbox);
            this.Controls.Add(this.RondaCombobox);
            this.Controls.Add(this.RondaLabel);
            this.Controls.Add(this.CampeonatoNombreLabel);
            this.Controls.Add(this.CampeonatoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "VisorForm";
            this.Text = "Visor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CampeonatoLabel;
        private System.Windows.Forms.Label CampeonatoNombreLabel;
        private System.Windows.Forms.Label RondaLabel;
        private System.Windows.Forms.ComboBox RondaCombobox;
        private System.Windows.Forms.CheckBox NoJugadosCheckbox;
        private System.Windows.Forms.ListBox PartidosListbox;
        private System.Windows.Forms.Label Equipo1Label;
        private System.Windows.Forms.Label Puntaje1Label;
        private System.Windows.Forms.TextBox Puntaje1Textbox;
        private System.Windows.Forms.TextBox Puntaje2Textbox;
        private System.Windows.Forms.Label Puntaje2Label;
        private System.Windows.Forms.Label Equipo2Label;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Button PuntajeButton;
    }
}

