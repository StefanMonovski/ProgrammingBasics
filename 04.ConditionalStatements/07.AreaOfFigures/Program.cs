using System;

namespace _07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double AreaOfSquare = side * side;
                Console.WriteLine($"{AreaOfSquare:F3}");
            }

            if (figure == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double AreaOfRectangle = length * width;
                Console.WriteLine($"{AreaOfRectangle:F3}");
            }

            if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());           
                double AreaOfCircle = (radius * radius) * Math.PI;
                Console.WriteLine($"{AreaOfCircle:F3}");
            }

            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double AreaOfTriangle = (side * height) / 2;
                Console.WriteLine($"{AreaOfTriangle:F3}");
            }
        }
    }
}
