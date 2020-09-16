using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int sum = ((hours * 60) + minutes + 15);
            int resultHours = sum / 60;
            if (resultHours >= 24)
            {
                resultHours = resultHours - 24;
            }
            int resultMinutes = sum % 60;

            if (resultMinutes < 10)
            {
                Console.WriteLine($"{resultHours}:0{resultMinutes}");
            }
            else
            {
                Console.WriteLine($"{resultHours}:{resultMinutes}");
            }
        }
    }
}

