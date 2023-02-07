
namespace UI
{
    partial class FRM_Empleado
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
            this.BajaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.AltaButton = new System.Windows.Forms.Button();
            this.EmpleadoDGV = new System.Windows.Forms.DataGridView();
            this.NombreTextBox = new UI.PlaceHolderTextBox();
            this.LegajoTextBox = new UI.PlaceHolderTextBox();
            this.ApellidoTextBox = new UI.PlaceHolderTextBox();
            this.UsuarioTextBox = new UI.PlaceHolderTextBox();
            this.ContraseñaTextBox = new UI.PlaceHolderTextBox();
            this.DepartamentoIDTextBox = new UI.PlaceHolderTextBox();
            this.RolIDTextBox = new UI.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BajaButton
            // 
            this.BajaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaButton.Location = new System.Drawing.Point(624, 68);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(100, 50);
            this.BajaButton.TabIndex = 2;
            this.BajaButton.Text = "Baja";
            this.BajaButton.UseVisualStyleBackColor = true;
            this.BajaButton.Click += new System.EventHandler(this.BajaButton_Click);
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificacionButton.Location = new System.Drawing.Point(624, 124);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(100, 50);
            this.ModificacionButton.TabIndex = 3;
            this.ModificacionButton.Text = "Modificación";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            this.ModificacionButton.Click += new System.EventHandler(this.ModificacionButton_Click);
            // 
            // AltaButton
            // 
            this.AltaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaButton.Location = new System.Drawing.Point(624, 12);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(100, 50);
            this.AltaButton.TabIndex = 1;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            this.AltaButton.Click += new System.EventHandler(this.AltaButton_Click);
            // 
            // EmpleadoDGV
            // 
            this.EmpleadoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpleadoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadoDGV.Location = new System.Drawing.Point(218, 12);
            this.EmpleadoDGV.Name = "EmpleadoDGV";
            this.EmpleadoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpleadoDGV.Size = new System.Drawing.Size(400, 386);
            this.EmpleadoDGV.TabIndex = 11;
            this.EmpleadoDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpleadoDGV_CellContentClick);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.NombreTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.NombreTextBox.Location = new System.Drawing.Point(12, 68);
            this.NombreTextBox.Multiline = true;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(200, 50);
            this.NombreTextBox.TabIndex = 5;
            this.NombreTextBox.Text = "Nombre";
            this.NombreTextBox.TextoPlaceHolder = "Nombre";
            // 
            // LegajoTextBox
            // 
            this.LegajoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.LegajoTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.LegajoTextBox.Location = new System.Drawing.Point(12, 12);
            this.LegajoTextBox.Multiline = true;
            this.LegajoTextBox.Name = "LegajoTextBox";
            this.LegajoTextBox.Size = new System.Drawing.Size(200, 50);
            this.LegajoTextBox.TabIndex = 4;
            this.LegajoTextBox.Text = "Legajo";
            this.LegajoTextBox.TextoPlaceHolder = "Legajo";
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.ApellidoTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.ApellidoTextBox.Location = new System.Drawing.Point(12, 124);
            this.ApellidoTextBox.Multiline = true;
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(200, 50);
            this.ApellidoTextBox.TabIndex = 6;
            this.ApellidoTextBox.Text = "Apellido";
            this.ApellidoTextBox.TextoPlaceHolder = "Apellido";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.UsuarioTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.UsuarioTextBox.Location = new System.Drawing.Point(12, 180);
            this.UsuarioTextBox.Multiline = true;
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(200, 50);
            this.UsuarioTextBox.TabIndex = 7;
            this.UsuarioTextBox.Text = "Usuario";
            this.UsuarioTextBox.TextoPlaceHolder = "Usuario";
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.ContraseñaTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.ContraseñaTextBox.Location = new System.Drawing.Point(12, 236);
            this.ContraseñaTextBox.Multiline = true;
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(200, 50);
            this.ContraseñaTextBox.TabIndex = 8;
            this.ContraseñaTextBox.Text = "Contraseña";
            this.ContraseñaTextBox.TextoPlaceHolder = "Contraseña";
            // 
            // DepartamentoIDTextBox
            // 
            this.DepartamentoIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.DepartamentoIDTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.DepartamentoIDTextBox.Location = new System.Drawing.Point(12, 292);
            this.DepartamentoIDTextBox.Multiline = true;
            this.DepartamentoIDTextBox.Name = "DepartamentoIDTextBox";
            this.DepartamentoIDTextBox.Size = new System.Drawing.Size(200, 50);
            this.DepartamentoIDTextBox.TabIndex = 9;
            this.DepartamentoIDTextBox.Text = "DepartamentoID";
            this.DepartamentoIDTextBox.TextoPlaceHolder = "DepartamentoID";
            // 
            // RolIDTextBox
            // 
            this.RolIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.RolIDTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.RolIDTextBox.Location = new System.Drawing.Point(12, 348);
            this.RolIDTextBox.Multiline = true;
            this.RolIDTextBox.Name = "RolIDTextBox";
            this.RolIDTextBox.Size = new System.Drawing.Size(200, 50);
            this.RolIDTextBox.TabIndex = 10;
            this.RolIDTextBox.Text = "RolID";
            this.RolIDTextBox.TextoPlaceHolder = "RolID";
            // 
            // FRM_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.RolIDTextBox);
            this.Controls.Add(this.DepartamentoIDTextBox);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.EmpleadoDGV);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.LegajoTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Name = "FRM_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.FRM_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BajaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.DataGridView EmpleadoDGV;
        private PlaceHolderTextBox NombreTextBox;
        private PlaceHolderTextBox LegajoTextBox;
        private PlaceHolderTextBox ApellidoTextBox;
        private PlaceHolderTextBox UsuarioTextBox;
        private PlaceHolderTextBox ContraseñaTextBox;
        private PlaceHolderTextBox DepartamentoIDTextBox;
        private PlaceHolderTextBox RolIDTextBox;
    }
}