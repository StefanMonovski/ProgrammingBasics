using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerLimit = int.Parse(Console.ReadLine());
            int upperLimit = int.Parse(Console.ReadLine());
            int searchResult = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            for (int firstNum = lowerLimit; firstNum <= upperLimit; firstNum++)
            {
                for (int secondNum = lowerLimit; secondNum <= upperLimit; secondNum++)
                {
                    combinationCounter++;
                    if (firstNum + secondNum == searchResult)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({firstNum} + {secondNum} = {searchResult})");
                        return;
                    }                  
                }
            }
            Console.WriteLine($"{combinationCounter} combinations - neither equals {searchResult}");
        }
    }
}
