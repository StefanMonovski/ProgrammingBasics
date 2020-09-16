using System;

namespace _03.Numbers1ToNWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMax = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberMax; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
