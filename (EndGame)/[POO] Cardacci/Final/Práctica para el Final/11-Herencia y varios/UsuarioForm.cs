using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Herencia
{
    public partial class UsuarioForm : Form
    {
        IComparer<Usuario> NombreOrdenDescendiente = new Usuario.NombreDesc();

        public UsuarioForm() => InitializeComponent();

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            Usuario usuario = new UsuarioPremium();
            usuario.MayorEventHandler += new EventHandler<MayorEventArgs>(SoyMayor);
            usuario.MenorEventHandler += SoyMenor;
            usuario.Id = 7;
            usuario.Edad = 50;
            usuario.Nombre = "Gerardo Tordoya";

            foreach (string texto in usuario)
            {
                MessageBox.Show(texto);
            }

            List<Usuario> _lista = new List<Usuario>
            {
                usuario,
                new UsuarioPremium(101, "Alfa", 11),
                new UsuarioPremium(102, "Beta", 22),
                new UsuarioPremium(103, "Gamma", 33)
            };
            _lista.Sort(NombreOrdenDescendiente);

            UsuariosDgv.DataSource = null;
            UsuariosDgv.DataSource = _lista;
        }

        private void SoyMayor(object sender, MayorEventArgs e) => MessageBox.Show("Soy Mayor");
        private void SoyMenor(object sender, EventArgs e) => MessageBox.Show("Soy Menor");
    }


}
