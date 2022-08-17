
namespace UI
{
    partial class PrincipalForm
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
            this.PrincipalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ArchivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Archivo_SalirItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ABM_CategoriasItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABM_DepartamentosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABM_EmpleadosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABM_ItemsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABM_OrdenesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABM_ProveedoresItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABM_RolesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Reportes_OrdenesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuditoriaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Auditoria_EmpleadosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrincipalMenuStrip
            // 
            this.PrincipalMenuStrip.Enabled = false;
            this.PrincipalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoMenu,
            this.ABMMenu,
            this.ReportesMenu,
            this.AuditoriaMenu});
            this.PrincipalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrincipalMenuStrip.Name = "PrincipalMenuStrip";
            this.PrincipalMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.PrincipalMenuStrip.TabIndex = 1;
            this.PrincipalMenuStrip.Text = "menuStrip1";
            // 
            // ArchivoMenu
            // 
            this.ArchivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo_SalirItem});
            this.ArchivoMenu.Name = "ArchivoMenu";
            this.ArchivoMenu.Size = new System.Drawing.Size(60, 20);
            this.ArchivoMenu.Text = "Archivo";
            // 
            // Archivo_SalirItem
            // 
            this.Archivo_SalirItem.Name = "Archivo_SalirItem";
            this.Archivo_SalirItem.Size = new System.Drawing.Size(96, 22);
            this.Archivo_SalirItem.Text = "Salir";
            this.Archivo_SalirItem.Click += new System.EventHandler(this.Archivo_SalirItem_Click);
            // 
            // ABMMenu
            // 
            this.ABMMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ABM_CategoriasItem,
            this.ABM_DepartamentosItem,
            this.ABM_EmpleadosItem,
            this.ABM_ItemsItem,
            this.ABM_OrdenesItem,
            this.ABM_ProveedoresItem,
            this.ABM_RolesItem});
            this.ABMMenu.Name = "ABMMenu";
            this.ABMMenu.Size = new System.Drawing.Size(45, 20);
            this.ABMMenu.Text = "ABM";
            // 
            // ABM_CategoriasItem
            // 
            this.ABM_CategoriasItem.Name = "ABM_CategoriasItem";
            this.ABM_CategoriasItem.Size = new System.Drawing.Size(155, 22);
            this.ABM_CategoriasItem.Text = "Categorías";
            this.ABM_CategoriasItem.Click += new System.EventHandler(this.ABM_CategoriasItem_Click);
            // 
            // ABM_DepartamentosItem
            // 
            this.ABM_DepartamentosItem.Name = "ABM_DepartamentosItem";
            this.ABM_DepartamentosItem.Size = new System.Drawing.Size(155, 22);
            this.ABM_DepartamentosItem.Text = "Departamentos";
            this.ABM_DepartamentosItem.Click += new System.EventHandler(this.ABM_DepartamentosItem_Click);
            // 
            // ABM_EmpleadosItem
            // 
            this.ABM_EmpleadosItem.Name = "ABM_EmpleadosItem";
            this.ABM_EmpleadosItem.Size = new System.Drawing.Size(155, 22);
            this.ABM_EmpleadosItem.Text = "Empleados";
            this.ABM_EmpleadosItem.Click += new System.EventHandler(this.ABM_EmpleadosItem_Click);
            // 
            // ABM_ItemsItem
            // 
            this.ABM_ItemsItem.Name = "ABM_ItemsItem";
            this.ABM_ItemsItem.Size = new System.Drawing.Size(155, 22);
            this.ABM_ItemsItem.Text = "Ítems";
            this.ABM_ItemsItem.Click += new System.EventHandler(this.ABM_ItemsItem_Click);
            // 
            // ABM_OrdenesItem
            // 
            this.ABM_OrdenesItem.Name = "ABM_OrdenesItem";
            this.ABM_OrdenesItem.Size = new System.Drawing.Size(155, 22);
            this.ABM_OrdenesItem.Text = "Órdenes";
            this.ABM_OrdenesItem.Click += new System.EventHandler(this.ABM_OrdenesItem_Click);
            // 
            // ABM_ProveedoresItem
            // 
            this.ABM_ProveedoresItem.Name = "ABM_ProveedoresItem";
            this.ABM_ProveedoresItem.Size = new System.Drawing.Size(155, 22);
            this.ABM_ProveedoresItem.Text = "Proveedores";
            this.ABM_ProveedoresItem.Click += new System.EventHandler(this.ABM_ProveedoresItem_Click);
            // 
            // ABM_RolesItem
            // 
            this.ABM_RolesItem.Name = "ABM_RolesItem";
            this.ABM_RolesItem.Size = new System.Drawing.Size(155, 22);
            this.ABM_RolesItem.Text = "Roles";
            this.ABM_RolesItem.Click += new System.EventHandler(this.ABM_RolesItem_Click);
            // 
            // ReportesMenu
            // 
            this.ReportesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reportes_OrdenesItem});
            this.ReportesMenu.Name = "ReportesMenu";
            this.ReportesMenu.Size = new System.Drawing.Size(65, 20);
            this.ReportesMenu.Text = "Reportes";
            // 
            // Reportes_OrdenesItem
            // 
            this.Reportes_OrdenesItem.Name = "Reportes_OrdenesItem";
            this.Reportes_OrdenesItem.Size = new System.Drawing.Size(180, 22);
            this.Reportes_OrdenesItem.Text = "Órdenes";
            this.Reportes_OrdenesItem.Click += new System.EventHandler(this.Reportes_OrdenesItem_Click);
            // 
            // AuditoriaMenu
            // 
            this.AuditoriaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Auditoria_EmpleadosItem});
            this.AuditoriaMenu.Name = "AuditoriaMenu";
            this.AuditoriaMenu.Size = new System.Drawing.Size(68, 20);
            this.AuditoriaMenu.Text = "Auditoría";
            // 
            // Auditoria_EmpleadosItem
            // 
            this.Auditoria_EmpleadosItem.Name = "Auditoria_EmpleadosItem";
            this.Auditoria_EmpleadosItem.Size = new System.Drawing.Size(180, 22);
            this.Auditoria_EmpleadosItem.Text = "Empleados";
            this.Auditoria_EmpleadosItem.Click += new System.EventHandler(this.Auditoria_EmpleadosItem_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PrincipalMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.PrincipalMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.MultipleDocumentInterface_Load);
            this.PrincipalMenuStrip.ResumeLayout(false);
            this.PrincipalMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ArchivoMenu;
        private System.Windows.Forms.ToolStripMenuItem Archivo_SalirItem;
        private System.Windows.Forms.ToolStripMenuItem ABMMenu;
        private System.Windows.Forms.ToolStripMenuItem ABM_CategoriasItem;
        private System.Windows.Forms.ToolStripMenuItem ABM_DepartamentosItem;
        private System.Windows.Forms.ToolStripMenuItem ABM_EmpleadosItem;
        private System.Windows.Forms.ToolStripMenuItem ABM_ItemsItem;
        private System.Windows.Forms.ToolStripMenuItem ABM_OrdenesItem;
        private System.Windows.Forms.ToolStripMenuItem ABM_ProveedoresItem;
        private System.Windows.Forms.ToolStripMenuItem ABM_RolesItem;
        private System.Windows.Forms.ToolStripMenuItem ReportesMenu;
        private System.Windows.Forms.ToolStripMenuItem Reportes_OrdenesItem;
        private System.Windows.Forms.MenuStrip PrincipalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AuditoriaMenu;
        private System.Windows.Forms.ToolStripMenuItem Auditoria_EmpleadosItem;
    }
}

