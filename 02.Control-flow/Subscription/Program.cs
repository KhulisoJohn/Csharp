using System;

namespace Subscription
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12); // 0 to 11
            int discountPercentage = 0;

            if (daysUntilExpiration <= 1)
            {
                discountPercentage = 20;
                Console.WriteLine("Your subscription expires within a day!");
                Console.WriteLine($"Renew now and save {discountPercentage}%!");
            }
            else if (daysUntilExpiration <= 5)
            {
                discountPercentage = 10;
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                Console.WriteLine($"Renew now and save {discountPercentage}%!");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            else
            {
                Console.WriteLine("Your subscription has expired.");
            }
        }
    }
}

