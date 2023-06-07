using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    public class ATM
    {
        private Account account;

        public void SetAccount(Account acc)
        {
            account = acc;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
        }

        public void ProcessTransaction(ITransaction transaction)
        {
            transaction.Execute();
        }
    }
}
