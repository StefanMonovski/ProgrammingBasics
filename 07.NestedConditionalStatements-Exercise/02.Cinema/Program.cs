using System;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (projection == "Premiere")
            {
                income = rows * colums * 12.00;
            }
            else if (projection == "Normal")
            {
                income = rows * colums * 7.50;
            }
            else if (projection == "Discount")
            {
                income = rows * colums * 5.00;
            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}
