using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minimumWage * 0.35);
            double scholarship = Math.Floor(averageSuccess * 25);

            if (averageSuccess <= 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (averageSuccess > 4.50 && averageSuccess < 5.50)
            {
                if(minimumWage <= income)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
            }

            else if (averageSuccess >= 5.50)
            {
                if (minimumWage <= income)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarship} BGN");
                }
                else if (minimumWage > income)
                {
                    if (socialScholarship > scholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                    }
                    else if (scholarship > socialScholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {scholarship} BGN");
                    }
                    else if (socialScholarship == scholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {scholarship} BGN");
                    }
                }
            }
        }
    }
}
