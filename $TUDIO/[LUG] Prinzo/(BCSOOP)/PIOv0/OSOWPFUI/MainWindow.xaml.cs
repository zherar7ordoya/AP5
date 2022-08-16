using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using OSOBLL;
using System.Collections.ObjectModel;

namespace OSOWPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataSet _dsProdCat;
        Employee _employee;
        Order _order;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProductCatalog prodCat = new ProductCatalog();
            _dsProdCat = prodCat.GetProductInfo();
            this.DataContext = _dsProdCat.Tables["Category"];
            _order = new Order();
            _employee = new Employee();
            this.orderListView.ItemsSource = _order.OrderItemList;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            LoginDialog dlg = new LoginDialog
            {
                Owner = this
            };
            dlg.ShowDialog();
            // Process data entered by user if dialog box is accepted
            if (dlg.DialogResult == true)
            {
                _employee.LoginName = dlg.nameTextBox.Text;
                _employee.Password = dlg.passwordTextBox.Password;
                if (_employee.LogIn() == true)
                {
                    this.statusTextBlock.Text = "You are logged in as employee number " +
                      _employee.EmployeeID.ToString();
                }
                else
                {
                    MessageBox.Show("You could not be verified. Please try again.");
                }
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            OrderItemDialog orderItemDialog = new OrderItemDialog();

            DataRowView selectedRow;
            selectedRow = (DataRowView)this.ProductsDataGrid.SelectedItems[0];
            orderItemDialog.productIdTextBox.Text = selectedRow.Row.ItemArray[0].ToString();
            orderItemDialog.unitPriceTextBox.Text = selectedRow.Row.ItemArray[4].ToString();
            orderItemDialog.Owner = this;
            orderItemDialog.ShowDialog();
            if (orderItemDialog.DialogResult == true)
            {
                string productId = orderItemDialog.productIdTextBox.Text;
                double unitPrice = double.Parse(orderItemDialog.unitPriceTextBox.Text);
                int quantity = int.Parse(orderItemDialog.quantityTextBox.Text);
                _order.AddItem(new OrderItem(productId, unitPrice, quantity));
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.orderListView.SelectedItem != null)
            {
                var selectedOrderItem = this.orderListView.SelectedItem as OrderItem;
                _order.RemoveItem(selectedOrderItem.ProdID);
            }
        }

        private void PlaceOrderButton_Click(object sender, RoutedEventArgs e)
        {
            if (_employee.LoggedIn == true)
            {
                //place order
                int orderId;
                orderId = _order.PlaceOrder(_employee.EmployeeID);
                MessageBox.Show("Your order has been placed. Your order id is " +
                     orderId.ToString());
            }
            else
            {
                MessageBox.Show("You must be logged in to place an order.");
            }
        }
    }
}