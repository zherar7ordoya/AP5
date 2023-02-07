using System;

namespace Activity7_2Starter
{
    class Account
    {
        private int _accountNumber;
        protected double _balance;

        public double Balance
        {
            get { return _balance; }
        }
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public double GetBalance()
        {
            if (AccountNumber == 1)
            {
                _balance = 1000;
                return _balance;
            }
            else if (AccountNumber == 2)
            {
                _balance = 2000;
                return _balance;
            }
            else
            {
                throw new ApplicationException("Account number incorrect.");
            }
        }
        public virtual double Withdraw(double amount)
        {
            _balance -= amount;
            return Balance;
            /*
            if (Balance >= amount)
            {
                _balance -= amount;
                return Balance;
            }
            else
            {
                throw new ApplicationException("Not enough funds.");
            }
            */
        }
    }
    class SavingsAccount : Account
    {
        public override double Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return -1; //Not enough funds.
            }
        }
    }
    class CheckingAccount : Account
    {
        public double GetMinimumBalance()
        {
            return 200;
        }
        public override double Withdraw(double amount)
        {
            if (Balance >= amount + GetMinimumBalance())
            {
                return base.Withdraw(amount);
                /*
                _balance -= amount;
                return Balance;
                */
            }
            else
            {

                return -1; //Not enough funds
            }
        }
    }
}
