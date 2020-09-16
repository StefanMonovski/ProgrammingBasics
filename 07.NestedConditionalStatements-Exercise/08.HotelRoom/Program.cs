using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceApartment = 0.0;

            if (month == "May" || month == "October")
            {
                if (nights > 7  && nights <= 14)
                {
                    priceStudio = (nights * 50) * 0.95;
                    priceApartment = nights * 65;
                }
                else if (nights > 14)
                {
                    priceStudio = (nights * 50) * 0.70;
                    priceApartment = (nights * 65) * 0.90;
                }
                else
                {
                    priceStudio = nights * 50;
                    priceApartment = nights * 65;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    priceStudio = (nights * 75.20) * 0.80;
                    priceApartment = (nights * 68.70) * 0.90;
                }
                else
                {
                    priceStudio = nights * 75.20;
                    priceApartment = nights * 68.70;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    priceApartment = (nights * 77) * 0.90;
                    priceStudio = nights * 76;
                }
                else
                {
                    priceStudio = nights * 76;
                    priceApartment = nights * 77;
                }
            }

            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }
    }
}
