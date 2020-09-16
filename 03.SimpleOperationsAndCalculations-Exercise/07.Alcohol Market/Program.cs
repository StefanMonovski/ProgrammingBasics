using System;

namespace _07.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double brandy = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double brandyPrice = (whiskeyPrice / 2);
            double winePrice = (brandyPrice - (0.4 * brandyPrice));
            double beerPrice = (brandyPrice - (0.8 * brandyPrice));

            double whiskeySum = (whiskeyPrice * whiskey);
            double beerSum = (beerPrice * beer);
            double wineSum = (winePrice * wine);
            double brandySum = (brandyPrice * brandy);

            double fullSum = (whiskeySum + beerSum + wineSum + brandySum);
            Console.WriteLine($"{fullSum:F2}");
        }
    }
}
