
namespace UI
{
    partial class JugadorRegistroForm
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
            this.JugadoresDGV = new System.Windows.Forms.DataGridView();
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.CodigoTextbox = new System.Windows.Forms.TextBox();
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.ApellidoTextbox = new System.Windows.Forms.TextBox();
            this.ApellidoLabel = new System.Windows.Forms.Label();
            this.DniTextbox = new System.Windows.Forms.TextBox();
            this.DniLabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.AltaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.BajaButton = new System.Windows.Forms.Button();
            this.DetalleGroupbox = new System.Windows.Forms.GroupBox();
            this.NacimientoDTP = new System.Windows.Forms.DateTimePicker();
            this.LocalidadTextbox = new System.Windows.Forms.TextBox();
            this.LocalidadLabel = new System.Windows.Forms.Label();
            this.NacimientoLabel = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDGV)).BeginInit();
            this.DetalleGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // JugadoresDGV
            // 
            this.JugadoresDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.JugadoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JugadoresDGV.Location = new System.Drawing.Point(12, 261);
            this.JugadoresDGV.Name = "JugadoresDGV";
            this.JugadoresDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.JugadoresDGV.Size = new System.Drawing.Size(725, 210);
            this.JugadoresDGV.TabIndex = 0;
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoLabel.Location = new System.Drawing.Point(6, 22);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(49, 15);
            this.CodigoLabel.TabIndex = 2;
            this.CodigoLabel.Text = "Código:";
            // 
            // CodigoTextbox
            // 
            this.CodigoTextbox.Enabled = false;
            this.CodigoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoTextbox.Location = new System.Drawing.Point(180, 19);
            this.CodigoTextbox.Name = "CodigoTextbox";
            this.CodigoTextbox.Size = new System.Drawing.Size(75, 21);
            this.CodigoTextbox.TabIndex = 3;
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextbox.Location = new System.Drawing.Point(180, 46);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(125, 21);
            this.NombreTextbox.TabIndex = 4;
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(6, 49);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(55, 15);
            this.NombreLabel.TabIndex = 4;
            this.NombreLabel.Text = "Nombre:";
            // 
            // ApellidoTextbox
            // 
            this.ApellidoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoTextbox.Location = new System.Drawing.Point(180, 73);
            this.ApellidoTextbox.Name = "ApellidoTextbox";
            this.ApellidoTextbox.Size = new System.Drawing.Size(125, 21);
            this.ApellidoTextbox.TabIndex = 5;
            // 
            // ApellidoLabel
            // 
            this.ApellidoLabel.AutoSize = true;
            this.ApellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoLabel.Location = new System.Drawing.Point(6, 76);
            this.ApellidoLabel.Name = "ApellidoLabel";
            this.ApellidoLabel.Size = new System.Drawing.Size(54, 15);
            this.ApellidoLabel.TabIndex = 6;
            this.ApellidoLabel.Text = "Apellido:";
            // 
            // DniTextbox
            // 
            this.DniTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniTextbox.Location = new System.Drawing.Point(180, 100);
            this.DniTextbox.Name = "DniTextbox";
            this.DniTextbox.Size = new System.Drawing.Size(125, 21);
            this.DniTextbox.TabIndex = 6;
            // 
            // DniLabel
            // 
            this.DniLabel.AutoSize = true;
            this.DniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniLabel.Location = new System.Drawing.Point(6, 103);
            this.DniLabel.Name = "DniLabel";
            this.DniLabel.Size = new System.Drawing.Size(31, 15);
            this.DniLabel.TabIndex = 8;
            this.DniLabel.Text = "DNI:";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextbox.Location = new System.Drawing.Point(180, 127);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(400, 21);
            this.EmailTextbox.TabIndex = 7;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(6, 130);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 15);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email:";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(90, 232);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 12;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // AltaButton
            // 
            this.AltaButton.Enabled = false;
            this.AltaButton.Location = new System.Drawing.Point(424, 232);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(75, 23);
            this.AltaButton.TabIndex = 13;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            this.AltaButton.Click += new System.EventHandler(this.AltaButton_Click);
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Location = new System.Drawing.Point(586, 232);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(75, 23);
            this.ModificacionButton.TabIndex = 15;
            this.ModificacionButton.Text = "Modificación";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            this.ModificacionButton.Click += new System.EventHandler(this.ModificacionButton_Click);
            // 
            // BajaButton
            // 
            this.BajaButton.Location = new System.Drawing.Point(505, 232);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(75, 23);
            this.BajaButton.TabIndex = 14;
            this.BajaButton.Text = "Baja";
            this.BajaButton.UseVisualStyleBackColor = true;
            this.BajaButton.Click += new System.EventHandler(this.BajaButton_Click);
            // 
            // DetalleGroupbox
            // 
            this.DetalleGroupbox.Controls.Add(this.NacimientoDTP);
            this.DetalleGroupbox.Controls.Add(this.LocalidadTextbox);
            this.DetalleGroupbox.Controls.Add(this.LocalidadLabel);
            this.DetalleGroupbox.Controls.Add(this.NacimientoLabel);
            this.DetalleGroupbox.Controls.Add(this.EmailTextbox);
            this.DetalleGroupbox.Controls.Add(this.EmailLabel);
            this.DetalleGroupbox.Controls.Add(this.DniTextbox);
            this.DetalleGroupbox.Controls.Add(this.DniLabel);
            this.DetalleGroupbox.Controls.Add(this.ApellidoTextbox);
            this.DetalleGroupbox.Controls.Add(this.ApellidoLabel);
            this.DetalleGroupbox.Controls.Add(this.NombreTextbox);
            this.DetalleGroupbox.Controls.Add(this.NombreLabel);
            this.DetalleGroupbox.Controls.Add(this.CodigoTextbox);
            this.DetalleGroupbox.Controls.Add(this.CodigoLabel);
            this.DetalleGroupbox.Location = new System.Drawing.Point(81, 12);
            this.DetalleGroupbox.Name = "DetalleGroupbox";
            this.DetalleGroupbox.Size = new System.Drawing.Size(591, 214);
            this.DetalleGroupbox.TabIndex = 16;
            this.DetalleGroupbox.TabStop = false;
            this.DetalleGroupbox.Text = "Datos del Jugador";
            // 
            // NacimientoDTP
            // 
            this.NacimientoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NacimientoDTP.Location = new System.Drawing.Point(180, 154);
            this.NacimientoDTP.Name = "NacimientoDTP";
            this.NacimientoDTP.Size = new System.Drawing.Size(100, 20);
            this.NacimientoDTP.TabIndex = 8;
            // 
            // LocalidadTextbox
            // 
            this.LocalidadTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalidadTextbox.Location = new System.Drawing.Point(180, 180);
            this.LocalidadTextbox.Name = "LocalidadTextbox";
            this.LocalidadTextbox.Size = new System.Drawing.Size(400, 21);
            this.LocalidadTextbox.TabIndex = 9;
            // 
            // LocalidadLabel
            // 
            this.LocalidadLabel.AutoSize = true;
            this.LocalidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalidadLabel.Location = new System.Drawing.Point(6, 183);
            this.LocalidadLabel.Name = "LocalidadLabel";
            this.LocalidadLabel.Size = new System.Drawing.Size(146, 15);
            this.LocalidadLabel.TabIndex = 14;
            this.LocalidadLabel.Text = "Localidad de Residencia:";
            // 
            // NacimientoLabel
            // 
            this.NacimientoLabel.AutoSize = true;
            this.NacimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NacimientoLabel.Location = new System.Drawing.Point(6, 158);
            this.NacimientoLabel.Name = "NacimientoLabel";
            this.NacimientoLabel.Size = new System.Drawing.Size(127, 15);
            this.NacimientoLabel.TabIndex = 12;
            this.NacimientoLabel.Text = "Fecha de Nacimiento:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(171, 232);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 17;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // JugadorRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 498);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.DetalleGroupbox);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.JugadoresDGV);
            this.Name = "JugadorRegistroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Jugadores";
            this.Load += new System.EventHandler(this.JugadorRegistroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDGV)).EndInit();
            this.DetalleGroupbox.ResumeLayout(false);
            this.DetalleGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView JugadoresDGV;
        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.TextBox CodigoTextbox;
        private System.Windows.Forms.TextBox NombreTextbox;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox ApellidoTextbox;
        private System.Windows.Forms.Label ApellidoLabel;
        private System.Windows.Forms.TextBox DniTextbox;
        private System.Windows.Forms.Label DniLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Button BajaButton;
        private System.Windows.Forms.GroupBox DetalleGroupbox;
        private System.Windows.Forms.DateTimePicker NacimientoDTP;
        private System.Windows.Forms.TextBox LocalidadTextbox;
        private System.Windows.Forms.Label LocalidadLabel;
        private System.Windows.Forms.Label NacimientoLabel;
        private System.Windows.Forms.Button CancelarButton;
    }
}

