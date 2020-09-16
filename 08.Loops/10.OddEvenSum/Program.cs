using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersGroup = int.Parse(Console.ReadLine());
            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;

            for (int i = 0; i < numbersGroup; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEvenNumbers += num;
                }
                else if (i % 2 == 1)
                {
                    sumOddNumbers += num;
                }
            }

            if (sumEvenNumbers == sumOddNumbers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEvenNumbers}");
            }
            else if (sumEvenNumbers != sumOddNumbers)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEvenNumbers - sumOddNumbers)}");
            }
        }
    }
}
