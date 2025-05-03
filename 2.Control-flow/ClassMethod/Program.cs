using System;

namespace ClassMethod
{
    class program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}
