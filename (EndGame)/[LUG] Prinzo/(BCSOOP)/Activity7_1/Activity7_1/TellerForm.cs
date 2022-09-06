using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activity7_1
{
    public partial class TellerForm : Form
    {
        public TellerForm()
        {
            InitializeComponent();
        }

        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            CheckingAccount oCheckingAccount = new CheckingAccount();
            SavingsAccount oSavingsAccount = new SavingsAccount();
            // Account oAccount = new Account();

            try
            {
                /*
                if (rdbChecking.Checked)
                {
                    txtBalance.Text =
                    oCheckingAccount.GetBalance(int.Parse(txtAccountNumber.Text)).ToString();
                }
                else if (rdbSavings.Checked)
                {
                    txtBalance.Text =
                    oSavingsAccount.GetBalance(int.Parse(txtAccountNumber.Text)).ToString();
                }
                else if (rdbGeneral.Checked)
                {
                    txtBalance.Text =
                    oAccount.GetBalance(int.Parse(txtAccountNumber.Text)).ToString();
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                SavingsAccount oSavingsAccount = new SavingsAccount();
                txtBalance.Text = oSavingsAccount.Withdraw(
                    int.Parse(txtAccountNumber.Text),
                    double.Parse(txtAmount.Text)
                    ).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = "";
            txtAmount.Text = "";
            txtBalance.Text = "";
        }
    }
}
