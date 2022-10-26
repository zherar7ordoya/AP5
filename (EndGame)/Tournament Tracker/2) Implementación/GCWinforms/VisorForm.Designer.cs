
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
            this.PartidosListbox = new ReaLTaiizor.Controls.MaterialListBox();
            this.NoJugadosCheckbox = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.Puntaje2Textbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.Equipo2Label = new ReaLTaiizor.Controls.MaterialLabel();
            this.Equipo1Label = new ReaLTaiizor.Controls.MaterialLabel();
            this.Puntaje1Textbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.PuntajeButton = new ReaLTaiizor.Controls.MaterialButton();
            this.RondaLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.RondaCombobox = new ReaLTaiizor.Controls.MaterialComboBox();
            this.CampeonatoLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.CampeonatoNombreLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // PartidosListbox
            // 
            this.PartidosListbox.BackColor = System.Drawing.Color.White;
            this.PartidosListbox.BorderColor = System.Drawing.Color.LightGray;
            this.PartidosListbox.Depth = 0;
            this.PartidosListbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PartidosListbox.Location = new System.Drawing.Point(8, 199);
            this.PartidosListbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.PartidosListbox.Name = "PartidosListbox";
            this.PartidosListbox.SelectedIndex = -1;
            this.PartidosListbox.SelectedItem = null;
            this.PartidosListbox.Size = new System.Drawing.Size(223, 223);
            this.PartidosListbox.TabIndex = 14;
            // 
            // NoJugadosCheckbox
            // 
            this.NoJugadosCheckbox.AutoSize = true;
            this.NoJugadosCheckbox.Depth = 0;
            this.NoJugadosCheckbox.Location = new System.Drawing.Point(234, 147);
            this.NoJugadosCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.NoJugadosCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.NoJugadosCheckbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.NoJugadosCheckbox.Name = "NoJugadosCheckbox";
            this.NoJugadosCheckbox.ReadOnly = false;
            this.NoJugadosCheckbox.Ripple = true;
            this.NoJugadosCheckbox.Size = new System.Drawing.Size(121, 37);
            this.NoJugadosCheckbox.TabIndex = 15;
            this.NoJugadosCheckbox.Text = "No Jugados";
            this.NoJugadosCheckbox.UseAccentColor = false;
            this.NoJugadosCheckbox.UseVisualStyleBackColor = true;
            // 
            // Puntaje2Textbox
            // 
            this.Puntaje2Textbox.AnimateReadOnly = false;
            this.Puntaje2Textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Puntaje2Textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Puntaje2Textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Puntaje2Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Puntaje2Textbox.Depth = 0;
            this.Puntaje2Textbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Puntaje2Textbox.HideSelection = true;
            this.Puntaje2Textbox.LeadingIcon = null;
            this.Puntaje2Textbox.Location = new System.Drawing.Point(363, 329);
            this.Puntaje2Textbox.MaxLength = 32767;
            this.Puntaje2Textbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Puntaje2Textbox.Name = "Puntaje2Textbox";
            this.Puntaje2Textbox.PasswordChar = '\0';
            this.Puntaje2Textbox.PrefixSuffixText = null;
            this.Puntaje2Textbox.ReadOnly = false;
            this.Puntaje2Textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Puntaje2Textbox.SelectedText = "";
            this.Puntaje2Textbox.SelectionLength = 0;
            this.Puntaje2Textbox.SelectionStart = 0;
            this.Puntaje2Textbox.ShortcutsEnabled = true;
            this.Puntaje2Textbox.Size = new System.Drawing.Size(250, 48);
            this.Puntaje2Textbox.TabIndex = 16;
            this.Puntaje2Textbox.TabStop = false;
            this.Puntaje2Textbox.Text = "Puntaje";
            this.Puntaje2Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Puntaje2Textbox.TrailingIcon = null;
            this.Puntaje2Textbox.UseSystemPasswordChar = false;
            // 
            // Equipo2Label
            // 
            this.Equipo2Label.AutoSize = true;
            this.Equipo2Label.Depth = 0;
            this.Equipo2Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Equipo2Label.Location = new System.Drawing.Point(278, 329);
            this.Equipo2Label.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.Equipo2Label.Name = "Equipo2Label";
            this.Equipo2Label.Size = new System.Drawing.Size(79, 19);
            this.Equipo2Label.TabIndex = 17;
            this.Equipo2Label.Text = "<Equipo 2>";
            // 
            // Equipo1Label
            // 
            this.Equipo1Label.AutoSize = true;
            this.Equipo1Label.Depth = 0;
            this.Equipo1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Equipo1Label.Location = new System.Drawing.Point(278, 275);
            this.Equipo1Label.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.Equipo1Label.Name = "Equipo1Label";
            this.Equipo1Label.Size = new System.Drawing.Size(79, 19);
            this.Equipo1Label.TabIndex = 19;
            this.Equipo1Label.Text = "<Equipo 1>";
            // 
            // Puntaje1Textbox
            // 
            this.Puntaje1Textbox.AnimateReadOnly = false;
            this.Puntaje1Textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Puntaje1Textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Puntaje1Textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Puntaje1Textbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Puntaje1Textbox.Depth = 0;
            this.Puntaje1Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Puntaje1Textbox.HideSelection = true;
            this.Puntaje1Textbox.LeadingIcon = null;
            this.Puntaje1Textbox.Location = new System.Drawing.Point(363, 275);
            this.Puntaje1Textbox.MaxLength = 32767;
            this.Puntaje1Textbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Puntaje1Textbox.Name = "Puntaje1Textbox";
            this.Puntaje1Textbox.PasswordChar = '\0';
            this.Puntaje1Textbox.PrefixSuffixText = null;
            this.Puntaje1Textbox.ReadOnly = false;
            this.Puntaje1Textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Puntaje1Textbox.SelectedText = "";
            this.Puntaje1Textbox.SelectionLength = 0;
            this.Puntaje1Textbox.SelectionStart = 0;
            this.Puntaje1Textbox.ShortcutsEnabled = true;
            this.Puntaje1Textbox.Size = new System.Drawing.Size(250, 48);
            this.Puntaje1Textbox.TabIndex = 18;
            this.Puntaje1Textbox.TabStop = false;
            this.Puntaje1Textbox.Text = "Puntaje";
            this.Puntaje1Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Puntaje1Textbox.TrailingIcon = null;
            this.Puntaje1Textbox.UseSystemPasswordChar = false;
            // 
            // PuntajeButton
            // 
            this.PuntajeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PuntajeButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PuntajeButton.Depth = 0;
            this.PuntajeButton.HighEmphasis = true;
            this.PuntajeButton.Icon = null;
            this.PuntajeButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.PuntajeButton.Location = new System.Drawing.Point(527, 386);
            this.PuntajeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PuntajeButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.PuntajeButton.Name = "PuntajeButton";
            this.PuntajeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PuntajeButton.Size = new System.Drawing.Size(86, 36);
            this.PuntajeButton.TabIndex = 20;
            this.PuntajeButton.Text = "Puntaje";
            this.PuntajeButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PuntajeButton.UseAccentColor = false;
            this.PuntajeButton.UseVisualStyleBackColor = true;
            // 
            // RondaLabel
            // 
            this.RondaLabel.AutoSize = true;
            this.RondaLabel.Depth = 0;
            this.RondaLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RondaLabel.Location = new System.Drawing.Point(5, 147);
            this.RondaLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.RondaLabel.Name = "RondaLabel";
            this.RondaLabel.Size = new System.Drawing.Size(47, 19);
            this.RondaLabel.TabIndex = 21;
            this.RondaLabel.Text = "Ronda";
            // 
            // RondaCombobox
            // 
            this.RondaCombobox.AutoResize = false;
            this.RondaCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RondaCombobox.Depth = 0;
            this.RondaCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.RondaCombobox.DropDownHeight = 174;
            this.RondaCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RondaCombobox.DropDownWidth = 121;
            this.RondaCombobox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RondaCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RondaCombobox.FormattingEnabled = true;
            this.RondaCombobox.IntegralHeight = false;
            this.RondaCombobox.ItemHeight = 43;
            this.RondaCombobox.Location = new System.Drawing.Point(110, 144);
            this.RondaCombobox.MaxDropDownItems = 4;
            this.RondaCombobox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.RondaCombobox.Name = "RondaCombobox";
            this.RondaCombobox.Size = new System.Drawing.Size(121, 49);
            this.RondaCombobox.StartIndex = 0;
            this.RondaCombobox.TabIndex = 22;
            // 
            // CampeonatoLabel
            // 
            this.CampeonatoLabel.AutoSize = true;
            this.CampeonatoLabel.Depth = 0;
            this.CampeonatoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CampeonatoLabel.Location = new System.Drawing.Point(5, 87);
            this.CampeonatoLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CampeonatoLabel.Name = "CampeonatoLabel";
            this.CampeonatoLabel.Size = new System.Drawing.Size(96, 19);
            this.CampeonatoLabel.TabIndex = 23;
            this.CampeonatoLabel.Text = "Campeonato:";
            // 
            // CampeonatoNombreLabel
            // 
            this.CampeonatoNombreLabel.AutoSize = true;
            this.CampeonatoNombreLabel.Depth = 0;
            this.CampeonatoNombreLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CampeonatoNombreLabel.Location = new System.Drawing.Point(107, 87);
            this.CampeonatoNombreLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CampeonatoNombreLabel.Name = "CampeonatoNombreLabel";
            this.CampeonatoNombreLabel.Size = new System.Drawing.Size(73, 19);
            this.CampeonatoNombreLabel.TabIndex = 24;
            this.CampeonatoNombreLabel.Text = "<Nombre>";
            // 
            // VisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(640, 443);
            this.Controls.Add(this.CampeonatoNombreLabel);
            this.Controls.Add(this.CampeonatoLabel);
            this.Controls.Add(this.RondaCombobox);
            this.Controls.Add(this.RondaLabel);
            this.Controls.Add(this.PuntajeButton);
            this.Controls.Add(this.Equipo1Label);
            this.Controls.Add(this.Puntaje1Textbox);
            this.Controls.Add(this.Equipo2Label);
            this.Controls.Add(this.Puntaje2Textbox);
            this.Controls.Add(this.NoJugadosCheckbox);
            this.Controls.Add(this.PartidosListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisorForm";
            this.Padding = new System.Windows.Forms.Padding(2, 28, 2, 1);
            this.Text = "Visor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialListBox PartidosListbox;
        private ReaLTaiizor.Controls.MaterialCheckBox NoJugadosCheckbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit Puntaje2Textbox;
        private ReaLTaiizor.Controls.MaterialLabel Equipo2Label;
        private ReaLTaiizor.Controls.MaterialLabel Equipo1Label;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit Puntaje1Textbox;
        private ReaLTaiizor.Controls.MaterialButton PuntajeButton;
        private ReaLTaiizor.Controls.MaterialLabel RondaLabel;
        private ReaLTaiizor.Controls.MaterialComboBox RondaCombobox;
        private ReaLTaiizor.Controls.MaterialLabel CampeonatoLabel;
        private ReaLTaiizor.Controls.MaterialLabel CampeonatoNombreLabel;
    }
}

