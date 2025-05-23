using System;

namespace FraudulentOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fraudulentIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string OrderID in fraudulentIDs)
            {
                if (OrderID.StartsWith("B"))
                    Console.WriteLine(OrderID);  
            }
        }
    }
}