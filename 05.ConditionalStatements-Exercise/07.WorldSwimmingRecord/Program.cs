using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double recordDistance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());

            double timeNeeded = recordDistance * timeForMeter;
            double waterResistance = Math.Floor(recordDistance / 15) * 12.5;
            double attemptTime = timeNeeded + waterResistance;
            
            if (attemptTime < recordTime)
            {
                double beatenSeconds = recordTime - attemptTime;
                Console.WriteLine($"Yes, he succeeded! The new world record is {attemptTime:F2} seconds.");
            }
            else 
            {
                double neededSeconds = attemptTime - recordTime;
                Console.WriteLine($"No, he failed! He was {neededSeconds:F2} seconds slower.");
            }
        }
    }
}
