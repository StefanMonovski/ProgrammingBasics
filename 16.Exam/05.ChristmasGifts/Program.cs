using System;

namespace _05.ChristmasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numAdults = 0;
            int numKids = 0;
            int moneyToys = 0;
            int moneySweaters = 0;

            while (input != "Christmas")
            {
                int age = int.Parse(input);
                if (age < 1 && age > 130)
                {
                    break;
                }
                if (age <= 16)
                {
                    numKids++;
                    moneyToys += 5;
                }
                else if (age > 16)
                {
                    numAdults++;
                    moneySweaters += 15;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {numAdults}");
            Console.WriteLine($"Number of kids: {numKids}");
            Console.WriteLine($"Money for toys: {moneyToys}");
            Console.WriteLine($"Money for sweaters: {moneySweaters}");
        }
    }
}
