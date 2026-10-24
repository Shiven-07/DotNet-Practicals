using System;

namespace BankAccountApp
{
    class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Account number cannot be empty!");
                accountNumber = value;
            }
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Balance cannot be negative!");
                balance = value;
            }
        }

        public BankAccount(string accNo, double initialBalance)
        {

AccountNumber = accNo;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit must be positive.");
            Balance += amount;
            Console.WriteLine($"Deposited Rs.{amount}. New Balance: Rs.{Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance) throw new InvalidOperationException("Insufficient funds!");

            Balance -= amount;
            Console.WriteLine($"Withdrawn Rs.{amount}. New Balance: Rs.{Balance}");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Account: {AccountNumber} | Balance: Rs.{Balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bank Account Demo ===");
            BankAccount acc = new BankAccount("ACC1001", 5000);
            acc.DisplayInfo();
            acc.Deposit(2000);
            acc.Withdraw(1500);
            acc.DisplayInfo();

            Console.WriteLine("\nTrying negative balance:");
            try { acc.Balance = -100; }
            catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }

Console.WriteLine("\nTrying overdraft:");
            try { acc.Withdraw(50000); }
            catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }

            Console.ReadKey();
        }
    }
}
