﻿using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSites = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= numSites; i++)
            {
                string site = Console.ReadLine();
                if (site == "Facebook")
                {
                    salary -= 150;
                }
                if (site == "Instagram")
                {
                    salary -= 100;
                }
                if (site == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary."); break;
                }
            }

            if (salary != 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
