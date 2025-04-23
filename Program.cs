//using System;

namespace BankApp
{
    class BankAccount
    {
        // Private field
        private decimal _balance;

        // Public method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Public method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid amount.");
            }
        }

        // Public method to get current balance
        public decimal GetBalance()
        {
            return _balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(500);
            account.Withdraw(200);
            Console.WriteLine($"Final Balance: {account.GetBalance():C}");
        }
    }
}