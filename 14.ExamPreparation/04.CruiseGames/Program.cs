using System;

namespace _04.CruiseGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            int numGames = int.Parse(Console.ReadLine());
            int volleyballGames = 0;
            int tennisGames = 0;
            int badmintonGames = 0;
            double totalPointsVolleyball = 0;
            double totalPointsTennis = 0;
            double totalPointsBadminton = 0;
            double avaragePointsVolleyball = 0;
            double avaragePointsTennis = 0;
            double avaragePointsBadminton = 0;
            double totalPoints = 0;
            for (int i = 1; i <= numGames; i++)
            {
                string game = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                if (game == "volleyball")
                {
                    volleyballGames++;
                    totalPointsVolleyball += (points + (points * 0.07));
                    totalPoints += points + (points * 0.07); continue;                  
                }
                else if (game == "tennis")
                {
                    tennisGames++;
                    totalPointsTennis += (points + (points * 0.05));
                    totalPoints += points + (points * 0.05); continue;               
                }
                else if (game == "badminton")
                {
                    badmintonGames++;
                    totalPointsBadminton += (points + (points * 0.02));
                    totalPoints += points + (points * 0.02); continue;
                }              
            }

            avaragePointsVolleyball = Math.Floor(totalPointsVolleyball / volleyballGames);
            avaragePointsTennis = Math.Floor(totalPointsTennis / tennisGames);
            avaragePointsBadminton = Math.Floor(totalPointsBadminton / badmintonGames);

            if (avaragePointsVolleyball >= 75 && avaragePointsTennis >= 75 && avaragePointsBadminton >= 75)
            {               
                Console.WriteLine($"Congratulations, {player}! You won the cruise games with {Math.Floor(totalPoints)} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {player}, you lost. Your points are only {Math.Floor(totalPoints)}.");
            }
            
        }
    }
}
