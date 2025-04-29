using System;

namespace EscapeSequence {

     class Program {
        static  void Main(string[] args){
            // add newline  and tap
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("Hello\tWorld");dotdotnet run

            // add double qoutes arround the string
            Console.WriteLine("Hello \"World\"!");

            //using a backlash use double backlash to display single backlash
            Console.WriteLine("C:\\source\\repos");

            //format output using character escape sequence
            Console.WriteLine("Generating invoice for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory");

            //verbatim string literal
            Console.WriteLine(@"    c:\source\repos
            (this is where your code goes)");

            //format output using verbatim string literals
            Console.WriteLine(@"c:\invoices");

            //Unicode escape character
            //kon nichiwa World
            Console.WriteLine("\u3053\u306B\u3061\u306F World");

            //format output using unicode escape characters
             /* ti generate Japanese invoice:
             Nihon no seikyu-sho o seisei suru ni wa: */
             Console.WriteLine("\n\n\u65e5\u672c\u306e\u8acb\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
             //User command to run an application
             Console.WriteLine(@"c:\invoices\app.exe -j");
        }
     }
}