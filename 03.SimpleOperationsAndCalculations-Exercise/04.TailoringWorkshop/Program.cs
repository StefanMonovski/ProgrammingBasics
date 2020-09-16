using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numTables = double.Parse(Console.ReadLine());
            double lengthTables = double.Parse(Console.ReadLine());
            double widthTables = double.Parse(Console.ReadLine());

            double AreaAllTableclothes = (numTables * (lengthTables + (2 * 0.30)) * (widthTables + (2 * 0.30)));
            double AreaAllTablecarriages = (numTables * (lengthTables / 2) * (lengthTables / 2));

            double PriceUSD = ((AreaAllTableclothes * 7) + (AreaAllTablecarriages * 9));
            double PriceBGN = (PriceUSD * 1.85);

            Console.WriteLine($"{PriceUSD:F2}" + " USD");
            Console.WriteLine($"{PriceBGN:F2}" + " BGN");
        }
    }
}
