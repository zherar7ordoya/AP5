/* TIM COREY
 * C# Events - Creating and Consuming Events in Your Application
 * https://youtu.be/-1cftB9q1kQ */

using DemoLibrary;
using System;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Transactions : Form
    {
        private readonly Customer _customer;
        public Transactions(Customer customer)
        {
            InitializeComponent();
            _customer = customer;

            customerText.Text = _customer.CustomerName;
            _customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        private void CheckingAccount_OverdraftEvent(object sender, OverdraftEventArgs e)
        {
            errorMessage.Visible = true;
        }

        private void MakePurchaseButton_Click(object sender, EventArgs e)
        {
            bool paymentResult = _customer.CheckingAccount.MakePayment("Credit Card Purchase", amountValue.Value, _customer.SavingsAccount);
            amountValue.Value = 0;
        }

        private void ErrorMessage_Click(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }
    }
}
