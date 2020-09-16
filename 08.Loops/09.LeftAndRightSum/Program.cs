using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersGroup = int.Parse(Console.ReadLine());
            int leftNumbers;
            int leftSum = 0;
            int rightNumbers;
            int rightSum = 0;
            for (int i = 0; i < numbersGroup; i++)
            {
                leftNumbers = int.Parse(Console.ReadLine());
                leftSum += leftNumbers;
            }
            for (int i = numbersGroup; i < numbersGroup * 2; i++)
            {
                rightNumbers = int.Parse(Console.ReadLine());
                rightSum += rightNumbers;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else if (leftSum != rightSum)
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
