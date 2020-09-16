using System;

namespace _09.Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int schoolClass = 0;
            double grade = 0.0;
            double totalGrades = 0.0;
            while (schoolClass < 12)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    schoolClass++;
                    totalGrades += grade;
                }
                else
                {
                    Console.WriteLine($"{studentName} has been excluded at {schoolClass + 1} grade"); return;
                }

            }
            double averageGrade = totalGrades / schoolClass;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
