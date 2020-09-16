using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = int.Parse(Console.ReadLine());

            for (int firstNumber = 1; firstNumber <= 9; firstNumber++)
            {
                if (myNumber % firstNumber != 0)
                {
                    continue;
                }
                for (int secondNumber = 1; secondNumber <= 9; secondNumber++)
                {
                    if (myNumber % secondNumber != 0)
                    {
                        continue;
                    }
                    for (int thirdNumber = 1; thirdNumber <= 9; thirdNumber++)
                    {
                        if (myNumber % thirdNumber != 0)
                        {
                            continue;
                        }
                        for (int fourthNumber = 1; fourthNumber <= 9; fourthNumber++)
                        {
                            if (myNumber % fourthNumber != 0)
                            {
                                continue;
                            }
                            else
                            {
                                Console.Write($"{firstNumber}{secondNumber}{thirdNumber}{fourthNumber} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
