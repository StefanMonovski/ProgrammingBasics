using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {            
            int numNumbers = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int i = 1;
            while (i <= numNumbers)
            {
                int num = int.Parse(Console.ReadLine());
                i++;
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
