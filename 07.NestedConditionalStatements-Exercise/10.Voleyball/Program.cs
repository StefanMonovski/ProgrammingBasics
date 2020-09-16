using System;

namespace _10.Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            double holidays = int.Parse(Console.ReadLine());
            double weekendsHome = int.Parse(Console.ReadLine());

            double weekendsSofia = 48 - weekendsHome;
            double gamesSofia = weekendsSofia * 3 / 4;
            double gamesHome = weekendsHome * 1.0;
            double gamesHolidays = holidays * 2 / 3;
            double gamesSum = gamesSofia + gamesHome + gamesHolidays;

            if (typeYear == "leap")
            {
                gamesSum = gamesSum * 1.15;
                Console.WriteLine(Math.Floor(gamesSum));
            }
            else if (typeYear == "normal")
            {
                Console.WriteLine(Math.Floor(gamesSum));
            }
        }
    }
}
