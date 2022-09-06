namespace UI_XML
{
    partial class LecturaEscrituraXMLSimple
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtPersonasXML = new System.Windows.Forms.TextBox();
            this.grdPersonas = new System.Windows.Forms.DataGridView();
            this.BtnCargarXML = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(122, 315);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(157, 23);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar archivo XML";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtPersonasXML
            // 
            this.txtPersonasXML.Location = new System.Drawing.Point(338, 6);
            this.txtPersonasXML.Multiline = true;
            this.txtPersonasXML.Name = "txtPersonasXML";
            this.txtPersonasXML.Size = new System.Drawing.Size(383, 288);
            this.txtPersonasXML.TabIndex = 11;
            // 
            // grdPersonas
            // 
            this.grdPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersonas.Location = new System.Drawing.Point(13, 6);
            this.grdPersonas.Name = "grdPersonas";
            this.grdPersonas.Size = new System.Drawing.Size(319, 288);
            this.grdPersonas.TabIndex = 10;
            // 
            // BtnCargarXML
            // 
            this.BtnCargarXML.Location = new System.Drawing.Point(122, 349);
            this.BtnCargarXML.Name = "BtnCargarXML";
            this.BtnCargarXML.Size = new System.Drawing.Size(157, 23);
            this.BtnCargarXML.TabIndex = 13;
            this.BtnCargarXML.Text = "Cargar Archivo XML";
            this.BtnCargarXML.UseVisualStyleBackColor = true;
            this.BtnCargarXML.Click += new System.EventHandler(this.BtnCargarXML_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ver Archivo XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecturaEscrituraXMLSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCargarXML);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtPersonasXML);
            this.Controls.Add(this.grdPersonas);
            this.Name = "LecturaEscrituraXMLSimple";
            this.Text = "LecturaEscrituraXMLSimple";
            this.Load += new System.EventHandler(this.LecturaEscrituraXMLSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.TextBox txtPersonasXML;
        internal System.Windows.Forms.DataGridView grdPersonas;
        private System.Windows.Forms.Button BtnCargarXML;
        private System.Windows.Forms.Button button1;
    }
}