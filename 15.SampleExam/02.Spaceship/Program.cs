using System;

namespace _02.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double avarageHeight = double.Parse(Console.ReadLine());

            double volumeSpaceship = width * length * height;
            double volumeRoom = (avarageHeight + 0.40) * 4;
            double sumRooms = Math.Floor(volumeSpaceship / volumeRoom);

            if (sumRooms >= 3 && sumRooms <= 10)
            {
                Console.WriteLine($"The spacecraft holds {sumRooms} astronauts.");
            }
            else if (sumRooms < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (sumRooms > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
