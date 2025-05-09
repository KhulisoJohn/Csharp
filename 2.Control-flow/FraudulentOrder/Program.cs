using System;

namespace FraudulentOrder
{
    class Public
    {
        static void Main(string[] args)
        {
            string[] fraudulentOrderIDs = new string[3];

            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "D123";
            Console.WriteLine($"Reassign: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            string[] goodOrderIDs = ["qw342", "09uu", "wer889"];
            string[] badOrderIDs = { "sjfd7d", "sier8", "wuwer4" };

            Console.WriteLine($"GoodOrders: {fraudulentOrderIDs[0] }");
        }
    }
}
