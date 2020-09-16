using System;

namespace _10.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int nights = days - 1;
            string typeRoom = Console.ReadLine();
            string feedback = Console.ReadLine();
            double priceDiscount = 0.0;
            double finalPrice = 0.0;

            if (typeRoom == "room for one person")
            {
                priceDiscount = nights * 18.00;
            }
            else if (typeRoom == "apartment")
            {
                if (days < 10)
                {
                    priceDiscount = (nights * 25.00) * 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    priceDiscount = (nights * 25.00) * 0.65;
                }
                else if (days > 15)
                {
                    priceDiscount = (nights * 25.00) * 0.5;
                }
            }
            else if (typeRoom == "president apartment")
            {
                if (days < 10)
                {
                    priceDiscount = (nights * 35.00) * 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    priceDiscount = (nights * 35.00) * 0.85;
                }
                else if (days > 15)
                {
                    priceDiscount = (nights * 35.00) * 0.80;
                }
            }

            if (feedback == "positive")
            {
                finalPrice = priceDiscount * 1.25;
                Console.WriteLine($"{finalPrice:F2}");
            }
            else if (feedback == "negative")
            {
                finalPrice = priceDiscount * 0.9;
                Console.WriteLine($"{finalPrice:F2}");
            }
        }
    }
}
