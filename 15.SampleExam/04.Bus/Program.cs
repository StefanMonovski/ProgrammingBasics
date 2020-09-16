using System;

namespace _04.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int totalStops = int.Parse(Console.ReadLine());
            int totalPassengers = 0;
            for (int i = 1; i <= totalStops; i++)
            {
                int leavingPassengers = int.Parse(Console.ReadLine());
                int boardingPassengers = int.Parse(Console.ReadLine());

                passengers -= leavingPassengers;
                passengers += boardingPassengers;
            }
            if (totalStops % 2 == 1)
            {
                totalPassengers = passengers + 2;
            }
            else if (totalStops % 2 == 0)
            {
                totalPassengers = passengers;
            }
            Console.WriteLine($"The final number of passengers is : {totalPassengers}");
        }
    }
}
