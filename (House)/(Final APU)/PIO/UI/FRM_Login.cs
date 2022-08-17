using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI
{
    public partial class FRM_Login : Form
    {
        // *-----------------------------------------------------------=> ROBOT
        readonly BE.BE_Login BE_LOGIN;
        readonly BLL.BLL_Login BL_LOGIN;

        public FRM_Login()
        {
            InitializeComponent();
            BE_LOGIN = new BE.BE_Login();
            BL_LOGIN = new BLL.BLL_Login();
        }

        private void XButton_Click(object sender, EventArgs e) => this.Close();

        // *---------------------------------------------------=> TRANSPARENCIA

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e) => Informacion();
        private void ContraseñaTextBox_TextChanged(object sender, EventArgs e) => Informacion();
        private void Informacion()
        {
            InformacionTextBox.Text =
                $"USUARIO{Environment.NewLine}" +
                $"{UsuarioTextBox.Text}{Environment.NewLine}{Environment.NewLine}" +
                $"CONTRASEÑA{Environment.NewLine}" +
                $"{ContraseñaTextBox.Text}{Environment.NewLine}{Environment.NewLine}" +
                $"ENCRIPTADO{Environment.NewLine}" +
                $"{SEGURIDAD.Criptografia.Encriptar(ContraseñaTextBox.Text)}";
        }

        // *-----------------------------------------------------------=> LOGIN

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool user = Regex.IsMatch(UsuarioTextBox.Text, "^([a-zA-Z0-9]+$)");
            bool pass = Regex.IsMatch(ContraseñaTextBox.Text, "^([a-zA-Z0-9]+$)");

            if (user && pass)
            {
                try
                {
                    BE_LOGIN.Usuario = UsuarioTextBox.Text;
                    BE_LOGIN.Contraseña = SEGURIDAD.Criptografia.Encriptar(ContraseñaTextBox.Text);

                    bool respuesta = BL_LOGIN.VerificarLogin(BE_LOGIN.Usuario, BE_LOGIN.Contraseña);

                    if (respuesta)
                    {
                        MdiParent.Controls["PrincipalMenuStrip"].Enabled = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show
                            (
                            "Usuario y/o contraseña incorrecto(s)",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }
            }
            else { MessageBox.Show("Ingresó caracteres no válidos", "Error"); }
        }
    }
}
