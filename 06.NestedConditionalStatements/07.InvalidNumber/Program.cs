using System;

namespace _07.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number > 200)
            {
                Console.WriteLine("invalid");
            }
            else if (number == 0)
            {
                Console.Write("");
            }
            else if (number < 100)
            {
                Console.WriteLine("invalid");
            }            
        }
    }
}
