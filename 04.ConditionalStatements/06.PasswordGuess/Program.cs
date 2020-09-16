using System;

namespace _06.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
            string attempt = Console.ReadLine();
            if (password == attempt)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
