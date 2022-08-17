namespace Activity7_3
{
    public interface IAccount { string GetAccountInfo(); }

    public class CheckingAccount : IAccount
    {
        private int _accountNumber;
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string GetAccountInfo()
        {
            return "Printing checking account info for account number " + AccountNumber.ToString();
        }
    }
    public class SavingsAccount : IAccount
    {
        private int _accountNumber;
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string GetAccountInfo()
        {
            return "Printing savings account info for account number " + AccountNumber.ToString();
        }
    }

    //public abstract class Account
    //{
    //    private int _accountNumber;

    //    public int AccountNumber
    //    {
    //        get { return _accountNumber; }
    //        set { _accountNumber = value; }
    //    }

    //    public abstract string GetAccountInfo();
    //}

    //public class CheckingAccount : Account
    //{
    //    public override string GetAccountInfo()
    //    {
    //        return "Printing checking account info for account number " + AccountNumber.ToString();
    //    }
    //}

    //public class SavingsAccount : Account
    //{
    //    public override string GetAccountInfo()
    //    {
    //        return "Printing savings account info for account number " + AccountNumber.ToString();
    //    }
    //}
}
