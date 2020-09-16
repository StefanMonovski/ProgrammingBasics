using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int allowedPoorGrades = int.Parse(Console.ReadLine());
            int poorGrades = 0;
            double sumGrades = 0;
            string lastProblemName = "";
            double numProblems = 0;

            string problemName = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());

            while (problemName != "Enough")
            {               
                if (grade <= 4)
                {
                    poorGrades++;
                    sumGrades += grade;
                    numProblems++;
                    lastProblemName = problemName;
                }
                if (grade > 4)
                {
                    sumGrades += grade;
                    numProblems++;
                    lastProblemName = problemName;
                }
                if (poorGrades == allowedPoorGrades)
                {
                    Console.WriteLine($"You need a break, {poorGrades} poor grades."); return;
                }

                problemName = Console.ReadLine();
                
                if (problemName == "Enough")
                {
                    double averageScore = (sumGrades / numProblems);
                    Console.WriteLine($"Average score: {(averageScore):F2}");
                    Console.WriteLine($"Number of problems: {numProblems}");
                    Console.WriteLine($"Last problem: {lastProblemName}"); return;
                }

                grade = int.Parse(Console.ReadLine());

            }
            
        }
    }
}
