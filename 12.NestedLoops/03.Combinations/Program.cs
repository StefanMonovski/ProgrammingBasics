using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = int.Parse(Console.ReadLine());
            int correctValue = 0;
            int sumNumbers;

            for (int x1 = 0; x1 <= result; x1++)
            {
               
                for (int x2 = 0; x2 <= result; x2++)
                {
                  
                    for (int x3 = 0; x3 <= result; x3++)
                    {
                        sumNumbers = x1 + x2 + x3;
                        if (sumNumbers == result)
                        {
                            correctValue++;
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine(correctValue);
        }
    }
}
