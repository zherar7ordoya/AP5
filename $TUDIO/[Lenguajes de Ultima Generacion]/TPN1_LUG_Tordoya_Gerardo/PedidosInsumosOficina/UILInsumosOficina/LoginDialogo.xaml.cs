using System.Windows;

namespace UILInsumosOficina
{
    public partial class LoginDialogo : Window
    {
        public LoginDialogo()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
