namespace Presentacion
{
    partial class MENU
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.crearDSEnMemoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDSEnMemoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMSimpleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDSEnMemoriaToolStripMenuItem,
            this.filtrosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // crearDSEnMemoriaToolStripMenuItem
            // 
            this.crearDSEnMemoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDSEnMemoriaToolStripMenuItem1,
            this.aBMSimpleToolStripMenuItem1,
            this.aBMToolStripMenuItem1,
            this.aBMStateToolStripMenuItem});
            this.crearDSEnMemoriaToolStripMenuItem.Name = "crearDSEnMemoriaToolStripMenuItem";
            this.crearDSEnMemoriaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.crearDSEnMemoriaToolStripMenuItem.Text = "Archivo";
            // 
            // crearDSEnMemoriaToolStripMenuItem1
            // 
            this.crearDSEnMemoriaToolStripMenuItem1.Name = "crearDSEnMemoriaToolStripMenuItem1";
            this.crearDSEnMemoriaToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.crearDSEnMemoriaToolStripMenuItem1.Text = "Crear DS en Memoria";
            this.crearDSEnMemoriaToolStripMenuItem1.Click += new System.EventHandler(this.crearDSEnMemoriaToolStripMenuItem1_Click);
            // 
            // aBMSimpleToolStripMenuItem1
            // 
            this.aBMSimpleToolStripMenuItem1.Name = "aBMSimpleToolStripMenuItem1";
            this.aBMSimpleToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.aBMSimpleToolStripMenuItem1.Text = "ABM Simple";
            this.aBMSimpleToolStripMenuItem1.Click += new System.EventHandler(this.aBMSimpleToolStripMenuItem1_Click);
            // 
            // aBMToolStripMenuItem1
            // 
            this.aBMToolStripMenuItem1.Name = "aBMToolStripMenuItem1";
            this.aBMToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.aBMToolStripMenuItem1.Text = "ABM - Simple Textbox";
            this.aBMToolStripMenuItem1.Click += new System.EventHandler(this.aBMToolStripMenuItem1_Click);
            // 
            // aBMStateToolStripMenuItem
            // 
            this.aBMStateToolStripMenuItem.Name = "aBMStateToolStripMenuItem";
            this.aBMStateToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aBMStateToolStripMenuItem.Text = "ABM - State";
            this.aBMStateToolStripMenuItem.Click += new System.EventHandler(this.aBMStateToolStripMenuItem_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            this.filtrosToolStripMenuItem.Click += new System.EventHandler(this.filtrosToolStripMenuItem_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 668);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADO Desconectado ";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem crearDSEnMemoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearDSEnMemoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMSimpleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMStateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
    }
}

