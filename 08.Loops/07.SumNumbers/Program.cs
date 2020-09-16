using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 0; i < numNumbers; i++)
            {
                int num = int.Parse(Console.ReadLine());
                totalSum += num;
            }
            Console.WriteLine(totalSum);
        }
    }
}
