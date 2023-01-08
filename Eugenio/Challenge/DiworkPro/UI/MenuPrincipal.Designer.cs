namespace UI
{
    partial class MenuPrincipal
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
            this.presupuestarAutomovilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestarMotocicletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repuestosRepetidosMarcaModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosPorMarcaModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestoTotalAutoYMotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presupuestarAutomovilToolStripMenuItem,
            this.presupuestarMotocicletaToolStripMenuItem,
            this.crearUsuariosToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // presupuestarAutomovilToolStripMenuItem
            // 
            this.presupuestarAutomovilToolStripMenuItem.Name = "presupuestarAutomovilToolStripMenuItem";
            this.presupuestarAutomovilToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.presupuestarAutomovilToolStripMenuItem.Text = "Presupuestar Automovil";
            this.presupuestarAutomovilToolStripMenuItem.Click += new System.EventHandler(this.presupuestarAutomovilToolStripMenuItem_Click);
            // 
            // presupuestarMotocicletaToolStripMenuItem
            // 
            this.presupuestarMotocicletaToolStripMenuItem.Name = "presupuestarMotocicletaToolStripMenuItem";
            this.presupuestarMotocicletaToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.presupuestarMotocicletaToolStripMenuItem.Text = "Presupuestar Motocicleta";
            this.presupuestarMotocicletaToolStripMenuItem.Click += new System.EventHandler(this.presupuestarMotocicletaToolStripMenuItem_Click);
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarRolesToolStripMenuItem,
            this.crearUsuariosToolStripMenuItem1});
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.crearUsuariosToolStripMenuItem.Text = "Crear Usuarios";
            // 
            // asignarRolesToolStripMenuItem
            // 
            this.asignarRolesToolStripMenuItem.Name = "asignarRolesToolStripMenuItem";
            this.asignarRolesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.asignarRolesToolStripMenuItem.Text = "Asignar Roles y permisos";
            this.asignarRolesToolStripMenuItem.Click += new System.EventHandler(this.asignarRolesToolStripMenuItem_Click);
            // 
            // crearUsuariosToolStripMenuItem1
            // 
            this.crearUsuariosToolStripMenuItem1.Name = "crearUsuariosToolStripMenuItem1";
            this.crearUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.crearUsuariosToolStripMenuItem1.Text = "Crear usuarios";
            this.crearUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.crearUsuariosToolStripMenuItem1_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repuestosRepetidosMarcaModeloToolStripMenuItem,
            this.presupuestosPorMarcaModeloToolStripMenuItem,
            this.presupuestoTotalAutoYMotoToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.estadisticasToolStripMenuItem.Text = "Procedimientos";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionUsuarioToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // cerrarSesionUsuarioToolStripMenuItem
            // 
            this.cerrarSesionUsuarioToolStripMenuItem.Name = "cerrarSesionUsuarioToolStripMenuItem";
            this.cerrarSesionUsuarioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cerrarSesionUsuarioToolStripMenuItem.Text = "Cerrar sesion usuario";
            this.cerrarSesionUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionUsuarioToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // repuestosRepetidosMarcaModeloToolStripMenuItem
            // 
            this.repuestosRepetidosMarcaModeloToolStripMenuItem.Name = "repuestosRepetidosMarcaModeloToolStripMenuItem";
            this.repuestosRepetidosMarcaModeloToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.repuestosRepetidosMarcaModeloToolStripMenuItem.Text = "Repuestos repetidos marca modelo";
            this.repuestosRepetidosMarcaModeloToolStripMenuItem.Click += new System.EventHandler(this.repuestosRepetidosMarcaModeloToolStripMenuItem_Click);
            // 
            // presupuestosPorMarcaModeloToolStripMenuItem
            // 
            this.presupuestosPorMarcaModeloToolStripMenuItem.Name = "presupuestosPorMarcaModeloToolStripMenuItem";
            this.presupuestosPorMarcaModeloToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.presupuestosPorMarcaModeloToolStripMenuItem.Text = "Presupuestos por marca modelo";
            this.presupuestosPorMarcaModeloToolStripMenuItem.Click += new System.EventHandler(this.presupuestosPorMarcaModeloToolStripMenuItem_Click);
            // 
            // presupuestoTotalAutoYMotoToolStripMenuItem
            // 
            this.presupuestoTotalAutoYMotoToolStripMenuItem.Name = "presupuestoTotalAutoYMotoToolStripMenuItem";
            this.presupuestoTotalAutoYMotoToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.presupuestoTotalAutoYMotoToolStripMenuItem.Text = "Presupuesto total auto y moto";
            this.presupuestoTotalAutoYMotoToolStripMenuItem.Click += new System.EventHandler(this.presupuestoTotalAutoYMotoToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 735);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem presupuestarAutomovilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestarMotocicletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem repuestosRepetidosMarcaModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestosPorMarcaModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestoTotalAutoYMotoToolStripMenuItem;
    }
}

