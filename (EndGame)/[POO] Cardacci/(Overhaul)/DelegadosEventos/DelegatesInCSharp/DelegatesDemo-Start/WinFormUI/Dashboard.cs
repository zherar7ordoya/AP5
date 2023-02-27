using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        readonly CarritoDeCompras cart = new CarritoDeCompras();

        public Dashboard()
        {
            InitializeComponent();
            PopulateCartWithDemoData();
        }

        private void PopulateCartWithDemoData()
        {
            cart.Items.Add(new Producto { Nombre = "Cereal", Precio = 3.63M });
            cart.Items.Add(new Producto { Nombre = "Milk", Precio = 2.95M });
            cart.Items.Add(new Producto { Nombre = "Strawberries", Precio = 7.51M });
            cart.Items.Add(new Producto { Nombre = "Blueberries", Precio = 8.84M });
        }

        private void messageBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.CalcularTotal(PrintSubtotal, CalculateTotal, PrintAlert);
            MessageBox.Show($"Total del carrito: {total:C2}");
        }

        private void textBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.CalcularTotal
                (
                subTotal => subTotalTextBox.Text = $"{subTotal:C2}",
                (products, subTotal) => subTotal - (products.Count * 2),
                message => { }
                );
            totalTextBox.Text = $"{total:C2}";
        }

        // -------------------------------------------------------------------*

        private void PrintSubtotal(decimal subtotal)
        {
            MessageBox.Show($"El subtotal es {subtotal:C}");
        }

        private decimal CalculateTotal(List<Producto> productos, decimal subtotal)
        {
            return subtotal - productos.Count;
        }
        
        private void PrintAlert(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

    }
}
