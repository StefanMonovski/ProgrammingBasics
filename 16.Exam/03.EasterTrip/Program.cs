using System;

namespace _03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double price = 0;

            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    price = 30;
                }
                else if (dates == "24-27")
                {
                    price = 35;
                }
                else if (dates == "28-31")
                {
                    price = 40;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    price = 28;
                }
                else if (dates == "24-27")
                {
                    price = 32;
                }
                else if (dates == "28-31")
                {
                    price = 39;
                }
            }
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    price = 32;
                }
                else if (dates == "24-27")
                {
                    price = 37;
                }
                else if (dates == "28-31")
                {
                    price = 43;
                }
            }
            double priceTotal = price * nights;
            Console.WriteLine($"Easter trip to {destination} : {priceTotal:F2} leva.");
        }
    }
}
