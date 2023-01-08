using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using BE;
using BLL;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loguear = new Loguear();
            bllusuario = new BLLUsuario();
            menu = new MenuPrincipal();
            bllrol = new BLLRol();
        }
        Loguear loguear;
        BLLUsuario bllusuario;
        MenuPrincipal menu;
        BLLRol bllrol;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if(loguear.LoguearUsuario(txtUsuario.Text, txtPassword.Text) == true)
                {
                    foreach(Usuario usuario in bllusuario.ListarTodo())
                    {
                        if(usuario.NombreUsuario == txtUsuario.Text)
                        {
                            menu.activar = true;
                            menu.UserAux = usuario;
                            menu.usuario = usuario;

                            foreach(Rol rol in bllrol.ListarTodo())
                            {
                                if(usuario.Rol == rol.IdRol)
                                {
                                    menu.Rolear = rol.Roll;
                                }
                            }
                        }
                    }
                   
                    this.Close();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("El usuario o password son incorrectos\nO no pertencen a un usuario");
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
