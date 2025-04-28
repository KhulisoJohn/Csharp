using System.IO;

namespace MyHelloWorld {

    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            var number = 1;
            if(number > 0) {
                Console.WriteLine("Positive");
            } else if(number < 0) {
                Console.WriteLine("Negative");
            } else {
                
                Console.WriteLine("Zero");
            }

            var switchValue = 0;
            
            switch (switchValue){
                case 0: Console.WriteLine("Zero");
                        break;

                case 1: Console.WriteLine("Negative");
                        break;

                default: Console.WriteLine("");
                break;
            }

            int sum = 0;
            int[] numbers = {1, 2, 3, 4, 5};
            for(int i = 0; i < numbers.Length; i++ ) {
                sum += numbers[i];
            }

            Console.WriteLine($"Total is: {sum}");
        }

        private static void PrintStudentInfo() {
            int age = 25;
            string name = "Alex";
            bool isStudent = true;
            double grade = 89.5;
            Console.WriteLine($"Name: {name}, Age: {age}, Student: {isStudent}, Grade: {grade}");
        }

    }
}
