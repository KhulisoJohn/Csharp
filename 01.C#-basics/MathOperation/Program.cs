using System;

namespace MathOperation {

    class Program {

        static void Main(string[] args) {

            //Perfom basic maths operations
            //Write code to perfom addition,subtraction, multiplecation, divition

            int sum = 7 + 5;
            int different = 7 -5;
            int product = 7 * 5;
            int qoutient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("different: " + different);
            Console.WriteLine("product: " + product);
            Console.WriteLine("Qoutient: " + qoutient);

            //Add code to perfom divition using literal decimal data
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine($"Decimal quotient:  {decimalQuotient}");

            //Write a code to determine the reminder after int divition

            Console.WriteLine($"Modulus of 200 / 5: {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5: {7 % 5}");

            //Write a code to exercise C# order of operation
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine($"{value1}\n{value2}");
        }
    }
}
