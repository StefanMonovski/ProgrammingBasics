using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());
            double sumNumbersP1 = 0;           
            double sumNumbersP2 = 0;           
            double sumNumbersP3 = 0;           
            double sumNumbersP4 = 0;           
            double sumNumbersP5 = 0;

            for (int i = 1; i <= numNumbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    sumNumbersP1++;
                }
                else if (num < 400)
                {
                    sumNumbersP2++;
                }
                else if (num < 600)
                {
                    sumNumbersP3++;
                }
                else if (num < 800)
                {
                    sumNumbersP4++;
                }
                else if (num <= 1000)
                {
                    sumNumbersP5++;
                }
            }

            double p1 = sumNumbersP1 / numNumbers * 100;
            double p2 = sumNumbersP2 / numNumbers * 100;
            double p3 = sumNumbersP3 / numNumbers * 100;
            double p4 = sumNumbersP4 / numNumbers * 100;
            double p5 = sumNumbersP5 / numNumbers * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");

        }
    }
}
