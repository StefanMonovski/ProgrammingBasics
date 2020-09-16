using System;

namespace _05.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double closetSide = double.Parse(Console.ReadLine());

            double hallSize = (length * 100) * (width * 100);
            double closetSize = ((closetSide * 100) * (closetSide * 100));
            double bench = (hallSize / 10);
            double freeSpace = (hallSize - closetSize - bench);
            double numDancers = (freeSpace / (40 + 7000));
            Console.WriteLine(Math.Floor(numDancers));
        }
    }
}
