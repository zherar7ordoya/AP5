using System;
using System.Collections.Generic;
using static System.Console;

namespace Activity7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of a list of account types.
            List<IAccount> AccountList = new List<IAccount>();
            //List<Account> AccountList = new List<Account>();

            // Create instances of CheckingAccount and SavingsAccount.
            CheckingAccount oCheckingAccount = new CheckingAccount();
            oCheckingAccount.AccountNumber = 100;
            SavingsAccount oSavingsAccount = new SavingsAccount();
            oSavingsAccount.AccountNumber = 200;

            // add the oCheckingAccount and oSavingsAccount to the list using the Add method of the list.
            AccountList.Add(oCheckingAccount);
            AccountList.Add(oSavingsAccount);

            // loop through the list and call the GetAccountInfo method of each account type in the list
            // and show the results in a console window.
            foreach (IAccount a in AccountList)
            //foreach (Account a in AccountList)
            {
                WriteLine(a.GetAccountInfo());
            }
            ReadLine();
        }
    }
}
