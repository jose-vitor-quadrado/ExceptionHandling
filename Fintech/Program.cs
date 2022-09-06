using System;
using System.Globalization;
using Fintech.Entities;
using Fintech.Entities.Exceptions;

namespace Fintech
{
    class Program 
    { 
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (AccountException error)
            {
                Console.WriteLine("Withdraw error: " + error.Message);
            }
            catch (FormatException error)
            {
                Console.WriteLine("Format error: " + error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine("Unexpected error: " + error.Message);
            }
        }
    }
}