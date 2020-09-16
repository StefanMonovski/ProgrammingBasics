using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrimeNumbers = 0;
            int sumNonPrimeNumbers = 0;
            int counter = 0;
            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine($"Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        counter++;
                    }               
                }

                if (counter > 2)
                {
                    sumNonPrimeNumbers += number;
                    counter = 0;
                }
                if (counter == 2)
                {
                    sumPrimeNumbers += number;
                    counter = 0;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumbers}");
        }
    }
}

