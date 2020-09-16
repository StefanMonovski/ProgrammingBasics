using System;

namespace _10.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double volume = width * length * heigth;
            double freeSpace = width * length * heigth;
            int sumBoxes = 0;
            int numBoxes = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {                
                numBoxes = int.Parse(input);
                if (numBoxes < freeSpace)
                {
                    freeSpace -= numBoxes;
                    sumBoxes += numBoxes;
                }
                else if (numBoxes >= freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {numBoxes - freeSpace} Cubic meters more."); return;
                }
                input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{volume - sumBoxes} Cubic meters left."); return;
                }
            }           
        }
    }
}
