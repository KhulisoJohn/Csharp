using System;
using System.Collections.Generic;

namespace CashierChangeAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cashier Change Assistant ===");

            // Get item cost
            Console.Write("Enter item cost (e.g. 150.75): R");
            double itemCost = Convert.ToDouble(Console.ReadLine());

            // Get amount paid
            Console.Write("Enter amount paid by customer: R");
            double amountPaid = Convert.ToDouble(Console.ReadLine());

            double change = Math.Round(amountPaid - itemCost, 2);

            if (change < 0)
            {
                Console.WriteLine("Insufficient amount paid! R{0} still due.", Math.Abs(change));
                return;
            }

            Console.WriteLine("\nChange due: R{0}", change);
            Console.WriteLine("Give back:");

            // South African denominations (rands and cents)
            double[] denominations = { 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.01 };

            foreach (double denom in denominations)
            {
                int count = (int)(change / denom);
                if (count > 0)
                {
                    Console.WriteLine("{0} x R{1}", count, denom);
                    change = Math.Round(change - (count * denom), 2); // prevent float precision issues
                }
            }

            Console.WriteLine("\nTransaction complete.");
        }
    }
}

