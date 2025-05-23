using System;

namespace StringConcatenation {

    class Program {

        static void Main(string[] args) {
            string firstName = "Khulyso";
            string messege = "Hello " + firstName;
            Console.WriteLine($"{messege}");

            //Concatenate multiple variables and literals strings

            string name = "John";
            string greeting = "Hello";
            string msg = greeting + " " + name + "!";
            Console.WriteLine($"{msg}");

            //Avoiding intermediate variables

            string dzina = "Khuliso";
            string ndumeliso = "Ndi matsheloni";
            Console.WriteLine(ndumeliso + " " + dzina + "!");
        }
    }
}