using System;

namespace _04.DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());
            int dividedBy2Counter = 0;
            int dividedBy3Counter = 0;
            int dividedBy4Counter = 0;

            for (int i = 1; i <= totalNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    dividedBy2Counter++;
                }
                if (number % 3 == 0)
                {
                    dividedBy3Counter++;
                }
                if (number % 4 == 0)
                {
                    dividedBy4Counter++;
                }
            }
            double p1 = dividedBy2Counter * 1.0 / totalNumbers * 100;
            double p2 = dividedBy3Counter * 1.0 / totalNumbers * 100;
            double p3 = dividedBy4Counter * 1.0 / totalNumbers * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
