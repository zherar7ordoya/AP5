using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Herencia_y_varios
{
    public partial class UsuarioForm : Form
    {
        IComparer<Usuario> NomDesc = new Usuario.NombreDesc();

        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            Usuario usuario = new UsuarioPremium();
            usuario.MayorEventHandler += new EventHandler<SoyMayorEventArgs>(SoyMayor);
            usuario.MenorEventHandler += SoyMenor;
            usuario.Id = 124;
            usuario.Edad = 24;
            usuario.Nombre = "Gerardo";

            foreach (string texto in usuario)
            {
                MessageBox.Show(texto);
            }

            List<Usuario> _lista = new List<Usuario>
            {
                usuario,
                new UsuarioPremium(101, "Alfa"),
                new UsuarioPremium(102, "Beta"),
                new UsuarioPremium(103, "Gamma")
            };
            _lista.Sort(NomDesc);

            UsuariosDgv.DataSource = null;
            UsuariosDgv.DataSource = _lista;
        }

        private void SoyMayor(object sender, SoyMayorEventArgs e)
        {
            MessageBox.Show("Soy Mayor");
        }

        private void SoyMenor(object sender, EventArgs e)
        {
            MessageBox.Show("Soy Menor");
        }
    }


}
