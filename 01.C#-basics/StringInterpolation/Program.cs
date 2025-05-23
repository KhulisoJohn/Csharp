using System;
 
 namespace StringInterpolation {

    class Program {

        static void Main (string[] args) {

            /* While string concatenation is simple and convinient, string interpolation
            is growing in popularity in situations where you need to combine many literals strings
            and variables into a single formatted messege */

            string firstName = "John";
            string messege = $"Hello {firstName}";
            Console.WriteLine(messege);

            //Use string interpulation with multiple variables and literal strings

            int version = 11;
            string updatedText = "Update to Windows";
            string msg =$"{updatedText} {version}";
            Console.WriteLine(msg);

            //Combine Verbatin literals and string intepolation
            string projectName = "First-Project";
            Console.WriteLine($@"c:\Output\{projectName}\Data");

            //Challenge Format and display instructions
            string workName = "ACME";
            string russianMessege = "\u043e\u0441\u043c\u043e\u0442\u0435\u044c\u0440\u0443\u0441\u043a\u0438\u0439\u0432\u043e\u0434";
            Console.WriteLine($"{workName} {russianMessege}");

        }
    }
 }
