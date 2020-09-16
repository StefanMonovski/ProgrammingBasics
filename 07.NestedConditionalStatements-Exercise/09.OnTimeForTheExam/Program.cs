using System;

namespace _09.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int startHourTest = int.Parse(Console.ReadLine());
            int startMinTest = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minArrive = int.Parse(Console.ReadLine());
            int startTimeTestSum = (startHourTest * 60) + startMinTest;
            int arriveTimeSum = (hourArrive * 60) + minArrive;
            int difference = startTimeTestSum - arriveTimeSum;
            int resultHour = Math.Abs(difference / 60);
            int resultMin = Math.Abs(difference % 60);
            string late = "Late";
            string onTime = "On time";
            string early = "Early";

            if (difference < 0)
            {
                if (resultHour < 1)
                {
                    Console.WriteLine(late);
                    Console.WriteLine($"{resultMin} minutes after the start");
                }
                else if (resultHour >= 1 && resultMin < 10)
                {
                    Console.WriteLine(late);
                    Console.WriteLine($"{resultHour}:0{resultMin} hours after the start");
                }
                else if (resultHour >= 1)
                {
                    Console.WriteLine(late);
                    Console.WriteLine($"{resultHour}:{resultMin} hours after the start");
                }
            }
            else if (difference == 0)
            {
                Console.WriteLine(onTime);
            }
            else if (difference > 0)
            {
                if (resultHour < 1 && resultMin <= 30)
                {
                    Console.WriteLine(onTime);
                    Console.WriteLine($"{resultMin} minutes before the start");
                }
                else if (resultHour < 1 && resultMin > 30 && resultMin < 60)
                {
                    Console.WriteLine(early);
                    Console.WriteLine($"{resultMin} minutes before the start");
                }
                else if (resultHour >= 1 && resultMin < 10)
                {
                    Console.WriteLine(early);
                    Console.WriteLine($"{resultHour}:0{resultMin} hours before the start");
                }
                else if (resultHour >= 1)
                {
                    Console.WriteLine(early);
                    Console.WriteLine($"{resultHour}:{resultMin} hours before the start");
                }
            }

        }
    }
}
