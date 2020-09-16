using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            string entryUnit = Console.ReadLine().ToLower();
            string exitUnit = Console.ReadLine().ToLower();
          

            if (entryUnit == "m")
            {
                if (exitUnit == "cm")
                {
                    double result = length * 100;
                    Console.WriteLine($"{result:F3}");
                }
                else if (exitUnit == "mm")
                {
                    double result = length * 1000;
                    Console.WriteLine($"{result:F3}");
                }
            }

            if (entryUnit == "cm")
            {
                if (exitUnit == "m")
                {
                    double result = length / 100;
                    Console.WriteLine($"{result:F3}");
                }
                else if (exitUnit == "mm")
                {
                    double result = length * 10;
                    Console.WriteLine($"{result:F3}");
                }
            }
            
            if (entryUnit == "mm")
            {
                if (exitUnit == "cm")
                {
                    double result = length / 10;
                    Console.WriteLine($"{result:F3}");
                }
                else if (exitUnit == "m")
                {
                    double result = length / 1000;
                    Console.WriteLine($"{result:F3}");
                }
                    
            }
        }
    }
}
