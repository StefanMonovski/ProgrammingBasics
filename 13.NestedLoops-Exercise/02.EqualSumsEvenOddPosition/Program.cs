using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                string currentNumber = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int n = 0; n < currentNumber.Length; n++)
                {
                    int currentDigit = int.Parse(currentNumber[n].ToString());
                    if (n % 2 == 1)
                    {
                        oddSum += currentDigit;
                    }
                    else if (n % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
