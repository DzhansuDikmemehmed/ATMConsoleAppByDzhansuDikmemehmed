using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    public class DepositTransaction : ITransaction
    {
        private Account account;
        private Action<Account> setAccount;

        public DepositTransaction(Account acc)
        {
            account = acc;
        }

        public DepositTransaction(Action<Account> setAccount)
        {
            this.setAccount = setAccount;
        }

        public void Execute()
        {
            Console.Write("Enter the amount to deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            account.Deposit(amount);
        }
    }
}
