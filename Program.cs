using ATMConsoleApp;
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = null;
            Client client = null;

            while (true)
            {
                Console.WriteLine("Enter 1 for Savings Account or 2 for Checking Account:");

                bool isValidInput = false;
                while (!isValidInput)
                {
                    try
                    {
                        int accountType = Convert.ToInt32(Console.ReadLine());

                        if (accountType == 1)
                        {
                            account = new SavingsAccount()
                            {
                                AccountNumber = "SA-1234",
                                Balance = 1000
                            };
                            isValidInput = true;
                        }
                        else if (accountType == 2)
                        {
                            account = new CheckingAccount()
                            {
                                AccountNumber = "CA-5678",
                                Balance = 500
                            };
                            isValidInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid account type. Please try again.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid account type.");
                    }
                }
                Console.WriteLine("Enter client information:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("PIN Code: ");
                int pinCode;
                while (!int.TryParse(Console.ReadLine(), out pinCode))
                {
                    Console.WriteLine("Invalid input. Please enter a valid PIN code.");
                    Console.Write("PIN Code: ");
                }

                client = new Client(name, pinCode);

                ATM atm = new ATM();

                atm.SetAccount(account); 

                while (true)
                {
                    Console.WriteLine("\nATM Menu:");
                    atm.DisplayMenu();

                    Console.Write("Enter your choice: ");
                    int choice;
                    while (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid menu option.");
                        Console.Write("Enter your choice: ");
                    }

                    switch (choice)
                    {
                        case 1:
                            BalanceInquiryTransaction balanceInquiry = new BalanceInquiryTransaction(account);
                            atm.ProcessTransaction(balanceInquiry);
                            break;
                        case 2:
                            DepositTransaction deposit = new DepositTransaction(account);
                            atm.ProcessTransaction(deposit);
                            break;
                        case 3:
                            WithdrawalTransaction withdrawal = new WithdrawalTransaction(account);
                            atm.ProcessTransaction(withdrawal);
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using the ATM. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }
    }
}
