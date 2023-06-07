using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    public class WithdrawalTransaction : ITransaction
    {
        private Account account;
        private Action<Account> setAccount;

        public WithdrawalTransaction(Account acc)
        {
            account = acc;
        }

        public WithdrawalTransaction(Action<Account> setAccount)
        {
            this.setAccount = setAccount;
        }

        public void Execute()
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            account.Withdraw(amount);
        }
    }
}
