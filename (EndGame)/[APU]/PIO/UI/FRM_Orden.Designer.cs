
namespace UI
{
    partial class FRM_Orden
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
            this.EstadoTextBox = new UI.PlaceHolderTextBox();
            this.BajaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.AltaButton = new System.Windows.Forms.Button();
            this.OrdenDGV = new System.Windows.Forms.DataGridView();
            this.LegajoTextBox = new UI.PlaceHolderTextBox();
            this.OrdenIDTextBox = new UI.PlaceHolderTextBox();
            this.FechaTextBox = new UI.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EstadoTextBox
            // 
            this.EstadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.EstadoTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.EstadoTextBox.Location = new System.Drawing.Point(12, 180);
            this.EstadoTextBox.Multiline = true;
            this.EstadoTextBox.Name = "EstadoTextBox";
            this.EstadoTextBox.Size = new System.Drawing.Size(200, 50);
            this.EstadoTextBox.TabIndex = 29;
            this.EstadoTextBox.Text = "Estado";
            this.EstadoTextBox.TextoPlaceHolder = "Estado";
            // 
            // BajaButton
            // 
            this.BajaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaButton.Location = new System.Drawing.Point(624, 68);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(100, 50);
            this.BajaButton.TabIndex = 24;
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
            this.ModificacionButton.TabIndex = 25;
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
            this.AltaButton.TabIndex = 23;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            this.AltaButton.Click += new System.EventHandler(this.AltaButton_Click);
            // 
            // OrdenDGV
            // 
            this.OrdenDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdenDGV.Location = new System.Drawing.Point(218, 12);
            this.OrdenDGV.Name = "OrdenDGV";
            this.OrdenDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdenDGV.Size = new System.Drawing.Size(400, 218);
            this.OrdenDGV.TabIndex = 32;
            this.OrdenDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdenDGV_CellContentClick);
            // 
            // LegajoTextBox
            // 
            this.LegajoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.LegajoTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.LegajoTextBox.Location = new System.Drawing.Point(12, 68);
            this.LegajoTextBox.Multiline = true;
            this.LegajoTextBox.Name = "LegajoTextBox";
            this.LegajoTextBox.Size = new System.Drawing.Size(200, 50);
            this.LegajoTextBox.TabIndex = 27;
            this.LegajoTextBox.Text = "Legajo";
            this.LegajoTextBox.TextoPlaceHolder = "Legajo";
            // 
            // OrdenIDTextBox
            // 
            this.OrdenIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.OrdenIDTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.OrdenIDTextBox.Location = new System.Drawing.Point(12, 12);
            this.OrdenIDTextBox.Multiline = true;
            this.OrdenIDTextBox.Name = "OrdenIDTextBox";
            this.OrdenIDTextBox.Size = new System.Drawing.Size(200, 50);
            this.OrdenIDTextBox.TabIndex = 26;
            this.OrdenIDTextBox.Text = "OrdenID";
            this.OrdenIDTextBox.TextoPlaceHolder = "OrdenID";
            // 
            // FechaTextBox
            // 
            this.FechaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.FechaTextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.FechaTextBox.Location = new System.Drawing.Point(12, 124);
            this.FechaTextBox.Multiline = true;
            this.FechaTextBox.Name = "FechaTextBox";
            this.FechaTextBox.Size = new System.Drawing.Size(200, 50);
            this.FechaTextBox.TabIndex = 28;
            this.FechaTextBox.Text = "Fecha";
            this.FechaTextBox.TextoPlaceHolder = "Fecha";
            // 
            // FRM_Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.EstadoTextBox);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.OrdenDGV);
            this.Controls.Add(this.LegajoTextBox);
            this.Controls.Add(this.OrdenIDTextBox);
            this.Controls.Add(this.FechaTextBox);
            this.Name = "FRM_Orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            this.Load += new System.EventHandler(this.FRM_Orden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PlaceHolderTextBox EstadoTextBox;
        private System.Windows.Forms.Button BajaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.DataGridView OrdenDGV;
        private PlaceHolderTextBox LegajoTextBox;
        private PlaceHolderTextBox OrdenIDTextBox;
        private PlaceHolderTextBox FechaTextBox;
    }
}