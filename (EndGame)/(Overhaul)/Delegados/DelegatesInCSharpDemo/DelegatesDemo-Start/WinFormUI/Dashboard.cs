using DemoLibrary;
using System;
using System.Collections.Generic;
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
            decimal total = cart.CalcularTotal(SubTotalAlert, CalculateLeveledDiscount, PrintOutDiscountAlert);
            MessageBox.Show($"The total for the cart is {total:C2}");
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

        // DELEGADOS ---------------------------------------------------------*

        private void PrintOutDiscountAlert(string discountMessage)
        {
            MessageBox.Show(discountMessage);
        }

        private void SubTotalAlert(decimal subTotal)
        {
            MessageBox.Show($"El subtotal es {subTotal:C}");
        }

        private decimal CalculateLeveledDiscount(List<Producto> productos, decimal subTotal)
        {
            return subTotal - productos.Count;
        }
    }
}
