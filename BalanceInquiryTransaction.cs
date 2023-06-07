using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    public class BalanceInquiryTransaction : ITransaction
    {
        private Account account;
        private Action<Account> setAccount;

        public BalanceInquiryTransaction(Account acc)
        {
            account = acc;
        }

        public BalanceInquiryTransaction(Action<Account> setAccount)
        {
            this.setAccount = setAccount;
        }

        public void Execute()
        {
            account.DisplayBalance();
        }
    }
}
