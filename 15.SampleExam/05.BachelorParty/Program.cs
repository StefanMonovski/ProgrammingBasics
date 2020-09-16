using System;

namespace _05.BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceSinger = int.Parse(Console.ReadLine());
            int totalIncome = 0;
            int totalGuests = 0;
            string input = Console.ReadLine();
            while (input != "The restaurant is full")
            {               
                int groupPeople = int.Parse(input);
                int price = 0;
                totalGuests += groupPeople;
                if (groupPeople < 5)
                {
                    price = groupPeople * 100;
                    totalIncome += price;
                }
                else
                {
                    price = groupPeople * 70;
                    totalIncome += price;
                }
                input = Console.ReadLine();
            }
            if (totalIncome - priceSinger >= 0)
            {
                Console.WriteLine($"You have {totalGuests} guests and {totalIncome - priceSinger} leva left.");
            }
            else if (totalIncome - priceSinger < 0)
            {
                Console.WriteLine($"You have {totalGuests} guests and {totalIncome} leva income, but no singer.");
            }
        }
    }
}
