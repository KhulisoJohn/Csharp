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
            Console.WriteLine("You rolled double! + bonus to total");
          
          total += 2;
         } if ((roll1 == roll2) && (roll2 == roll3)) 
         {
            Console.WriteLine("You rolled tribled! + 6 bonus to total");
            total += 6;
         }

         if (total >= 15) {
            Console.WriteLine("You win the Game!");
        }
        
         if(total < 15) {
            Console.WriteLine("You Lost the Game!");
         }

    }
}
