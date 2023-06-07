using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleApp
{
   public class Client
    {
        public string Name { get; }
        public int PinCode { get; }

        public Client(string name, int pinCode)
        {
            Name = name;
            PinCode = pinCode;
        }
    }
}
