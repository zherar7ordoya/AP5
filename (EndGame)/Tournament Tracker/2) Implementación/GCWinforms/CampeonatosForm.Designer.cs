
namespace GCWinforms
{
    partial class CampeonatosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampeonatosForm));
            this.ABMCampeonatosLabel = new System.Windows.Forms.Label();
            this.NombreCampeonatoTextbox = new System.Windows.Forms.TextBox();
            this.NombreCampeonatoLabel = new System.Windows.Forms.Label();
            this.TarifaTextbox = new System.Windows.Forms.TextBox();
            this.TarifaLabel = new System.Windows.Forms.Label();
            this.ElegirEquipoCombobox = new System.Windows.Forms.ComboBox();
            this.ElegirEquipoLabel = new System.Windows.Forms.Label();
            this.CrearNuevoLink = new System.Windows.Forms.LinkLabel();
            this.AgregarEquipoButton = new System.Windows.Forms.Button();
            this.CrearPremioButton = new System.Windows.Forms.Button();
            this.EquiposListbox = new System.Windows.Forms.ListBox();
            this.EquiposLabel = new System.Windows.Forms.Label();
            this.QuitarEquipoButton = new System.Windows.Forms.Button();
            this.QuitarPremioButton = new System.Windows.Forms.Button();
            this.PremiosLabel = new System.Windows.Forms.Label();
            this.PremiosListbox = new System.Windows.Forms.ListBox();
            this.CrearCampeonatoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ABMCampeonatosLabel
            // 
            this.ABMCampeonatosLabel.AutoSize = true;
            this.ABMCampeonatosLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABMCampeonatosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ABMCampeonatosLabel.Location = new System.Drawing.Point(26, 26);
            this.ABMCampeonatosLabel.Name = "ABMCampeonatosLabel";
            this.ABMCampeonatosLabel.Size = new System.Drawing.Size(322, 50);
            this.ABMCampeonatosLabel.TabIndex = 1;
            this.ABMCampeonatosLabel.Text = "ABM Campeonatos";
            // 
            // NombreCampeonatoTextbox
            // 
            this.NombreCampeonatoTextbox.Location = new System.Drawing.Point(35, 143);
            this.NombreCampeonatoTextbox.Name = "NombreCampeonatoTextbox";
            this.NombreCampeonatoTextbox.Size = new System.Drawing.Size(308, 35);
            this.NombreCampeonatoTextbox.TabIndex = 10;
            // 
            // NombreCampeonatoLabel
            // 
            this.NombreCampeonatoLabel.AutoSize = true;
            this.NombreCampeonatoLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCampeonatoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.NombreCampeonatoLabel.Location = new System.Drawing.Point(28, 103);
            this.NombreCampeonatoLabel.Name = "NombreCampeonatoLabel";
            this.NombreCampeonatoLabel.Size = new System.Drawing.Size(320, 37);
            this.NombreCampeonatoLabel.TabIndex = 9;
            this.NombreCampeonatoLabel.Text = "Nombre del Campeonato";
            // 
            // TarifaTextbox
            // 
            this.TarifaTextbox.Location = new System.Drawing.Point(159, 204);
            this.TarifaTextbox.Name = "TarifaTextbox";
            this.TarifaTextbox.Size = new System.Drawing.Size(100, 35);
            this.TarifaTextbox.TabIndex = 12;
            this.TarifaTextbox.Text = "0";
            // 
            // TarifaLabel
            // 
            this.TarifaLabel.AutoSize = true;
            this.TarifaLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarifaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TarifaLabel.Location = new System.Drawing.Point(28, 202);
            this.TarifaLabel.Name = "TarifaLabel";
            this.TarifaLabel.Size = new System.Drawing.Size(80, 37);
            this.TarifaLabel.TabIndex = 11;
            this.TarifaLabel.Text = "Tarifa";
            // 
            // ElegirEquipoCombobox
            // 
            this.ElegirEquipoCombobox.FormattingEnabled = true;
            this.ElegirEquipoCombobox.Location = new System.Drawing.Point(35, 331);
            this.ElegirEquipoCombobox.Name = "ElegirEquipoCombobox";
            this.ElegirEquipoCombobox.Size = new System.Drawing.Size(308, 38);
            this.ElegirEquipoCombobox.TabIndex = 14;
            // 
            // ElegirEquipoLabel
            // 
            this.ElegirEquipoLabel.AutoSize = true;
            this.ElegirEquipoLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElegirEquipoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ElegirEquipoLabel.Location = new System.Drawing.Point(28, 291);
            this.ElegirEquipoLabel.Name = "ElegirEquipoLabel";
            this.ElegirEquipoLabel.Size = new System.Drawing.Size(175, 37);
            this.ElegirEquipoLabel.TabIndex = 13;
            this.ElegirEquipoLabel.Text = "Elegir Equipo";
            // 
            // CrearNuevoLink
            // 
            this.CrearNuevoLink.AutoSize = true;
            this.CrearNuevoLink.Location = new System.Drawing.Point(219, 297);
            this.CrearNuevoLink.Name = "CrearNuevoLink";
            this.CrearNuevoLink.Size = new System.Drawing.Size(129, 30);
            this.CrearNuevoLink.TabIndex = 15;
            this.CrearNuevoLink.TabStop = true;
            this.CrearNuevoLink.Text = "Crear Nuevo";
            // 
            // AgregarEquipoButton
            // 
            this.AgregarEquipoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.AgregarEquipoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AgregarEquipoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AgregarEquipoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarEquipoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarEquipoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AgregarEquipoButton.Location = new System.Drawing.Point(86, 388);
            this.AgregarEquipoButton.Name = "AgregarEquipoButton";
            this.AgregarEquipoButton.Size = new System.Drawing.Size(194, 50);
            this.AgregarEquipoButton.TabIndex = 16;
            this.AgregarEquipoButton.Text = "Agregar Equipo";
            this.AgregarEquipoButton.UseVisualStyleBackColor = true;
            // 
            // CrearPremioButton
            // 
            this.CrearPremioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.CrearPremioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CrearPremioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CrearPremioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearPremioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearPremioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CrearPremioButton.Location = new System.Drawing.Point(86, 470);
            this.CrearPremioButton.Name = "CrearPremioButton";
            this.CrearPremioButton.Size = new System.Drawing.Size(194, 50);
            this.CrearPremioButton.TabIndex = 17;
            this.CrearPremioButton.Text = "Crear Premio";
            this.CrearPremioButton.UseVisualStyleBackColor = true;
            // 
            // EquiposListbox
            // 
            this.EquiposListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EquiposListbox.FormattingEnabled = true;
            this.EquiposListbox.ItemHeight = 30;
            this.EquiposListbox.Location = new System.Drawing.Point(430, 143);
            this.EquiposListbox.Name = "EquiposListbox";
            this.EquiposListbox.Size = new System.Drawing.Size(361, 182);
            this.EquiposListbox.TabIndex = 18;
            // 
            // EquiposLabel
            // 
            this.EquiposLabel.AutoSize = true;
            this.EquiposLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquiposLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EquiposLabel.Location = new System.Drawing.Point(423, 103);
            this.EquiposLabel.Name = "EquiposLabel";
            this.EquiposLabel.Size = new System.Drawing.Size(112, 37);
            this.EquiposLabel.TabIndex = 19;
            this.EquiposLabel.Text = "Equipos";
            // 
            // QuitarEquipoButton
            // 
            this.QuitarEquipoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.QuitarEquipoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.QuitarEquipoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.QuitarEquipoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitarEquipoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitarEquipoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.QuitarEquipoButton.Location = new System.Drawing.Point(808, 187);
            this.QuitarEquipoButton.Name = "QuitarEquipoButton";
            this.QuitarEquipoButton.Size = new System.Drawing.Size(115, 72);
            this.QuitarEquipoButton.TabIndex = 20;
            this.QuitarEquipoButton.Text = "Quitar Equipo";
            this.QuitarEquipoButton.UseVisualStyleBackColor = true;
            // 
            // QuitarPremioButton
            // 
            this.QuitarPremioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.QuitarPremioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.QuitarPremioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.QuitarPremioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitarPremioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitarPremioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.QuitarPremioButton.Location = new System.Drawing.Point(808, 448);
            this.QuitarPremioButton.Name = "QuitarPremioButton";
            this.QuitarPremioButton.Size = new System.Drawing.Size(115, 72);
            this.QuitarPremioButton.TabIndex = 23;
            this.QuitarPremioButton.Text = "Quitar Premio";
            this.QuitarPremioButton.UseVisualStyleBackColor = true;
            // 
            // PremiosLabel
            // 
            this.PremiosLabel.AutoSize = true;
            this.PremiosLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PremiosLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PremiosLabel.Location = new System.Drawing.Point(423, 359);
            this.PremiosLabel.Name = "PremiosLabel";
            this.PremiosLabel.Size = new System.Drawing.Size(112, 37);
            this.PremiosLabel.TabIndex = 22;
            this.PremiosLabel.Text = "Premios";
            // 
            // PremiosListbox
            // 
            this.PremiosListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PremiosListbox.FormattingEnabled = true;
            this.PremiosListbox.ItemHeight = 30;
            this.PremiosListbox.Location = new System.Drawing.Point(430, 399);
            this.PremiosListbox.Name = "PremiosListbox";
            this.PremiosListbox.Size = new System.Drawing.Size(361, 182);
            this.PremiosListbox.TabIndex = 21;
            // 
            // CrearCampeonatoButton
            // 
            this.CrearCampeonatoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(54)))));
            this.CrearCampeonatoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CrearCampeonatoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CrearCampeonatoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearCampeonatoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearCampeonatoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CrearCampeonatoButton.Location = new System.Drawing.Point(310, 627);
            this.CrearCampeonatoButton.Name = "CrearCampeonatoButton";
            this.CrearCampeonatoButton.Size = new System.Drawing.Size(242, 81);
            this.CrearCampeonatoButton.TabIndex = 24;
            this.CrearCampeonatoButton.Text = "Crear Campeonato";
            this.CrearCampeonatoButton.UseVisualStyleBackColor = true;
            // 
            // CampeonatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(951, 745);
            this.Controls.Add(this.CrearCampeonatoButton);
            this.Controls.Add(this.QuitarPremioButton);
            this.Controls.Add(this.PremiosLabel);
            this.Controls.Add(this.PremiosListbox);
            this.Controls.Add(this.QuitarEquipoButton);
            this.Controls.Add(this.EquiposLabel);
            this.Controls.Add(this.EquiposListbox);
            this.Controls.Add(this.CrearPremioButton);
            this.Controls.Add(this.AgregarEquipoButton);
            this.Controls.Add(this.CrearNuevoLink);
            this.Controls.Add(this.ElegirEquipoCombobox);
            this.Controls.Add(this.ElegirEquipoLabel);
            this.Controls.Add(this.TarifaTextbox);
            this.Controls.Add(this.TarifaLabel);
            this.Controls.Add(this.NombreCampeonatoTextbox);
            this.Controls.Add(this.NombreCampeonatoLabel);
            this.Controls.Add(this.ABMCampeonatosLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CampeonatosForm";
            this.Text = "Campeonatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ABMCampeonatosLabel;
        private System.Windows.Forms.TextBox NombreCampeonatoTextbox;
        private System.Windows.Forms.Label NombreCampeonatoLabel;
        private System.Windows.Forms.TextBox TarifaTextbox;
        private System.Windows.Forms.Label TarifaLabel;
        private System.Windows.Forms.ComboBox ElegirEquipoCombobox;
        private System.Windows.Forms.Label ElegirEquipoLabel;
        private System.Windows.Forms.LinkLabel CrearNuevoLink;
        private System.Windows.Forms.Button AgregarEquipoButton;
        private System.Windows.Forms.Button CrearPremioButton;
        private System.Windows.Forms.ListBox EquiposListbox;
        private System.Windows.Forms.Label EquiposLabel;
        private System.Windows.Forms.Button QuitarEquipoButton;
        private System.Windows.Forms.Button QuitarPremioButton;
        private System.Windows.Forms.Label PremiosLabel;
        private System.Windows.Forms.ListBox PremiosListbox;
        private System.Windows.Forms.Button CrearCampeonatoButton;
    }
}