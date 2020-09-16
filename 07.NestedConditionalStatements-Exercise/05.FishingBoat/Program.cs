using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0.0;
            double priceDiscount = 0.0;

            if (fishermen <= 6 && season == "Spring")
            {
                price = 3000 * 0.9;
                if (fishermen % 2 == 0)
                {
                    priceDiscount = price * 0.95; 
                }
                else
                {
                    priceDiscount = price;
                }
            }
            
            if (fishermen <= 6 && season == "Summer")
            {
                price = 4200 * 0.9;
                if (fishermen % 2 == 0)
                {
                    priceDiscount = price * 0.95;
                }
                else
                {
                    priceDiscount = price;
                }
            }

            if (fishermen <= 6 && season == "Autumn")
            {
                price = 4200 * 0.9;
                priceDiscount = price;
            }

            if (fishermen <= 6 && season == "Winter")
            {
                price = 2600 * 0.9;
                if (fishermen % 2 == 0)
                {
                    priceDiscount = price * 0.95;
                }
                else
                {
                    priceDiscount = price;
                }
            }
            //
            if (fishermen >= 7 && fishermen <= 11 && season == "Spring")
            {
                price = 3000 * 0.85;
                if (fishermen % 2 == 0)
                {
                    priceDiscount = price * 0.95;
                }
                else
                {
                    priceDiscount = price;
                }
            }

            if (fishermen >= 7 && fishermen <= 11 && season == "Summer")
            {
                price = 4200 * 0.85;
                if (fishermen % 2 == 0)
                {
                    priceDiscount = price * 0.95;
                }
                else
                {
                    priceDiscount = price;
                }
            }

            if (fishermen >= 7 && fishermen <= 11 && season == "Autumn")
            {
                price = 4200 * 0.85;
                priceDiscount = price;
            }

            if (fishermen >= 7 && fishermen <= 11 && season == "Winter")
            {
                price = 2600 * 0.85;
                if (fishermen % 2 == 0)
                {
                    priceDiscount = price * 0.95;
                }
                else
                {
                    priceDiscount = price;
                }
            }
            //
            if (fishermen > 11 && season == "Spring")
            {
                price = 3000 * 0.75;
                if (fishermen % 2 == 0)
                {
                    priceDiscount = price * 0.95;
                }
                else
                {
                    priceDiscount = price;
                }
            }

            if (fishermen > 11 && season == "Summer")
            {
                price = 4200 * 0.75;
                if (fishermen % 2 == 0)
                {
                    priceDiscount = price * 0.95;
                }
                else
                {
                    priceDiscount = price;
                }
            }

            if (fishermen > 11 && season == "Autumn")
            {
                price = 4200 * 0.75;
                priceDiscount = price;
            }

            if (fishermen > 11 && season == "Winter")
            {
                price = 2600 * 0.75;
                if (fishermen % 2 == 0)
                {
                    priceDiscount = price * 0.95;
                }
                else
                {
                    priceDiscount = price;
                }
            }

            if (priceDiscount <= budget)
            {
                Console.WriteLine($"Yes! You have {(budget - priceDiscount):F2} leva left.");
            }
            else if (priceDiscount > budget)
            {
                Console.WriteLine($"Not enough money! You need {(priceDiscount - budget):F2} leva.");
            }
        }
    }
}
