
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
            this.NumeroPuestoCombobox = new ReaLTaiizor.Controls.MaterialComboBox();
            this.NumeroPuestoLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.NombrePuestoTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.MontoPremioTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.PorcentajePremioTextbox = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.CrearPremioButton = new ReaLTaiizor.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // NumeroPuestoCombobox
            // 
            this.NumeroPuestoCombobox.AutoResize = false;
            this.NumeroPuestoCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NumeroPuestoCombobox.Depth = 0;
            this.NumeroPuestoCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.NumeroPuestoCombobox.DropDownHeight = 174;
            this.NumeroPuestoCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumeroPuestoCombobox.DropDownWidth = 121;
            this.NumeroPuestoCombobox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.NumeroPuestoCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumeroPuestoCombobox.FormattingEnabled = true;
            this.NumeroPuestoCombobox.IntegralHeight = false;
            this.NumeroPuestoCombobox.ItemHeight = 43;
            this.NumeroPuestoCombobox.Location = new System.Drawing.Point(6, 111);
            this.NumeroPuestoCombobox.MaxDropDownItems = 4;
            this.NumeroPuestoCombobox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.NumeroPuestoCombobox.Name = "NumeroPuestoCombobox";
            this.NumeroPuestoCombobox.Size = new System.Drawing.Size(121, 49);
            this.NumeroPuestoCombobox.StartIndex = 0;
            this.NumeroPuestoCombobox.TabIndex = 49;
            // 
            // NumeroPuestoLabel
            // 
            this.NumeroPuestoLabel.AutoSize = true;
            this.NumeroPuestoLabel.Depth = 0;
            this.NumeroPuestoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NumeroPuestoLabel.Location = new System.Drawing.Point(6, 89);
            this.NumeroPuestoLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.NumeroPuestoLabel.Name = "NumeroPuestoLabel";
            this.NumeroPuestoLabel.Size = new System.Drawing.Size(131, 19);
            this.NumeroPuestoLabel.TabIndex = 50;
            this.NumeroPuestoLabel.Text = "Número de Puesto";
            // 
            // NombrePuestoTextbox
            // 
            this.NombrePuestoTextbox.AnimateReadOnly = false;
            this.NombrePuestoTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NombrePuestoTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NombrePuestoTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NombrePuestoTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NombrePuestoTextbox.Depth = 0;
            this.NombrePuestoTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NombrePuestoTextbox.HideSelection = true;
            this.NombrePuestoTextbox.LeadingIcon = null;
            this.NombrePuestoTextbox.Location = new System.Drawing.Point(9, 179);
            this.NombrePuestoTextbox.MaxLength = 32767;
            this.NombrePuestoTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.NombrePuestoTextbox.Name = "NombrePuestoTextbox";
            this.NombrePuestoTextbox.PasswordChar = '\0';
            this.NombrePuestoTextbox.PrefixSuffixText = null;
            this.NombrePuestoTextbox.ReadOnly = false;
            this.NombrePuestoTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NombrePuestoTextbox.SelectedText = "";
            this.NombrePuestoTextbox.SelectionLength = 0;
            this.NombrePuestoTextbox.SelectionStart = 0;
            this.NombrePuestoTextbox.ShortcutsEnabled = true;
            this.NombrePuestoTextbox.Size = new System.Drawing.Size(250, 48);
            this.NombrePuestoTextbox.TabIndex = 54;
            this.NombrePuestoTextbox.TabStop = false;
            this.NombrePuestoTextbox.Text = "Nombre del Puesto";
            this.NombrePuestoTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NombrePuestoTextbox.TrailingIcon = null;
            this.NombrePuestoTextbox.UseSystemPasswordChar = false;
            // 
            // MontoPremioTextbox
            // 
            this.MontoPremioTextbox.AnimateReadOnly = false;
            this.MontoPremioTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MontoPremioTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MontoPremioTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MontoPremioTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MontoPremioTextbox.Depth = 0;
            this.MontoPremioTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MontoPremioTextbox.HideSelection = true;
            this.MontoPremioTextbox.LeadingIcon = null;
            this.MontoPremioTextbox.Location = new System.Drawing.Point(9, 256);
            this.MontoPremioTextbox.MaxLength = 32767;
            this.MontoPremioTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.MontoPremioTextbox.Name = "MontoPremioTextbox";
            this.MontoPremioTextbox.PasswordChar = '\0';
            this.MontoPremioTextbox.PrefixSuffixText = null;
            this.MontoPremioTextbox.ReadOnly = false;
            this.MontoPremioTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MontoPremioTextbox.SelectedText = "";
            this.MontoPremioTextbox.SelectionLength = 0;
            this.MontoPremioTextbox.SelectionStart = 0;
            this.MontoPremioTextbox.ShortcutsEnabled = true;
            this.MontoPremioTextbox.Size = new System.Drawing.Size(250, 48);
            this.MontoPremioTextbox.TabIndex = 55;
            this.MontoPremioTextbox.TabStop = false;
            this.MontoPremioTextbox.Text = "Monto del Premio";
            this.MontoPremioTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MontoPremioTextbox.TrailingIcon = null;
            this.MontoPremioTextbox.UseSystemPasswordChar = false;
            // 
            // PorcentajePremioTextbox
            // 
            this.PorcentajePremioTextbox.AnimateReadOnly = false;
            this.PorcentajePremioTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PorcentajePremioTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PorcentajePremioTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PorcentajePremioTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PorcentajePremioTextbox.Depth = 0;
            this.PorcentajePremioTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PorcentajePremioTextbox.HideSelection = true;
            this.PorcentajePremioTextbox.LeadingIcon = null;
            this.PorcentajePremioTextbox.Location = new System.Drawing.Point(9, 332);
            this.PorcentajePremioTextbox.MaxLength = 32767;
            this.PorcentajePremioTextbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.PorcentajePremioTextbox.Name = "PorcentajePremioTextbox";
            this.PorcentajePremioTextbox.PasswordChar = '\0';
            this.PorcentajePremioTextbox.PrefixSuffixText = null;
            this.PorcentajePremioTextbox.ReadOnly = false;
            this.PorcentajePremioTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PorcentajePremioTextbox.SelectedText = "";
            this.PorcentajePremioTextbox.SelectionLength = 0;
            this.PorcentajePremioTextbox.SelectionStart = 0;
            this.PorcentajePremioTextbox.ShortcutsEnabled = true;
            this.PorcentajePremioTextbox.Size = new System.Drawing.Size(250, 48);
            this.PorcentajePremioTextbox.TabIndex = 56;
            this.PorcentajePremioTextbox.TabStop = false;
            this.PorcentajePremioTextbox.Text = "Porcentaje del Premio";
            this.PorcentajePremioTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PorcentajePremioTextbox.TrailingIcon = null;
            this.PorcentajePremioTextbox.UseSystemPasswordChar = false;
            // 
            // CrearPremioButton
            // 
            this.CrearPremioButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearPremioButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CrearPremioButton.Depth = 0;
            this.CrearPremioButton.HighEmphasis = true;
            this.CrearPremioButton.Icon = null;
            this.CrearPremioButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.CrearPremioButton.Location = new System.Drawing.Point(66, 418);
            this.CrearPremioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearPremioButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.CrearPremioButton.Name = "CrearPremioButton";
            this.CrearPremioButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CrearPremioButton.Size = new System.Drawing.Size(125, 36);
            this.CrearPremioButton.TabIndex = 57;
            this.CrearPremioButton.Text = "Crear Premio";
            this.CrearPremioButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CrearPremioButton.UseAccentColor = false;
            this.CrearPremioButton.UseVisualStyleBackColor = true;
            // 
            // PremiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 487);
            this.Controls.Add(this.CrearPremioButton);
            this.Controls.Add(this.PorcentajePremioTextbox);
            this.Controls.Add(this.MontoPremioTextbox);
            this.Controls.Add(this.NombrePuestoTextbox);
            this.Controls.Add(this.NumeroPuestoLabel);
            this.Controls.Add(this.NumeroPuestoCombobox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PremiosForm";
            this.Text = "Premios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox NumeroPuestoCombobox;
        private ReaLTaiizor.Controls.MaterialLabel NumeroPuestoLabel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit NombrePuestoTextbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit MontoPremioTextbox;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit PorcentajePremioTextbox;
        private ReaLTaiizor.Controls.MaterialButton CrearPremioButton;
    }
}