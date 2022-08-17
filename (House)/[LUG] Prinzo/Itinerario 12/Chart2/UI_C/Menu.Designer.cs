namespace UI_C
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarImportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem,
            this.chart2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vectoresToolStripMenuItem,
            this.dataviewToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.listasToolStripMenuItem,
            this.cSVToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // vectoresToolStripMenuItem
            // 
            this.vectoresToolStripMenuItem.Name = "vectoresToolStripMenuItem";
            this.vectoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vectoresToolStripMenuItem.Text = "Vectores";
            this.vectoresToolStripMenuItem.Click += new System.EventHandler(this.vectoresToolStripMenuItem_Click);
            // 
            // dataviewToolStripMenuItem
            // 
            this.dataviewToolStripMenuItem.Name = "dataviewToolStripMenuItem";
            this.dataviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataviewToolStripMenuItem.Text = "Dataview";
            this.dataviewToolStripMenuItem.Click += new System.EventHandler(this.dataviewToolStripMenuItem_Click);
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tablasToolStripMenuItem.Text = "Tablas";
            this.tablasToolStripMenuItem.Click += new System.EventHandler(this.tablasToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cSVToolStripMenuItem.Text = "Xml";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // chart2ToolStripMenuItem
            // 
            this.chart2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarImportarToolStripMenuItem});
            this.chart2ToolStripMenuItem.Name = "chart2ToolStripMenuItem";
            this.chart2ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.chart2ToolStripMenuItem.Text = "Chart2";
            // 
            // exportarImportarToolStripMenuItem
            // 
            this.exportarImportarToolStripMenuItem.Name = "exportarImportarToolStripMenuItem";
            this.exportarImportarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exportarImportarToolStripMenuItem.Text = "Exportar/Importar";
            this.exportarImportarToolStripMenuItem.Click += new System.EventHandler(this.exportarImportarToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listasToolStripMenuItem.Text = "Listas";
            this.listasToolStripMenuItem.Click += new System.EventHandler(this.listasToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 548);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chart2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarImportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
    }
}