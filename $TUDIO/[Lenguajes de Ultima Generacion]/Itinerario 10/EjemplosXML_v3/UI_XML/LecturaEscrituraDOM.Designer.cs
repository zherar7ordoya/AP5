namespace UI_XML
{
    partial class LecturaEscrituraDOM
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
            this.BtnVerXML = new System.Windows.Forms.Button();
            this.GrabaraArchivo = new System.Windows.Forms.Button();
            this.BtnCargardesdeArchivo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtPersonasXML = new System.Windows.Forms.TextBox();
            this.grdPersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVerXML
            // 
            this.BtnVerXML.Location = new System.Drawing.Point(444, 348);
            this.BtnVerXML.Name = "BtnVerXML";
            this.BtnVerXML.Size = new System.Drawing.Size(150, 23);
            this.BtnVerXML.TabIndex = 30;
            this.BtnVerXML.Text = "Ver XML";
            this.BtnVerXML.UseVisualStyleBackColor = true;
            this.BtnVerXML.Click += new System.EventHandler(this.BtnVerXML_Click);
            // 
            // GrabaraArchivo
            // 
            this.GrabaraArchivo.Location = new System.Drawing.Point(253, 348);
            this.GrabaraArchivo.Name = "GrabaraArchivo";
            this.GrabaraArchivo.Size = new System.Drawing.Size(157, 23);
            this.GrabaraArchivo.TabIndex = 29;
            this.GrabaraArchivo.Text = "Grabar a archivo";
            this.GrabaraArchivo.UseVisualStyleBackColor = true;
            this.GrabaraArchivo.Click += new System.EventHandler(this.GrabaraArchivo_Click);
            // 
            // BtnCargardesdeArchivo
            // 
            this.BtnCargardesdeArchivo.Location = new System.Drawing.Point(253, 319);
            this.BtnCargardesdeArchivo.Name = "BtnCargardesdeArchivo";
            this.BtnCargardesdeArchivo.Size = new System.Drawing.Size(157, 23);
            this.BtnCargardesdeArchivo.TabIndex = 28;
            this.BtnCargardesdeArchivo.Text = "Cargar desde archivo";
            this.BtnCargardesdeArchivo.UseVisualStyleBackColor = true;
            this.BtnCargardesdeArchivo.Click += new System.EventHandler(this.BtnCargardesdeArchivo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(72, 348);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(157, 23);
            this.btnCargar.TabIndex = 27;
            this.btnCargar.Text = "Cargar del XMLDocument";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(444, 319);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(150, 23);
            this.btnVer.TabIndex = 26;
            this.btnVer.Text = "Ver XMLDocument";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(72, 319);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(157, 23);
            this.btnGrabar.TabIndex = 25;
            this.btnGrabar.Text = "Guardar en XMLDocument";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtPersonasXML
            // 
            this.txtPersonasXML.Location = new System.Drawing.Point(334, 5);
            this.txtPersonasXML.Multiline = true;
            this.txtPersonasXML.Name = "txtPersonasXML";
            this.txtPersonasXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPersonasXML.Size = new System.Drawing.Size(289, 287);
            this.txtPersonasXML.TabIndex = 24;
            this.txtPersonasXML.WordWrap = false;
            // 
            // grdPersonas
            // 
            this.grdPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersonas.Location = new System.Drawing.Point(37, 5);
            this.grdPersonas.Name = "grdPersonas";
            this.grdPersonas.Size = new System.Drawing.Size(291, 287);
            this.grdPersonas.TabIndex = 23;
            // 
            // LecturaEscrituraDOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 426);
            this.Controls.Add(this.BtnVerXML);
            this.Controls.Add(this.GrabaraArchivo);
            this.Controls.Add(this.BtnCargardesdeArchivo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtPersonasXML);
            this.Controls.Add(this.grdPersonas);
            this.Name = "LecturaEscrituraDOM";
            this.Text = "LecturaEscrituraDOM";
            this.Load += new System.EventHandler(this.LecturaEscrituraDOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnVerXML;
        internal System.Windows.Forms.Button GrabaraArchivo;
        internal System.Windows.Forms.Button BtnCargardesdeArchivo;
        internal System.Windows.Forms.Button btnCargar;
        internal System.Windows.Forms.Button btnVer;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.TextBox txtPersonasXML;
        internal System.Windows.Forms.DataGridView grdPersonas;
    }
}