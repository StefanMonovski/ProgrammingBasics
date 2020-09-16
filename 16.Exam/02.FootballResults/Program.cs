using System;

namespace _02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int wins = 0;
            int losses = 0;
            int draws = 0;
            for (int i = 1; i <= 3; i++)
            {
                string matchResult = Console.ReadLine();
                char homeTeamGoalsChar = matchResult[0];
                char awayTeamGoalsChar = matchResult[2];
                int homeTeamGoals = (int)Char.GetNumericValue(homeTeamGoalsChar);
                int awayTeamGoals = (int)Char.GetNumericValue(awayTeamGoalsChar);
                if (homeTeamGoals > awayTeamGoals)
                {
                    wins++;
                }
                else if (homeTeamGoals < awayTeamGoals)
                {
                    losses++;
                }
                else if (homeTeamGoals == awayTeamGoals)
                {
                    draws++;
                }
            }
            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {losses} games.");
            Console.WriteLine($"Drawn games: {draws}");
        }
    }
}
