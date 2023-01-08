using BLL;
using BE;
using Service;
using Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;

namespace UI
{
    public partial class AsignarRoles : Form
    {
        public AsignarRoles()
        {
            InitializeComponent();
            bllrol = new BLLRol();
            listaPermisos = new ListaPermisos();
            bllpermisos = new BLLPermisos();
            permisos = new Permisos("");
           
        }
        
        Rol rolin;
        BLLRol bllrol;
        ListaPermisos listaPermisos;
        BLLPermisos bllpermisos;
        Permisos permisos;
        string user;
        public Composite User { get; set; }

        public string Rolear { get; set; }


        private void btnGuardarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtRol.Text != string.Empty)
                {
                    cboxRoles.Items.Add(txtRol.Text);
                    rolin = new Rol(0, txtRol.Text, 0);
                   
                    bllrol.Guardar(rolin);
                    txtRol.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Esta vacia la casilla para crear un nuevo rol");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void AsignarRoles_Load(object sender, EventArgs e)
        {
            foreach(Rol rol in bllrol.ListarTodo())
            {
                cboxRoles.Items.Add(rol.Roll);
            }
            listaPermisos.ListaPermisivos(Rolear, Rolear);
            TreeNode nodoRaiz = new TreeNode(listaPermisos.aux[0].Permiso);
            nodoRaiz.Tag = listaPermisos.aux[0].Id.ToString();
            tvPermisos.Nodes.Add(nodoRaiz);
            LlenaTreeView(nodoRaiz);
            tvPermisos.ExpandAll();
        }
        public void LlenaTreeView(TreeNode nodoPadre)
        {
            int idPadre = int.Parse(nodoPadre.Tag.ToString());
            List<AuxLista> filtro = listaPermisos.aux.FindAll(x => x.IdPadre.Equals(idPadre));

            if (filtro != null && filtro.Count > 0)
            {
                TreeNode nodoHijo;
                foreach (AuxLista auxper in filtro)
                {
                    nodoHijo = new TreeNode(auxper.Permiso);
                    nodoHijo.Tag = auxper.Id.ToString();
                    nodoPadre.Nodes.Add(nodoHijo);
                    LlenaTreeView(nodoHijo);
                }
            }
        }

        public void Desmarcar()
        {
            chbPresupuestoAuto.Checked = false;
            chbPresupuestoMoto.Checked = false;
            chbCrearUsuario.Checked = false;
            chbEstadisticas.Checked = false;
            chbLogin.Checked = false;
            chbLogout.Checked = false;
        }

        public void MarcarSeleccionado()
        {
            foreach (Permisos permisos in bllpermisos.ListarTodo())
            {
                if(cboxRoles.SelectedItem.ToString() == permisos.Nombre)
                {
                    if(permisos.PresupuestarAutomovil == true)
                    {
                        chbPresupuestoAuto.Checked = true;
                    }

                    if(permisos.PresupuestarMoto == true)
                    {
                        chbPresupuestoMoto.Checked = true;
                    }

                    if(permisos.CrearUsuario == true)
                    {
                        chbCrearUsuario.Checked = true;
                    }

                    if(permisos.Estadisticas == true)
                    {
                        chbEstadisticas.Checked = true;
                    }

                    if(permisos.Login == true)
                    {
                        chbLogin.Checked = true;
                    }

                    if(permisos.Logout == true)
                    {
                        chbLogout.Checked = true;
                    }
               }
            }
        }

        private void btnGuardarPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxRoles.Text != string.Empty)
                {
                    if (chbPresupuestoAuto.Checked == true)
                    {
                        permisos.PresupuestarAutomovil = true;
                    }
                    else
                    {
                        permisos.PresupuestarAutomovil = false;
                    }

                    if (chbPresupuestoMoto.Checked == true)
                    {
                        permisos.PresupuestarMoto = true;
                    }
                    else
                    {
                        permisos.PresupuestarMoto = false;
                    }

                    if (chbCrearUsuario.Checked == true)
                    {
                        permisos.CrearUsuario = true;
                    }
                    else
                    {
                        permisos.CrearUsuario = false;
                    }

                    if (chbEstadisticas.Checked == true)
                    {
                        permisos.Estadisticas = true;
                    }
                    else
                    {
                        permisos.Estadisticas = false;
                    }

                    if (chbLogin.Checked == true) 
                    {
                        permisos.Login = true;
                    }
                    else
                    {
                        permisos.Login = false;
                    }

                    if(chbLogout.Checked == true)
                    {
                        permisos.Logout = true;
                    }
                    else
                    {
                        permisos.Logout = false;
                    }

                    bllpermisos.Guardar(new Permisos(permisos.PresupuestarAutomovil, permisos.PresupuestarMoto, permisos.CrearUsuario,
                                                     permisos.Estadisticas, permisos.Login, permisos.Logout, cboxRoles.Text));
                   
                    foreach (Rol r in bllrol.ListarTodo())
                    {
                        foreach (Permisos perm in bllpermisos.ListarTodo())
                        {
                            if (r.Roll == perm.Nombre)
                            {
                                bllrol.Modificar(new Rol(r.IdRol, r.Roll, perm.Id));
                            }
                        }
                        
                    }
                    cboxRoles.Text = string.Empty;
                    tvPermisos.Nodes.Clear();
                    Desmarcar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desmarcar();
            MarcarSeleccionado();
            user = cboxRoles.SelectedItem.ToString();
            listaPermisos.ListaPermisivos(user, Rolear);
            tvPermisos.Nodes.Clear();
            listaPermisos.aux[0].Permiso = user;
            TreeNode nodoRaiz = new TreeNode(listaPermisos.aux[0].Permiso);
            nodoRaiz.Tag = listaPermisos.aux[0].Id.ToString();
            tvPermisos.Nodes.Add(nodoRaiz);
            LlenaTreeView(nodoRaiz);
            tvPermisos.ExpandAll();
        }

