
namespace UI
{
    partial class MDIForm
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
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piedraPapelOTijeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PPP1JugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PPP2JugadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taTeTíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTT1JugadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TTT2JugadoresToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HistorialJMJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresPorJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistorialPPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistorialTTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuditoriaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagramaDeClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrincipalMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrincipalMenuStrip
            // 
            this.PrincipalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoMenu,
            this.ABMMenu,
            this.juegosToolStripMenuItem,
            this.ReportesMenu,
            this.AuditoriaMenu});
            this.PrincipalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PrincipalMenuStrip.Name = "PrincipalMenuStrip";
            this.PrincipalMenuStrip.Size = new System.Drawing.Size(1284, 24);
            this.PrincipalMenuStrip.TabIndex = 1;
            this.PrincipalMenuStrip.Text = "menuStrip1";
            // 
            // ArchivoMenu
            // 
            this.ArchivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirToolStripMenuItem});
            this.ArchivoMenu.Name = "ArchivoMenu";
            this.ArchivoMenu.Size = new System.Drawing.Size(60, 20);
            this.ArchivoMenu.Text = "Archivo";
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // ABMMenu
            // 
            this.ABMMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ABMJugadoresToolStripMenuItem});
            this.ABMMenu.Name = "ABMMenu";
            this.ABMMenu.Size = new System.Drawing.Size(45, 20);
            this.ABMMenu.Text = "ABM";
            // 
            // ABMJugadoresToolStripMenuItem
            // 
            this.ABMJugadoresToolStripMenuItem.Name = "ABMJugadoresToolStripMenuItem";
            this.ABMJugadoresToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ABMJugadoresToolStripMenuItem.Text = "Jugadores";
            this.ABMJugadoresToolStripMenuItem.Click += new System.EventHandler(this.ABMJugadoresToolStripMenuItem_Click);
            // 
            // juegosToolStripMenuItem
            // 
            this.juegosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.piedraPapelOTijeraToolStripMenuItem,
            this.taTeTíToolStripMenuItem});
            this.juegosToolStripMenuItem.Name = "juegosToolStripMenuItem";
            this.juegosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.juegosToolStripMenuItem.Text = "Juegos";
            // 
            // piedraPapelOTijeraToolStripMenuItem
            // 
            this.piedraPapelOTijeraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PPP1JugadorToolStripMenuItem,
            this.PPP2JugadoresToolStripMenuItem1});
            this.piedraPapelOTijeraToolStripMenuItem.Name = "piedraPapelOTijeraToolStripMenuItem";
            this.piedraPapelOTijeraToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.piedraPapelOTijeraToolStripMenuItem.Text = "Piedra, papel o tijera";
            // 
            // PPP1JugadorToolStripMenuItem
            // 
            this.PPP1JugadorToolStripMenuItem.Name = "PPP1JugadorToolStripMenuItem";
            this.PPP1JugadorToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.PPP1JugadorToolStripMenuItem.Text = "1 jugador";
            this.PPP1JugadorToolStripMenuItem.Click += new System.EventHandler(this.PPP1JugadorToolStripMenuItem_Click);
            // 
            // PPP2JugadoresToolStripMenuItem1
            // 
            this.PPP2JugadoresToolStripMenuItem1.Name = "PPP2JugadoresToolStripMenuItem1";
            this.PPP2JugadoresToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.PPP2JugadoresToolStripMenuItem1.Text = "2 jugadores";
            this.PPP2JugadoresToolStripMenuItem1.Click += new System.EventHandler(this.PPP2JugadoresToolStripMenuItem1_Click);
            // 
            // taTeTíToolStripMenuItem
            // 
            this.taTeTíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTT1JugadorToolStripMenuItem1,
            this.TTT2JugadoresToolStripMenuItem2});
            this.taTeTíToolStripMenuItem.Name = "taTeTíToolStripMenuItem";
            this.taTeTíToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.taTeTíToolStripMenuItem.Text = "Ta-Te-Tí";
            // 
            // TTT1JugadorToolStripMenuItem1
            // 
            this.TTT1JugadorToolStripMenuItem1.Name = "TTT1JugadorToolStripMenuItem1";
            this.TTT1JugadorToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.TTT1JugadorToolStripMenuItem1.Text = "1 jugador";
            this.TTT1JugadorToolStripMenuItem1.Click += new System.EventHandler(this.TTT1JugadorToolStripMenuItem1_Click);
            // 
            // TTT2JugadoresToolStripMenuItem2
            // 
            this.TTT2JugadoresToolStripMenuItem2.Name = "TTT2JugadoresToolStripMenuItem2";
            this.TTT2JugadoresToolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.TTT2JugadoresToolStripMenuItem2.Text = "2 jugadores";
            this.TTT2JugadoresToolStripMenuItem2.Click += new System.EventHandler(this.TTT2JugadoresToolStripMenuItem2_Click);
            // 
            // ReportesMenu
            // 
            this.ReportesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistorialJMJToolStripMenuItem,
            this.jugadoresPorJuegoToolStripMenuItem});
            this.ReportesMenu.Name = "ReportesMenu";
            this.ReportesMenu.Size = new System.Drawing.Size(63, 20);
            this.ReportesMenu.Text = "Historial";
            // 
            // HistorialJMJToolStripMenuItem
            // 
            this.HistorialJMJToolStripMenuItem.Name = "HistorialJMJToolStripMenuItem";
            this.HistorialJMJToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.HistorialJMJToolStripMenuItem.Text = "Juego más jugado";
            this.HistorialJMJToolStripMenuItem.Click += new System.EventHandler(this.HistorialJMJToolStripMenuItem_Click);
            // 
            // jugadoresPorJuegoToolStripMenuItem
            // 
            this.jugadoresPorJuegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistorialPPTToolStripMenuItem,
            this.HistorialTTTToolStripMenuItem});
            this.jugadoresPorJuegoToolStripMenuItem.Name = "jugadoresPorJuegoToolStripMenuItem";
            this.jugadoresPorJuegoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.jugadoresPorJuegoToolStripMenuItem.Text = "Jugadores por juego";
            // 
            // HistorialPPTToolStripMenuItem
            // 
            this.HistorialPPTToolStripMenuItem.Name = "HistorialPPTToolStripMenuItem";
            this.HistorialPPTToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.HistorialPPTToolStripMenuItem.Text = "Piedra-Papel-Tijera";
            this.HistorialPPTToolStripMenuItem.Click += new System.EventHandler(this.HistorialPPTToolStripMenuItem_Click);
            // 
            // HistorialTTTToolStripMenuItem
            // 
            this.HistorialTTTToolStripMenuItem.Name = "HistorialTTTToolStripMenuItem";
            this.HistorialTTTToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.HistorialTTTToolStripMenuItem.Text = "Ta-Te-Tí";
            this.HistorialTTTToolStripMenuItem.Click += new System.EventHandler(this.HistorialTTTToolStripMenuItem_Click);
            // 
            // AuditoriaMenu
            // 
            this.AuditoriaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiagramaDeClasesToolStripMenuItem});
            this.AuditoriaMenu.Name = "AuditoriaMenu";
            this.AuditoriaMenu.Size = new System.Drawing.Size(70, 20);
            this.AuditoriaMenu.Text = "Diagrama";
            // 
            // DiagramaDeClasesToolStripMenuItem
            // 
            this.DiagramaDeClasesToolStripMenuItem.Name = "DiagramaDeClasesToolStripMenuItem";
            this.DiagramaDeClasesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.DiagramaDeClasesToolStripMenuItem.Text = "De Clases";
            this.DiagramaDeClasesToolStripMenuItem.Click += new System.EventHandler(this.DiagramaDeClasesToolStripMenuItem_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.PrincipalMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.PrincipalMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.PrincipalMenuStrip.ResumeLayout(false);
            this.PrincipalMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ArchivoMenu;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ABMMenu;
        private System.Windows.Forms.ToolStripMenuItem ReportesMenu;
        private System.Windows.Forms.ToolStripMenuItem HistorialJMJToolStripMenuItem;
        private System.Windows.Forms.MenuStrip PrincipalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AuditoriaMenu;
        private System.Windows.Forms.ToolStripMenuItem DiagramaDeClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ABMJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piedraPapelOTijeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PPP1JugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PPP2JugadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taTeTíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTT1JugadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TTT2JugadoresToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem jugadoresPorJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistorialPPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistorialTTTToolStripMenuItem;
    }
}

