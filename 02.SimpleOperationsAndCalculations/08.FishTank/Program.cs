using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = length * width * hight;
            double litres = volume * 0.001;
            double necessaryLitres = litres * (1 - (percent * 0.01));
            Console.WriteLine($"{necessaryLitres:F3}");
            
        }
    }
}
