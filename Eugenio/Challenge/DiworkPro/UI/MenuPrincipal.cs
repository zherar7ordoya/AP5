using BE;
using BLL;
using Abstract;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace UI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            bllpermisos = new BLLPermisos();
            gestorPermisos = new GestorPermisos("");
        }
        BLLPermisos bllpermisos;
        GestorPermisos gestorPermisos;
        public Composite UserAux { get; set; }
        public Usuario usuario { get; set; }
        public string Rolear { get; set; }

        public bool activar { get; set; } = false;


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            if (activar == false)
            {
                presupuestarMotocicletaToolStripMenuItem.Visible = false;
                presupuestarAutomovilToolStripMenuItem.Visible = false;
                crearUsuariosToolStripMenuItem.Visible = false;
                estadisticasToolStripMenuItem.Visible = false;
                loginToolStripMenuItem.Visible = true;
                logoutToolStripMenuItem.Visible = false;
            }
            else
            {
                Comprobador(gestorPermisos.Permisos(UserAux, Rolear));
            }
            
        }

        public void Comprobador(Rol rol)
        {
            foreach (Permisos permisos in bllpermisos.ListarTodo())
            {
                if(rol.IdPermisos == permisos.Id)
                {
                    if (permisos.PresupuestarAutomovil == true)
                    {
                        presupuestarAutomovilToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        presupuestarAutomovilToolStripMenuItem.Visible = false;
                    }

                    if (permisos.PresupuestarMoto == true)
                    {
                        presupuestarMotocicletaToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        presupuestarMotocicletaToolStripMenuItem.Visible = false;
                    }

                    if (permisos.CrearUsuario == true)
                    {
                        crearUsuariosToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        crearUsuariosToolStripMenuItem.Visible = false;
                    }

                    if (permisos.Estadisticas == true)
                    {
                        estadisticasToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        estadisticasToolStripMenuItem.Visible = false;
                    }

                    if (permisos.Login == true)
                    {
                        loginToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        loginToolStripMenuItem.Visible = false;
                    }

                    if (permisos.Logout == true)
                    {
                        logoutToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        logoutToolStripMenuItem.Visible = false;
                    }
                }
                
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
            
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void asignarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarRoles ar = new AsignarRoles();
            ar.Rolear = Rolear;
            ar.User = UserAux;
            ar.MdiParent = this;
            ar.Show();
        }

        private void presupuestarMotocicletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresupuestarAuto pa = new PresupuestarAuto();
            pa.MdiParent = this;
            pa.User = true;
            pa.usuario = usuario;
            pa.Show();
        }

        private void presupuestarAutomovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresupuestarAuto pa = new PresupuestarAuto();
            pa.MdiParent = this;
            pa.User = false;
            pa.usuario = usuario;
            pa.Show(); 
        }

        private void cerrarSesionUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestionarUsuarios gu = new GestionarUsuarios();
            gu.MdiParent = this;
            gu.Show();
        }

        private void repuestosRepetidosMarcaModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepuestosRepetidos rr = new RepuestosRepetidos();
            rr.MdiParent = this;
            rr.Show();
        }

        private void presupuestosPorMarcaModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PresupuestoMarcaModelo pmm = new PresupuestoMarcaModelo();
            pmm.MdiParent = this;
            pmm.Show();
        }

        private void presupuestoTotalAutoYMotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalAutoMoto tam = new TotalAutoMoto();
            tam.MdiParent = this;
            tam.Show();
        }
    }
}
