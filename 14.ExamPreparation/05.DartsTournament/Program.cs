using System;

namespace _05.DartsTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            int moves = 0;
            while (points > 0)
            {
                string sector = Console.ReadLine();
                moves++;
                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {moves} moves!"); return;
                }
                int currentPoints = int.Parse(Console.ReadLine());               
                if (sector == "number section")
                {
                    currentPoints = currentPoints * 1;
                    points -= currentPoints;
                }
                else if (sector == "double ring")
                {
                    currentPoints = currentPoints * 2;
                    points -= currentPoints;
                }
                else if (sector == "triple ring")
                {
                    currentPoints = currentPoints * 3;
                    points -= currentPoints;
                }                            
            }
            if (points == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {moves} moves!");
            }
            else
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(points)}.");
            }
        }
    }
}
