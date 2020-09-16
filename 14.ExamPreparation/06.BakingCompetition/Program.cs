using System;

namespace _06.BakingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBakers = int.Parse(Console.ReadLine());
            int sumSweets = 0;
            double sumMoney = 0;

            for (int i = 0; i < numBakers; i++)
            {
                string name = Console.ReadLine();
                string input = Console.ReadLine();
                
                int sumCookies = 0;
                int sumCakes = 0;
                int sumWaffles = 0;

                while (input != "Stop baking!")
                {
                    int numSweets = int.Parse(Console.ReadLine());
                    
                    if (input == "cookies")
                    {
                        sumCookies += numSweets;
                        sumMoney += numSweets * 1.50;
                        sumSweets += numSweets;
                    }
                    else if (input == "cakes")
                    {
                        sumCakes += numSweets;
                        sumMoney += numSweets * 7.80;
                        sumSweets += numSweets;
                    }
                    else if (input == "waffles")
                    {
                        sumWaffles += numSweets;
                        sumMoney += numSweets * 2.30;
                        sumSweets += numSweets;
                    }                
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{name} baked {sumCookies} cookies, {sumCakes} cakes and {sumWaffles} waffles.");
            }
            Console.WriteLine($"All bakery sold: {sumSweets}");
            Console.WriteLine($"Total sum for charity: {sumMoney:F2} lv.");
        }
    }
}
