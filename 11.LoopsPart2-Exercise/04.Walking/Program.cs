using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;
            int totalSteps = 0;
            int steps = 0;
            string stepsOrHome = "";
            while (totalSteps < stepsGoal)
            {
                stepsOrHome = Console.ReadLine();              
                if (stepsOrHome == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());
                    totalSteps += steps;
                    break;
                }

                steps = int.Parse(stepsOrHome);
                totalSteps += steps;
            }
            if (totalSteps >= stepsGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else if (totalSteps < stepsGoal)
            {
                Console.WriteLine($"{stepsGoal - totalSteps} more steps to reach goal.");
            }
        }
    }
}
