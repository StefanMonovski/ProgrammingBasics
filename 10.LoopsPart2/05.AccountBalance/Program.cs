using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalIncreases = int.Parse(Console.ReadLine());
            double numIncrease = 1;
            double moneyIncrease = 0;
            double sum = 0;
            while (numIncrease <= totalIncreases)
            {
                moneyIncrease = double.Parse(Console.ReadLine());
                numIncrease++;
                if (moneyIncrease < 0)
                {
                    Console.WriteLine("Invalid operation!"); break;
                }
                sum += moneyIncrease;
                Console.WriteLine($"Increase: {moneyIncrease:F2}");


            }
            Console.WriteLine($"Total: {sum:F2}");


        }
    }
}


