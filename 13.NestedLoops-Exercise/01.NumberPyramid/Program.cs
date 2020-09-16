using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            int numbersOnLine = 0;
            int permitedNumbersOnLine = 1;
            for (int i = 1; i <= maxNumber; i++)
            {
                Console.Write($"{i} ");
                numbersOnLine++;
                if (numbersOnLine == permitedNumbersOnLine)
                {
                    Console.WriteLine();
                    numbersOnLine = 0;
                    permitedNumbersOnLine++;
                }
            }
        }
    }
}
