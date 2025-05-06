using System;

class DiceGame
{
    static void Main(string[] args)
    {
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll = {roll1} + {roll2} + {roll3} = {total}");

         if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
             if ((roll1 == roll2) && (roll2 == roll3)) 
                {
                    Console.WriteLine("You rolled tribled! + 6 bonus to total");
                     total += 6;
                }

                else 
                {
                    Console.WriteLine("You rolled double! + bonus to total");
                    total += 2;
                } 
                Console.WriteLine($"Your total including the bonus: {total}");
            }

            if (total >= 16) {
            Console.WriteLine("You win a new car!");
            }
        
         else if (total >= 10) 
            {
            Console.WriteLine("You win new laptop!");
             } else if (total >= 7)
             {
                Console.WriteLine("You win a kitten!");
             }
             else {
                Console.WriteLine("You lost the Game");
             }

        }
    }
