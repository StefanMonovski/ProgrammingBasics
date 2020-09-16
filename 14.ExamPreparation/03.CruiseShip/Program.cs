using System;

namespace _03.CruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruise = Console.ReadLine();
            string cabin = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceOneNight = 0;
            double priceTotal = 0;

            if (cruise == "Mediterranean")
            {
                if (cabin == "standard cabin")
                {
                    priceOneNight = 27.50;
                }
                else if (cabin == "cabin with balcony")
                {
                    priceOneNight = 30.20;
                }
                else if (cabin == "apartment")
                {
                    priceOneNight = 40.50;
                }
            }
            else if (cruise == "Adriatic")
            {
                if (cabin == "standard cabin")
                {
                    priceOneNight = 22.99;
                }
                else if (cabin == "cabin with balcony")
                {
                    priceOneNight = 25.00;
                }
                else if (cabin == "apartment")
                {
                    priceOneNight = 34.99;
                }
            }
            else if (cruise == "Aegean")
            {
                if (cabin == "standard cabin")
                {
                    priceOneNight = 23.00;
                }
                else if (cabin == "cabin with balcony")
                {
                    priceOneNight = 26.60;
                }
                else if (cabin == "apartment")
                {
                    priceOneNight = 39.80;
                }
            }
            if (nights > 7)
            {
                priceTotal = (4 * priceOneNight * nights) * 0.75;
            }
            else
            {
                priceTotal = (4 * priceOneNight * nights);
            }
            Console.WriteLine($"Annie's holiday in the {cruise} sea costs {priceTotal:F2} lv.");
        }
    }
}
