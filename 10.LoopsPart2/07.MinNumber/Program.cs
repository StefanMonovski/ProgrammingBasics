using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNumber = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int i = 1;
            while (i <= numNumber)
            {
                int num = int.Parse(Console.ReadLine());
                i++;
                if (num < minNumber)
                {
                    minNumber = num;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
