using System;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMackerelForKg = double.Parse(Console.ReadLine());
            double priceSpratForKg = double.Parse(Console.ReadLine());
            double kgBonito = double.Parse(Console.ReadLine());
            double kgSaurel = double.Parse(Console.ReadLine());
            double kgClams = double.Parse(Console.ReadLine());

            double priceBonitoKg = priceMackerelForKg * 1.60;
            double priceTotalBonito = kgBonito * priceBonitoKg;

            double priceSaurelKg = priceSpratForKg * 1.80;
            double priceTotalSaurel = kgSaurel * priceSaurelKg;

            double priceTotalClams = kgClams * 7.50;

            double priceTotal = priceTotalBonito + priceTotalSaurel + priceTotalClams;
            Console.WriteLine($"{priceTotal:F2}");
        }
    }
}
