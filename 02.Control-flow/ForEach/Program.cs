using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inventory = [200, 450, 700, 175, 250];
            int sum = 0;
            int bin = 0;

            foreach (int items in inventory)
            {
                sum = sum + items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }

            Console.WriteLine($"We have {sum} items in inventory.");
            
        }
       
    }
}
