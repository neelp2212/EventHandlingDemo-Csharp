using System;

namespace SimpleATM
{
    class Program
    {
        // User Account details
        static string cardNumber = "123456";
        static int pin = 1234;
        static decimal balance = 1000.00m;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simple ATM!");

            // Authenticate the user
            if (!Login())
            {
                Console.WriteLine("Login failed. Exiting...");
                return;
            }

            // Display menu and process user's choice
            bool exit = false;
            while (!exit)
            {
                ShowMenu();
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CheckBalance();
                        break;
                    case "2":
                        Deposit();
                        break;
                    case "3":
                        Withdraw();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using Simple ATM. Goodbye!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static bool Login()
        {
            Console.Write("Enter your card number: ");
            string inputCard = Console.ReadLine();

            Console.Write("Enter your PIN: ");
            int inputPin;
            if (!int.TryParse(Console.ReadLine(), out inputPin))
            {
                Console.WriteLine("Invalid PIN format.");
                return false;
            }

            if (inputCard == cardNumber && inputPin == pin)
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect card number or PIN.");
                return false;
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("\n=== ATM Menu ===");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: {balance:C}");
        }

        static void Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            decimal amount;
            if (decimal.TryParse(Console.ReadLine(), out amount) && amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please try again.");
            }
        }

        static void Withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal amount;
            if (decimal.TryParse(Console.ReadLine(), out amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. Please try again.");
            }
        }
    }
}
