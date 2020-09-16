using System;

namespace _03.SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            double priceSushi = 0.0;
            double priceTotal = 0.0;
            string restaurant = Console.ReadLine();
            int portions = int.Parse(Console.ReadLine());
            string delivery = Console.ReadLine();
            

            if (restaurant == "Sushi Zone")
            {
                if (sushi == "sashimi")
                {
                    priceSushi = 4.99;
                }
                else if (sushi == "maki")
                {
                    priceSushi = 5.29;
                }
                else if (sushi == "uramaki")
                {
                    priceSushi = 5.99;
                }
                else if (sushi == "temaki")
                {
                    priceSushi = 4.29;
                }
            }
            else if (restaurant == "Sushi Time")
            {
                if (sushi == "sashimi")
                {
                    priceSushi = 5.49;
                }
                else if (sushi == "maki")
                {
                    priceSushi = 4.69;
                }
                else if (sushi == "uramaki")
                {
                    priceSushi = 4.49;
                }
                else if (sushi == "temaki")
                {
                    priceSushi = 5.19;
                }
            }
            else if (restaurant == "Sushi Bar")
            {
                if (sushi == "sashimi")
                {
                    priceSushi = 5.25;
                }
                else if (sushi == "maki")
                {
                    priceSushi = 5.55;
                }
                else if (sushi == "uramaki")
                {
                    priceSushi = 6.25;
                }
                else if (sushi == "temaki")
                {
                    priceSushi = 4.75;
                }
            }
            else if (restaurant == "Asian Pub")
            {
                if (sushi == "sashimi")
                {
                    priceSushi = 4.50;
                }
                else if (sushi == "maki")
                {
                    priceSushi = 4.80;
                }
                else if (sushi == "uramaki")
                {
                    priceSushi = 5.50;
                }
                else if (sushi == "temaki")
                {
                    priceSushi = 5.50;  
                }
            }
            else
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!"); return;
            }

            if (delivery == "Y")
            {
                priceTotal = (priceSushi * portions) * 1.20;
            }
            else if (delivery == "N")
            {
                priceTotal = priceSushi * portions;
            }
            Console.WriteLine($"Total price: {Math.Ceiling(priceTotal)} lv.");
        }
    }
}
