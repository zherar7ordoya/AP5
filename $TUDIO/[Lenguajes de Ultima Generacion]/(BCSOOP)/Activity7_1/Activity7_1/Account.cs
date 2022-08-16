using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_1
{
    abstract class Account
    {
        int _accountNumber;
        protected double GetBalance(int accountNumber)
        {
            _accountNumber = accountNumber;
            //Data normally retrieved from database.
            if (_accountNumber == 1)
            {
                return 1000;
            }
            else if (_accountNumber == 2)
            {
                return 2000;
            }
            else
            {
                return -1; //Account number is incorrect
            }
        }
    }
    class CheckingAccount : Account
    {
    }
    class SavingsAccount : Account
    {
        double _dblBalance;
        public double Withdraw(int accountNumber, double amount)
        {
            _dblBalance = GetBalance(accountNumber);
            if (_dblBalance >= amount)
            {
                _dblBalance -= amount;
                return _dblBalance;
            }
            else
            {
                return -1; //Not enough funds
            }
        }
    }
}
