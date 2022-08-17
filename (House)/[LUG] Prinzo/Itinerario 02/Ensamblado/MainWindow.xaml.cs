using System.Windows;
using Libreria;

namespace Ensamblados
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void Button_Click(object sender, RoutedEventArgs e) => Cita.MostrarCita();
    }
}
