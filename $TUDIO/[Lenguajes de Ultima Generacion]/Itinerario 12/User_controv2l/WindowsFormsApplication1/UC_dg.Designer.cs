namespace WindowsFormsApplication1
{
    partial class UC_dg
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgGenerica = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgGenerica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGenerica
            // 
            this.dgGenerica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGenerica.Location = new System.Drawing.Point(15, 12);
            this.dgGenerica.Name = "dgGenerica";
            this.dgGenerica.Size = new System.Drawing.Size(534, 262);
            this.dgGenerica.TabIndex = 0;
            this.dgGenerica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGenerica_CellContentClick);
            // 
            // UC_dg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgGenerica);
            this.Name = "UC_dg";
            this.Size = new System.Drawing.Size(566, 288);
            ((System.ComponentModel.ISupportInitialize)(this.dgGenerica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //la cambio a publica 
        public System.Windows.Forms.DataGridView dgGenerica;
    }
}
