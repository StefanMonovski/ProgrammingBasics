using System;

namespace _08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVacation = double.Parse(Console.ReadLine());
            double totalPuzzles = double.Parse(Console.ReadLine());
            double totalDolls = double.Parse(Console.ReadLine());
            double totalBears = double.Parse(Console.ReadLine());
            double totalMinions = double.Parse(Console.ReadLine());
            double totalTrucks = double.Parse(Console.ReadLine());

            double totalToys = totalPuzzles + totalDolls + totalBears + totalMinions + totalTrucks;

            double pricePuzzles = totalPuzzles * 2.60;
            double priceDolls = totalDolls * 3;
            double priceBears = totalBears * 4.10;
            double priceMinions = totalMinions * 8.20;
            double priceTrucks = totalTrucks * 2;

            double priceTotal = pricePuzzles + priceDolls + priceBears + priceMinions + priceTrucks;
            
             if (totalToys >= 50)
            {

                double priceTotalDiscount = priceTotal * 0.75;
                double priceTotalDiscountAndRent = priceTotalDiscount * 0.90;

                if (priceTotalDiscountAndRent >= priceVacation)
                {
                    double moneyLeft = priceTotalDiscountAndRent - priceVacation;
                    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
                }
                else if (priceTotalDiscountAndRent <= priceVacation)
                {
                    double moneyNeed = priceVacation - priceTotalDiscountAndRent;
                    Console.WriteLine($"Not enough money! {moneyNeed:F2} lv needed.");
                }


            }
            else
            {
                double priceTotalDiscount = priceTotal;
                double priceTotalDiscountAndRent = priceTotalDiscount * 0.90;

                if (priceTotalDiscountAndRent >= priceVacation)
                {
                    double moneyLeft = priceTotalDiscountAndRent - priceVacation;
                    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
                }
                else if (priceTotalDiscountAndRent <= priceVacation)
                {
                    double moneyNeed = priceVacation - priceTotalDiscountAndRent;
                    Console.WriteLine($"Not enough money! {moneyNeed:F2} lv needed.");
                }
            }
            
            
        }
    }
}


