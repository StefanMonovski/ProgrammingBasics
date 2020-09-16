using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeSeats;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            int totalTicketsOneMovie = 0;
            int totalTicketsAllMovies = 0;

            string movieName = Console.ReadLine();
            freeSeats = int.Parse(Console.ReadLine());
            while (movieName != "Finish")
            { 
                
                string typeTicket = Console.ReadLine();
                while (typeTicket != "End")
                {                    
                    if (typeTicket == "student")
                    {
                        studentTickets++;
                    }
                    else if (typeTicket == "standard")
                    {
                        standardTickets++;
                    }
                    else if (typeTicket == "kid")
                    {
                        kidTickets++;
                    }

                    totalTicketsOneMovie++;
                    totalTicketsAllMovies++;

                    if (totalTicketsOneMovie == freeSeats)
                    {
                        break;
                    }
                    typeTicket = Console.ReadLine();

                }

                Console.WriteLine($"{movieName} - {((totalTicketsOneMovie * 100.0) / freeSeats):F2}% full.");
                totalTicketsOneMovie = 0;
                movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }
                freeSeats = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Total tickets: {totalTicketsAllMovies}");
            Console.WriteLine($"{((studentTickets * 100.0) / totalTicketsAllMovies):F2}% student tickets.");
            Console.WriteLine($"{((standardTickets * 100.0) / totalTicketsAllMovies):F2}% standard tickets.");
            Console.WriteLine($"{((kidTickets * 100.0) / totalTicketsAllMovies):F2}% kids tickets.");
        }
    }
}
