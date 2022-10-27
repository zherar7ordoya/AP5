
namespace GCWinforms
{
    partial class PremiosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PremiosForm));
            this.NombreTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.CrearPremioButton = new ReaLTaiizor.Controls.MaterialButton();
            this.PosicionTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.PosiciónLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.NombreLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.PremioGroupbox = new System.Windows.Forms.GroupBox();
            this.PorcentajeCombobox = new ReaLTaiizor.Controls.MaterialComboBox();
            this.PorcentajeRadio = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.MontoRadio = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.MontoTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.PremioGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.AnimateReadOnly = false;
            this.NombreTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NombreTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NombreTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NombreTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NombreTextbox.Depth = 0;
            this.NombreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombreTextbox.HideSelection = true;
            this.NombreTextbox.LeadingIcon = null;
            this.NombreTextbox.Location = new System.Drawing.Point(98, 142);
            this.NombreTextbox.MaxLength = 32767;
            this.NombreTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.PasswordChar = '\0';
            this.NombreTextbox.PrefixSuffixText = null;
            this.NombreTextbox.ReadOnly = false;
            this.NombreTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NombreTextbox.SelectedText = "";
            this.NombreTextbox.SelectionLength = 0;
            this.NombreTextbox.SelectionStart = 0;
            this.NombreTextbox.ShortcutsEnabled = true;
            this.NombreTextbox.Size = new System.Drawing.Size(250, 48);
            this.NombreTextbox.TabIndex = 1;
            this.NombreTextbox.TabStop = false;
            this.NombreTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NombreTextbox.TrailingIcon = null;
            this.NombreTextbox.UseSystemPasswordChar = false;
            // 
            // CrearPremioButton
            // 
            this.CrearPremioButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearPremioButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CrearPremioButton.Depth = 0;
            this.CrearPremioButton.HighEmphasis = true;
            this.CrearPremioButton.Icon = null;
            this.CrearPremioButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.CrearPremioButton.Location = new System.Drawing.Point(128, 414);
            this.CrearPremioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearPremioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CrearPremioButton.Name = "CrearPremioButton";
            this.CrearPremioButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CrearPremioButton.Size = new System.Drawing.Size(125, 36);
            this.CrearPremioButton.TabIndex = 6;
            this.CrearPremioButton.Text = "Crear Premio";
            this.CrearPremioButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CrearPremioButton.UseAccentColor = false;
            this.CrearPremioButton.UseVisualStyleBackColor = true;
            this.CrearPremioButton.Click += new System.EventHandler(this.CrearPremioButton_Click);
            // 
            // PosicionTextbox
            // 
            this.PosicionTextbox.AnimateReadOnly = false;
            this.PosicionTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PosicionTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PosicionTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PosicionTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PosicionTextbox.Depth = 0;
            this.PosicionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PosicionTextbox.HideSelection = true;
            this.PosicionTextbox.LeadingIcon = null;
            this.PosicionTextbox.Location = new System.Drawing.Point(98, 88);
            this.PosicionTextbox.MaxLength = 32767;
            this.PosicionTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.PosicionTextbox.Name = "PosicionTextbox";
            this.PosicionTextbox.PasswordChar = '\0';
            this.PosicionTextbox.PrefixSuffixText = null;
            this.PosicionTextbox.ReadOnly = false;
            this.PosicionTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PosicionTextbox.SelectedText = "";
            this.PosicionTextbox.SelectionLength = 0;
            this.PosicionTextbox.SelectionStart = 0;
            this.PosicionTextbox.ShortcutsEnabled = true;
            this.PosicionTextbox.Size = new System.Drawing.Size(250, 48);
            this.PosicionTextbox.TabIndex = 0;
            this.PosicionTextbox.TabStop = false;
            this.PosicionTextbox.Text = "0";
            this.PosicionTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PosicionTextbox.TrailingIcon = null;
            this.PosicionTextbox.UseSystemPasswordChar = false;
            // 
            // PosiciónLabel
            // 
            this.PosiciónLabel.AutoSize = true;
            this.PosiciónLabel.Depth = 0;
            this.PosiciónLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PosiciónLabel.Location = new System.Drawing.Point(30, 101);
            this.PosiciónLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.PosiciónLabel.Name = "PosiciónLabel";
            this.PosiciónLabel.Size = new System.Drawing.Size(62, 19);
            this.PosiciónLabel.TabIndex = 80;
            this.PosiciónLabel.Text = "Posición";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Depth = 0;
            this.NombreLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombreLabel.Location = new System.Drawing.Point(30, 157);
            this.NombreLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(57, 19);
            this.NombreLabel.TabIndex = 81;
            this.NombreLabel.Text = "Nombre";
            // 
            // PremioGroupbox
            // 
            this.PremioGroupbox.Controls.Add(this.PorcentajeCombobox);
            this.PremioGroupbox.Controls.Add(this.PorcentajeRadio);
            this.PremioGroupbox.Controls.Add(this.MontoRadio);
            this.PremioGroupbox.Controls.Add(this.MontoTextbox);
            this.PremioGroupbox.Location = new System.Drawing.Point(33, 216);
            this.PremioGroupbox.Name = "PremioGroupbox";
            this.PremioGroupbox.Size = new System.Drawing.Size(315, 163);
            this.PremioGroupbox.TabIndex = 82;
            this.PremioGroupbox.TabStop = false;
            this.PremioGroupbox.Text = "Premio";
            // 
            // PorcentajeCombobox
            // 
            this.PorcentajeCombobox.AutoResize = false;
            this.PorcentajeCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PorcentajeCombobox.Depth = 0;
            this.PorcentajeCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PorcentajeCombobox.DropDownHeight = 174;
            this.PorcentajeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PorcentajeCombobox.DropDownWidth = 121;
            this.PorcentajeCombobox.Enabled = false;
            this.PorcentajeCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.PorcentajeCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PorcentajeCombobox.FormattingEnabled = true;
            this.PorcentajeCombobox.IntegralHeight = false;
            this.PorcentajeCombobox.ItemHeight = 43;
            this.PorcentajeCombobox.Items.AddRange(new object[] {
            "0"});
            this.PorcentajeCombobox.Location = new System.Drawing.Point(159, 88);
            this.PorcentajeCombobox.MaxDropDownItems = 4;
            this.PorcentajeCombobox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.PorcentajeCombobox.Name = "PorcentajeCombobox";
            this.PorcentajeCombobox.Size = new System.Drawing.Size(121, 49);
            this.PorcentajeCombobox.StartIndex = 0;
            this.PorcentajeCombobox.TabIndex = 5;
            // 
            // PorcentajeRadio
            // 
            this.PorcentajeRadio.AutoSize = true;
            this.PorcentajeRadio.BackColor = System.Drawing.Color.Transparent;
            this.PorcentajeRadio.Depth = 0;
            this.PorcentajeRadio.Location = new System.Drawing.Point(18, 100);
            this.PorcentajeRadio.Margin = new System.Windows.Forms.Padding(0);
            this.PorcentajeRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PorcentajeRadio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.PorcentajeRadio.Name = "PorcentajeRadio";
            this.PorcentajeRadio.Ripple = true;
            this.PorcentajeRadio.Size = new System.Drawing.Size(110, 37);
            this.PorcentajeRadio.TabIndex = 4;
            this.PorcentajeRadio.TabStop = true;
            this.PorcentajeRadio.Text = "Porcentaje";
            this.PorcentajeRadio.UseAccentColor = false;
            this.PorcentajeRadio.UseVisualStyleBackColor = false;
            this.PorcentajeRadio.CheckedChanged += new System.EventHandler(this.PorcentajeRadio_CheckedChanged);
            // 
            // MontoRadio
            // 
            this.MontoRadio.AutoSize = true;
            this.MontoRadio.Checked = true;
            this.MontoRadio.Depth = 0;
            this.MontoRadio.Location = new System.Drawing.Point(18, 45);
            this.MontoRadio.Margin = new System.Windows.Forms.Padding(0);
            this.MontoRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MontoRadio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.MontoRadio.Name = "MontoRadio";
            this.MontoRadio.Ripple = true;
            this.MontoRadio.Size = new System.Drawing.Size(81, 37);
            this.MontoRadio.TabIndex = 2;
            this.MontoRadio.TabStop = true;
            this.MontoRadio.Text = "Monto";
            this.MontoRadio.UseAccentColor = false;
            this.MontoRadio.UseVisualStyleBackColor = true;
            this.MontoRadio.CheckedChanged += new System.EventHandler(this.MontoRadio_CheckedChanged);
            // 
            // MontoTextbox
            // 
            this.MontoTextbox.AnimateReadOnly = false;
            this.MontoTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MontoTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MontoTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MontoTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MontoTextbox.Depth = 0;
            this.MontoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MontoTextbox.HideSelection = true;
            this.MontoTextbox.LeadingIcon = null;
            this.MontoTextbox.Location = new System.Drawing.Point(159, 34);
            this.MontoTextbox.MaxLength = 32767;
            this.MontoTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.MontoTextbox.Name = "MontoTextbox";
            this.MontoTextbox.PasswordChar = '\0';
            this.MontoTextbox.PrefixSuffixText = null;
            this.MontoTextbox.ReadOnly = false;
            this.MontoTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MontoTextbox.SelectedText = "";
            this.MontoTextbox.SelectionLength = 0;
            this.MontoTextbox.SelectionStart = 0;
            this.MontoTextbox.ShortcutsEnabled = true;
            this.MontoTextbox.Size = new System.Drawing.Size(121, 48);
            this.MontoTextbox.TabIndex = 3;
            this.MontoTextbox.TabStop = false;
            this.MontoTextbox.Text = "0.00";
            this.MontoTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MontoTextbox.TrailingIcon = null;
            this.MontoTextbox.UseSystemPasswordChar = false;
            // 
            // PremiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 476);
            this.Controls.Add(this.PremioGroupbox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.PosiciónLabel);
            this.Controls.Add(this.PosicionTextbox);
            this.Controls.Add(this.CrearPremioButton);
            this.Controls.Add(this.NombreTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PremiosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Premios";
            this.PremioGroupbox.ResumeLayout(false);
            this.PremioGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit NombreTextbox;
        private ReaLTaiizor.Controls.MaterialButton CrearPremioButton;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit PosicionTextbox;
        private ReaLTaiizor.Controls.MaterialLabel PosiciónLabel;
        private ReaLTaiizor.Controls.MaterialLabel NombreLabel;
        private System.Windows.Forms.GroupBox PremioGroupbox;
        private ReaLTaiizor.Controls.MaterialComboBox PorcentajeCombobox;
        private ReaLTaiizor.Controls.MaterialRadioButton PorcentajeRadio;
        private ReaLTaiizor.Controls.MaterialRadioButton MontoRadio;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit MontoTextbox;
    }
}