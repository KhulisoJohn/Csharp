using System;
using System.Globalization;

namespace LiteralVariablesApp
{
    class LiteralVariable
    {
        static void Main()
    {
        // Integer types
        byte smallNumber = 25;
        short shortNumber = 32000;
        int age = 24;
        long population = 8000000000L;

        // Floating-point types
        float temperature = 36.6f;
        double pi = 3.14159265358979;
        decimal bankBalance = 15000.75m;

        // Character and String
        char grade = 'A';
        string name = "Khulyso John";

        // Boolean
        bool isDeveloper = true;

        // Nullable type
        int? optionalValue = null;

        // Object type
        object mixedValue = "I can hold any type";
        object anotherMixedValue = 12345;

        //  Dynamic type
        dynamic flexible = "Hello World";
        flexible = 99.99; // can change type at runtime

        // Display results
        Console.WriteLine("=== C# Data Types in Action ===");
        Console.WriteLine($"Byte: {smallNumber}");
        Console.WriteLine($"Short: {shortNumber}");
        Console.WriteLine($"Int: {age}");
        Console.WriteLine($"Long: {population}");
        Console.WriteLine($"Float: {temperature}");
        Console.WriteLine($"Double: {pi}");
        Console.WriteLine($"Decimal: {bankBalance}");
        Console.WriteLine($"Char: {grade}");
        Console.WriteLine($"String: {name}");
        Console.WriteLine($"Bool: {isDeveloper}");
        Console.WriteLine($"Nullable Int: {optionalValue}");
        Console.WriteLine($"Object 1: {mixedValue}");
        Console.WriteLine($"Object 2: {anotherMixedValue}");
        Console.WriteLine($"Dynamic: {flexible}");
    }
    }
}

