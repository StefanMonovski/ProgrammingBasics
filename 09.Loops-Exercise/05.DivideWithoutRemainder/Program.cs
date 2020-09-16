using System;

namespace _05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());
            int dividedBy2 = 0;
            int dividedBy3 = 0;
            int dividedBy4 = 0;

            for (int i = 1; i <= numNumbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    dividedBy2++;
                }
                if (num % 3 == 0)
                {
                    dividedBy3++;
                }
                if (num % 4 == 0)
                {
                    dividedBy4++;
                }
            }

            double p2 = (dividedBy2 * 1.0) / numNumbers * 100;
            double p3 = (dividedBy3 * 1.0) / numNumbers * 100;
            double p4 = (dividedBy4 * 1.0) / numNumbers * 100;

            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
        }
    }
}
