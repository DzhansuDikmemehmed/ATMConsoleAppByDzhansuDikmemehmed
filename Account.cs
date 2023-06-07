using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public abstract void DisplayBalance();

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit successful!");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful!");
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
    }
}
