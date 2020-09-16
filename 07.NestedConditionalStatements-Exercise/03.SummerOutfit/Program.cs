using System;

namespace _03.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (temperature >= 10 && temperature <= 18)
            {
                if(time == "Morning")
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (time == "Afternoon")
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
                else if (time == "Evening")
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (temperature > 18 && temperature <= 24)
            {
                if (time == "Morning")
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
                else if (time == "Afternoon")
                {
                    Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                }
                else if (time == "Evening")
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (temperature >= 25)
            {
                if (time == "Morning")
                {
                    Console.WriteLine($"It's {temperature} degrees, get your T-Shirt and Sandals.");
                }
                else if (time == "Afternoon")
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Swim Suit and Barefoot.");
                }
                else if (time == "Evening")
                {
                    Console.WriteLine($"It's {temperature} degrees, get your Shirt and Moccasins.");
                }
            }
        }
    }
}
