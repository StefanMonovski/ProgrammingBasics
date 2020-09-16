using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            int num;

            for (int i = 1; i <= numNumbers; i++)
            {
                num = int.Parse(Console.ReadLine());
                
                if (maxNum < num)
                {
                    maxNum = num;
                }
                
                if (minNum > num)
                {
                    minNum = num;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
