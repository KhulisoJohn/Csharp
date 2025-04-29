using System;

namespace NumberOperatio {

    class Program {

        static void Main(string[] args) {

            //Perform addition with implicit data conversion
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            //Mix datatypes to implicit type convertions
            string firstName = "John";
            int widgetSold = 7;
            Console.WriteLine(firstName + "sold " + widgetSold + "widget");

            //attempt a more advanced case of adding numbers and concatenating string
            string secondName = "khuliso";
            int widSold = 7;
            Console.WriteLine(secondName + " sold " + widSold + 7 + " widget");
            //instead of adding the widSold variable to the literal int 7, the compile treat everything as a string 

            //add  parentheses to clarify your interation to the compile
            Console.WriteLine(secondName + " sold " + (widSold +7) + " widget");


        }
    }
}
