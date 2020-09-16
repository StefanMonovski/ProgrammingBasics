using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double extras = double.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;

            if (extras > 150)
            {
                double sumClothes = (extras * priceClothes) * 0.90;
                double priceFilm = decor + sumClothes;
                            
                if (priceFilm <= budget)
                {
                    double leftMoney = budget - priceFilm;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
                }
                else if(priceFilm > budget)
                {
                    double neededMoney = priceFilm - budget;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
                }
            }

            else
            {
                double sumClothes = (extras * priceClothes);
                double priceFilm = decor + sumClothes;

                if (priceFilm <= budget)
                {
                    double leftMoney = budget - priceFilm;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
                }
                else if(priceFilm > budget)
                {
                    double neededMoney = priceFilm - budget;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
                }

            }

        }
    }
}
