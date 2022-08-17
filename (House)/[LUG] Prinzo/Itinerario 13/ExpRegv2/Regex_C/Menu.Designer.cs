namespace Regex_C
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.expresionesRegularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplosSImplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplosV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reemplazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expresionesRegularesToolStripMenuItem,
            this.imagenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // expresionesRegularesToolStripMenuItem
            // 
            this.expresionesRegularesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplosSImplesToolStripMenuItem,
            this.ejemplosV2ToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.reemplazarToolStripMenuItem});
            this.expresionesRegularesToolStripMenuItem.Name = "expresionesRegularesToolStripMenuItem";
            this.expresionesRegularesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.expresionesRegularesToolStripMenuItem.Text = "Expresiones Regulares";
            // 
            // ejemplosSImplesToolStripMenuItem
            // 
            this.ejemplosSImplesToolStripMenuItem.Name = "ejemplosSImplesToolStripMenuItem";
            this.ejemplosSImplesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ejemplosSImplesToolStripMenuItem.Text = "Ejemplos SImples";
            this.ejemplosSImplesToolStripMenuItem.Click += new System.EventHandler(this.ejemplosSImplesToolStripMenuItem_Click);
            // 
            // ejemplosV2ToolStripMenuItem
            // 
            this.ejemplosV2ToolStripMenuItem.Name = "ejemplosV2ToolStripMenuItem";
            this.ejemplosV2ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ejemplosV2ToolStripMenuItem.Text = "Ejemplos V2";
            this.ejemplosV2ToolStripMenuItem.Click += new System.EventHandler(this.ejemplosV2ToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // reemplazarToolStripMenuItem
            // 
            this.reemplazarToolStripMenuItem.Name = "reemplazarToolStripMenuItem";
            this.reemplazarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.reemplazarToolStripMenuItem.Text = "Reemplazar";
            this.reemplazarToolStripMenuItem.Click += new System.EventHandler(this.reemplazarToolStripMenuItem_Click);
            // 
            // imagenesToolStripMenuItem
            // 
            this.imagenesToolStripMenuItem.Name = "imagenesToolStripMenuItem";
            this.imagenesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.imagenesToolStripMenuItem.Text = "Imagenes";
            this.imagenesToolStripMenuItem.Click += new System.EventHandler(this.imagenesToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 485);
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
        private System.Windows.Forms.ToolStripMenuItem expresionesRegularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplosSImplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplosV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reemplazarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenesToolStripMenuItem;
    }
}

