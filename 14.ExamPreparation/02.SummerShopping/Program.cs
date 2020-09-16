using System;

namespace _02.SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceTowel = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double priceUmbrella = priceTowel * 2 / 3;
            double priceFlipFlops = priceUmbrella * 0.75;
            double priceBeachBag = (priceTowel + priceFlipFlops) * 1 / 3;
            double priceTotal = priceTowel + priceUmbrella + priceFlipFlops + priceBeachBag;
            double priceDiscount = priceTotal - (priceTotal * discount / 100);
            if (budget >= priceDiscount)
            {
                Console.WriteLine($"Annie's sum is {priceDiscount:F2} lv. She has {budget - priceDiscount:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {priceDiscount:F2} lv. She needs {priceDiscount - budget:F2} lv. more.");
            }
        }
    }
}
