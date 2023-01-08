using BLL;
using BE;
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

namespace UI
{
    public partial class GestionarUsuarios : Form
    {
        public GestionarUsuarios()
        {
            InitializeComponent();
            rdgv = new RefreshDgv();
            bllusuario = new BLLUsuario();
            bllrol = new BLLRol();
        }
        RefreshDgv rdgv;
        BLLUsuario bllusuario;
        BLLRol bllrol;
        

        private void GestionarUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rdgv.Refresh(dgvUsuarios, bllusuario.ListarTodo());
            ArmarDgv();

            foreach (Rol rol in bllrol.ListarTodo())
            {
                cbRol.Items.Add(rol.Roll);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text != string.Empty && txtPassword.Text != string.Empty && cbRol.Text != string.Empty)
                {
                    int idRol = 0;
                    foreach (Rol rol in bllrol.ListarTodo())
                    {
                        if(cbRol.SelectedItem.ToString() == rol.Roll)
                        {
                            idRol = rol.IdRol;
                        }
                    }
                    string pass = Encript.Encrypt(txtPassword.Text);

                    bllusuario.Guardar(new Usuario(txtUsuario.Text, pass, idRol));
                    rdgv.Refresh(dgvUsuarios, bllusuario.ListarTodo());
                    ArmarDgv();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text != string.Empty && txtPassword.Text != string.Empty && cbRol.Text != string.Empty)
                {
                    Usuario aux = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                    string pass = Encript.Encrypt(txtPassword.Text);
                    int idRol = 0;
                    foreach (Rol rol in bllrol.ListarTodo())
                    {
                        if (cbRol.SelectedItem.ToString() == rol.Roll)
                        {
                            idRol = rol.IdRol;
                        }
                    }
                    bllusuario.Modificar(new Usuario(aux.IdUser, txtUsuario.Text, pass, idRol));
                    Limpiar();
                    rdgv.Refresh(dgvUsuarios, bllusuario.ListarTodo());
                    ArmarDgv();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario aux = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
                bllusuario.Borrar(aux);
                rdgv.Refresh(dgvUsuarios, bllusuario.ListarTodo());
                ArmarDgv();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ArmarDgv()
        {
            dgvUsuarios.Columns["IdUser"].Visible = false;
            dgvUsuarios.Columns["Rol"].Visible = false;
        }

        public void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbRol.Text = string.Empty;
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario aux = (Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem;
            txtUsuario.Text = aux.NombreUsuario;
            string pass = Desencript.Decrypt(aux.Password);
            txtPassword.Text = pass;
            string rolin = "";
            foreach (Rol rol in bllrol.ListarTodo())
            {
                if(rol.IdRol == aux.Rol)
                {
                    rolin = rol.Roll;
                }
            }
            cbRol.Text = rolin;
        }

        private void cbCambioPass_CheckedChanged(object sender, EventArgs e)
        {

            string pass = txtPassword.Text; 
            if (cbCambioPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = pass;
            }
            else 
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = pass;
            }
        }
    }
}
