using System;

namespace _01.SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyFood = double.Parse(Console.ReadLine());
            double moneySouveniers = double.Parse(Console.ReadLine());
            double moneyHotel = double.Parse(Console.ReadLine());

            double quantityGas = (420.0 / 100.0) * 7.0;
            double moneyGas = quantityGas * 1.85;
            double moneyFoodAndSouveniers = (moneyFood + moneySouveniers) * 3;
            double moneyFirstDayHotel = moneyHotel * 0.9;
            double moneySecondDayHotel = moneyHotel * 0.85;
            double moneyThirdDayHotel = moneyHotel * 0.8;

            double moneyTotal = moneyGas + moneyFoodAndSouveniers + moneyFirstDayHotel + moneySecondDayHotel + moneyThirdDayHotel;
            Console.WriteLine($"Money needed: {moneyTotal:F2}");
        }
    }
}
