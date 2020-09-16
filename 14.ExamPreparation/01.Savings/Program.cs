using System;

namespace _01.Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());

            double unexpectedPayments = income * 0.3;
            double savings = income - (expenses + unexpectedPayments);
            double totalSavings = months * savings;
            double percentSavings = (savings / income) * 100;
            Console.WriteLine($"She can save {percentSavings:F2}%");
            Console.WriteLine($"{totalSavings:F2}");
        }
    }
}
