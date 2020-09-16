using System;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != password)
            {
                password = Console.ReadLine(); break;
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}
