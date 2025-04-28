using System;

namespace MyDataType {
     class Program {
        static void Main (string[] args) {

            //Printing different literal data types

            //use character literal 

             Console.Write ("Enter character here: ");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{letter}");

            //using string literal
            Console.Write("Enter your first name: ");
            string firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"my name is {firstName}");

            //using intiger literal
            Console.Write("Enter you age here:");
           int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I am {age} years old. ");

            //using float-point literals
            Console.Write("Enter float value here: ");
            float floatValue = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($" this {floatValue} number is a floatig point value. ");

            //using double literal
            Console.Write("Enter double value here: ");
            double doubleValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"this {doubleValue} number is a double");

            //using decimal literals
            Console.Write("Enter decimal value here: ");
            decimal decimalValue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"this {decimalValue} number is a decimal value. ");

            //using boolean literals
            Console.Write("Enter Boolean value here: ");
            bool boolValue = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"{boolValue}");
        }
     }
}
