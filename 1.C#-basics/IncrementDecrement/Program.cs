using System;

namespace IncrementDecrement {

    class Program {

        static void Main(string[] args) {

            //Write code to increment value 
            int value = 0;
            value = value + 5;
            value += 5;
            value++;
            Console.WriteLine(value);

            //Write code to increment and decrement value

            int firstNumber = 1;

            firstNumber = firstNumber + 1;
            Console.WriteLine("First increment: " + firstNumber);
            
            firstNumber += 1;
            Console.WriteLine("Second increment: " + firstNumber);

            firstNumber++;
            Console.WriteLine("Third increment: " + firstNumber);

            firstNumber = firstNumber - 1;
            Console.WriteLine("first decrement: " + firstNumber);

            firstNumber--;
            Console.WriteLine("second decrement: " + firstNumber);
        }
    }
}
