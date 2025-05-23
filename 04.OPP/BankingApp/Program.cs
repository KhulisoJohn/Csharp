using System;

namespace BankingApp {
    class BankAccount
    {

        private double balance;
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else {
                Console.WriteLine("Inficient Funds");
            }
        }
        public double GetBalance() {
            return balance;
        }
    }

    class Program {
        static void Main()
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            account.Withdraw(500);
            Console.WriteLine($"Balance: {account.GetBalance()}");
            
        }
    }
    
}
