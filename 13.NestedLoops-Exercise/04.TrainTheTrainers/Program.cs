using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();          
            int totalNumGrades = 0;         
            double totalSumGrades = 0;           
            double totalAvarageGrades = 0;
            while (input != "Finish")
            {
                int numGrades = 0;
                double sumGrades = 0;
                double avarageGrades = 0;
                for (int i = 1; i <= judges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                    totalSumGrades += grade;
                    numGrades++;
                    totalNumGrades++;
                }
                avarageGrades = sumGrades / numGrades;
                Console.WriteLine($"{input:F2} - {avarageGrades:F2}.");
                input = Console.ReadLine();
            }
            totalAvarageGrades = totalSumGrades / totalNumGrades;
            Console.WriteLine($"Student's final assessment is {totalAvarageGrades:F2}.");
        }
    }
}
