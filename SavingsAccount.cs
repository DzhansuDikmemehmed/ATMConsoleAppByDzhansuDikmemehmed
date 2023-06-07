using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    public class SavingsAccount : Account
    {
        public override void DisplayBalance()
        {
            Console.WriteLine("Savings Account Balance: $" + Balance);
        }
    }
}
