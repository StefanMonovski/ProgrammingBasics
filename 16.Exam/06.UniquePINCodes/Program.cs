using System;

namespace _06.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxFirstNumber = int.Parse(Console.ReadLine());
            int maxSecondNumber = int.Parse(Console.ReadLine());
            int maxThirdNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maxFirstNumber; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                for (int j = 1; j <= maxSecondNumber; j++)
                {
                    if (j != 2 && j != 3 && j != 5 && j != 7)
                    {
                        continue;
                    }
                    for (int k = 1; k <= maxThirdNumber; k++)
                    {
                        if (k % 2 == 1)
                        {
                            continue;
                        }
                        Console.WriteLine($"{i} {j} {k}");
                    }
                }
            }
        }
    }
}
