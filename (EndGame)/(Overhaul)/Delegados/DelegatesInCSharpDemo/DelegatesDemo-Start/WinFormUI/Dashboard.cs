using DemoLibrary;
using System;
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
            
        }

        private void PrintOutDiscountAlert(string discountMessage)
        {
            
        }

        private void textBoxDemoButton_Click(object sender, EventArgs e)
        {
        }
    }
}
