using System;

namespace _05.Travaling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                double moneySaved = 0.0;

                while (moneySaved < moneyNeeded)
                {
                    double money = double.Parse(Console.ReadLine());
                    moneySaved += money;
                }
                if (moneySaved >= moneyNeeded)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
                destination = Console.ReadLine();
            }
            
        }
    }
}
