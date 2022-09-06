namespace UI_XML
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
            this.xNLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLLecturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLLecturaEscrituraSimpleIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturaEscrituraDOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linQClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linQBusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linqABMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xNLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xNLToolStripMenuItem
            // 
            this.xNLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLLecturaToolStripMenuItem,
            this.xMLLecturaEscrituraSimpleIIToolStripMenuItem,
            this.lecturaEscrituraDOMToolStripMenuItem,
            this.linQToolStripMenuItem,
            this.linQClasesToolStripMenuItem,
            this.linQBusquedaToolStripMenuItem,
            this.linqABMToolStripMenuItem});
            this.xNLToolStripMenuItem.Name = "xNLToolStripMenuItem";
            this.xNLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xNLToolStripMenuItem.Text = "XML";
            // 
            // xMLLecturaToolStripMenuItem
            // 
            this.xMLLecturaToolStripMenuItem.Name = "xMLLecturaToolStripMenuItem";
            this.xMLLecturaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.xMLLecturaToolStripMenuItem.Text = "Lectura/ Escritura Simple I";
            this.xMLLecturaToolStripMenuItem.Click += new System.EventHandler(this.xMLLecturaToolStripMenuItem_Click);
            // 
            // xMLLecturaEscrituraSimpleIIToolStripMenuItem
            // 
            this.xMLLecturaEscrituraSimpleIIToolStripMenuItem.Name = "xMLLecturaEscrituraSimpleIIToolStripMenuItem";
            this.xMLLecturaEscrituraSimpleIIToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.xMLLecturaEscrituraSimpleIIToolStripMenuItem.Text = "Lectura/ Escritura Simple II";
            this.xMLLecturaEscrituraSimpleIIToolStripMenuItem.Click += new System.EventHandler(this.xMLLecturaEscrituraSimpleIIToolStripMenuItem_Click);
            // 
            // lecturaEscrituraDOMToolStripMenuItem
            // 
            this.lecturaEscrituraDOMToolStripMenuItem.Name = "lecturaEscrituraDOMToolStripMenuItem";
            this.lecturaEscrituraDOMToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.lecturaEscrituraDOMToolStripMenuItem.Text = "Lectura/ Escritura DOM";
            this.lecturaEscrituraDOMToolStripMenuItem.Click += new System.EventHandler(this.lecturaEscrituraDOMToolStripMenuItem_Click);
            // 
            // linQToolStripMenuItem
            // 
            this.linQToolStripMenuItem.Name = "linQToolStripMenuItem";
            this.linQToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.linQToolStripMenuItem.Text = "LinQ - Generico";
            this.linQToolStripMenuItem.Click += new System.EventHandler(this.linQToolStripMenuItem_Click);
            // 
            // linQClasesToolStripMenuItem
            // 
            this.linQClasesToolStripMenuItem.Name = "linQClasesToolStripMenuItem";
            this.linQClasesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.linQClasesToolStripMenuItem.Text = "LinQ - Clases";
            this.linQClasesToolStripMenuItem.Click += new System.EventHandler(this.linQClasesToolStripMenuItem_Click);
            // 
            // linQBusquedaToolStripMenuItem
            // 
            this.linQBusquedaToolStripMenuItem.Name = "linQBusquedaToolStripMenuItem";
            this.linQBusquedaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.linQBusquedaToolStripMenuItem.Text = "LinQ - Busqueda";
            this.linQBusquedaToolStripMenuItem.Click += new System.EventHandler(this.linQBusquedaToolStripMenuItem_Click);
            // 
            // linqABMToolStripMenuItem
            // 
            this.linqABMToolStripMenuItem.Name = "linqABMToolStripMenuItem";
            this.linqABMToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.linqABMToolStripMenuItem.Text = "LinQ - ABM";
            this.linqABMToolStripMenuItem.Click += new System.EventHandler(this.linqABMToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 501);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xNLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLLecturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLLecturaEscrituraSimpleIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturaEscrituraDOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linQClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linQBusquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linqABMToolStripMenuItem;
    }
}

