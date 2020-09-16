using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            int sumBooks = int.Parse(Console.ReadLine());
            string bookTitle = "";
            int bookCheck = 0;
            while (bookCheck < sumBooks)
            {
                bookTitle = Console.ReadLine();
                if (bookTitle == favoriteBook)
                {
                    Console.WriteLine($"You checked {bookCheck} books and found it."); return;
                }
                else if (bookTitle != favoriteBook)
                {
                    bookCheck++;
                }
            }
            Console.WriteLine($"The book you search is not here!");
            Console.WriteLine($"You checked {bookCheck} books."); return;
        }
    }
}
