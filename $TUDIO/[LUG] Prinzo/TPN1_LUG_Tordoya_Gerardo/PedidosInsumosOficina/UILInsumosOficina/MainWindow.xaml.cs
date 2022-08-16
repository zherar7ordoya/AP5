using System.Windows;
using System.Data;
using BLLInsumosOficina;
using System;

//TODO: Implementar MDI (Ver: https://www.c-sharpcorner.com/UploadFile/8911c4/implement-mdi-multiple-document-interface-with-menu-contro/)

namespace UILInsumosOficina
{
    public partial class MainWindow : Window
    {
        DataSet _catalogo;
        BLLEmpleado _empleado;
        BLLOrden _orden;

        public MainWindow() => InitializeComponent();

        private void Despegue(object sender, RoutedEventArgs e)
        {
            BLLCatalogo catalogo = new BLLCatalogo();
            _catalogo = catalogo.ObtenerInfoProducto();
            DataContext = _catalogo.Tables["Categorias"];
            _orden = new BLLOrden();
            _empleado = new BLLEmpleado();
            OrdenesListView.ItemsSource = _orden.ItemsListado;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginDialogo dialogo = new LoginDialogo
            {
                Owner = this
            };

            dialogo.ShowDialog();

            if (dialogo.DialogResult == true)
            {
                _empleado.Usuario = dialogo.NombreTextBox.Text;
                _empleado.Contraseña = dialogo.ContraseñaTextBox.Password;
                if (_empleado.Login() == true)
                {
                    EstadoTextBlock.Text =
                        "Está logueado como empleado código " +
                        _empleado.IdEmpleado.ToString();
                }
                else
                {
                    MessageBox.Show("Necesita identificarse. Intente otra vez.");
                }
            }
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            //Close();
            Environment.Exit(0);
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            ItemDialogo dialogo = new ItemDialogo();

            DataRowView fila;
            fila = (DataRowView)ProductosDataGrid.SelectedItems[0];
            dialogo.IdProductoTextBox.Text = fila.Row.ItemArray[0].ToString();
            dialogo.PrecioTextBox.Text = fila.Row.ItemArray[4].ToString();
            dialogo.Owner = this;
            dialogo.ShowDialog();
            if (dialogo.DialogResult == true)
            {
                string idProducto = dialogo.IdProductoTextBox.Text;
                double precio = double.Parse(dialogo.PrecioTextBox.Text);
                int cantidad = int.Parse(dialogo.CantidadTextBox.Text);
                _orden.AgregarItem(new BLLItem(idProducto, precio, cantidad));
            }
        }

        private void Quitar_Click(object sender, RoutedEventArgs e)
        {
            if (OrdenesListView.SelectedItem != null)
            {
                var item = OrdenesListView.SelectedItem as BLLItem;
                _orden.QuitarItem(item.IdProducto);
            }
        }

        private void RealizarPedido_Click(object sender, RoutedEventArgs e)
        {
            if (_empleado.Logueado == true)
            {
                //TODO: Implementar Alta usando XML
                MessageBox.Show("Aún sin implementar");

                /*
                int id;
                id = _orden.RealizarPedido(_empleado.IdEmpleado);
                MessageBox.Show("Pedido efectuado con código de orden " + id.ToString());
                */
            }
            else
            {
                MessageBox.Show("Debe estar logueado para realizar un pedido.");
            }
        }
    }
}