        private void btnModificarPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboxRoles.Text != string.Empty) 
                {
                    int id = 0;
                    foreach (Permisos perm in bllpermisos.ListarTodo())
                    {
                        if(cboxRoles.SelectedItem.ToString() == perm.Nombre)
                        {
                            id = perm.Id;
                        }
                    }

                    if (chbPresupuestoAuto.Checked == true)
                    {
                        permisos.PresupuestarAutomovil = true;
                    }
                    else
                    {
                        permisos.PresupuestarAutomovil = false;
                    }

                    if (chbPresupuestoMoto.Checked == true)
                    {
                        permisos.PresupuestarMoto = true;
                    }
                    else
                    {
                        permisos.PresupuestarMoto = false;
                    }

                    if (chbCrearUsuario.Checked == true)
                    {
                        permisos.CrearUsuario = true;
                    }
                    else
                    {
                        permisos.CrearUsuario = false;
                    }

                    if (chbEstadisticas.Checked == true)
                    {
                        permisos.Estadisticas = true;
                    }
                    else
                    {
                        permisos.Estadisticas = false;
                    }

                    if (chbLogin.Checked == true)
                    {
                        permisos.Login = true;
                    }
                    else
                    {
                        permisos.Login = false;
                    }

                    if (chbLogout.Checked == true)
                    {
                        permisos.Logout = true;
                    }
                    else
                    {
                        permisos.Logout = false;
                    }

                    bllpermisos.Modificar(new Permisos(id, permisos.PresupuestarAutomovil, permisos.PresupuestarMoto,
                                                       permisos.CrearUsuario, permisos.Estadisticas, permisos.Login,
                                                       permisos.Logout, cboxRoles.Text));
                    cboxRoles.Text = string.Empty;
                    Desmarcar();
                    tvPermisos.Nodes.Clear();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento del combobox a modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarRolPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboxRoles.Text != string.Empty) 
                {
                    foreach (Rol roli in bllrol.ListarTodo())
                    {
                        if(cboxRoles.SelectedItem.ToString() == roli.Roll)
                        {
                            bllrol.Borrar(roli);
                        }
                    }
                    foreach (Permisos permis in bllpermisos.ListarTodo())
                    {
                        if(cboxRoles.SelectedItem.ToString() == permis.Nombre)
                        {
                            bllpermisos.Borrar(permis);
                        }
                    }
                    cboxRoles.Items.Remove(cboxRoles.SelectedItem);
                    Desmarcar();
                    tvPermisos.Nodes.Clear();
                }
                else
                {
                    MessageBox.Show("No puede estar vacio en combobox para borrar un rol");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
