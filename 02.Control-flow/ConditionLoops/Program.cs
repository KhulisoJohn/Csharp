using System;

namespace ControlLoops

{
    class Program
    {
        static void Main()
        {
            //conditional statement example
            int number = 5;
            if (number > 0) Console.WriteLine("Positive");
            else if (number < 0) Console.WriteLine("Negative");
            else Console.WriteLine("zero");

            //Loop Example
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"The sum is equal to: {sum}");
    }
 }    
}