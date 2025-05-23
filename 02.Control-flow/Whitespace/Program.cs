using System;

namespace Whitespace
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This code reverses a messege, count the number of times a particula
             character appear, then print the results to the console window.
            */

            string origionalMessege = "The quick brown fox jump over the lazy dog.";

            char[] messege = origionalMessege.ToCharArray();
            Array.Reverse(messege);

            int letterCount = 0;

            foreach (char letter in messege)
            {
                if (letter == '0')
                {
                    letterCount++;
                }
            }
            string newMessege = new string(messege);

            Console.WriteLine(newMessege);
            Console.WriteLine($"'o' appears {letterCount} times");
        }
    }
}
