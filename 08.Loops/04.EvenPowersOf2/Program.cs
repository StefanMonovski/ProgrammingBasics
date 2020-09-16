using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMax = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numMax; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
        }
    }
}
