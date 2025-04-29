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

        }
    }
 }
