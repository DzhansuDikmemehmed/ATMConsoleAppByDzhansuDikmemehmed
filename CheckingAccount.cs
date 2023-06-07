using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
    public class CheckingAccount : Account
    {
        public override void DisplayBalance()
        {
            Console.WriteLine("Checking Account Balance: $" + Balance);
        }
    }
}
