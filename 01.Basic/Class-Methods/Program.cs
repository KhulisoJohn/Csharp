using System;

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Random dice1 = new Random();
int roll1 = dice1.Next();
int roll2 = dice1.Next(101);
int roll3 = dice1.Next(50, 101);

int firtsNumber = 500;
int secondNumber = 600;
int largeNumber;

largeNumber = Math.Max(firtsNumber, secondNumber);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
Console.WriteLine(largeNumber);


