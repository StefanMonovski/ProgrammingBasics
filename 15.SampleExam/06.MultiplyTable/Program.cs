using System;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
       
            char firstDigitAsChar = number[number.Length - 1];
            char secondDigitAsChar = number[number.Length - 2];
            char thirdDigitAsChar = number[number.Length - 3];

            int firstDigit = (int)char.GetNumericValue(firstDigitAsChar);
            int secondDigit = (int)char.GetNumericValue(secondDigitAsChar);
            int thirdDigit = (int)char.GetNumericValue(thirdDigitAsChar);


            for (int i = 1; i <= firstDigit; i++)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    for (int k = 1; k <= thirdDigit; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }
        }
    }
}
