using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakePieces = cakeLength * cakeWidth;
            int piecesTaken = 0;
            string pieces = "";

            while (piecesTaken < cakePieces)
            {
                pieces = Console.ReadLine();
                if (pieces == "STOP")
                {
                    break;
                }
                piecesTaken += int.Parse(pieces);
            }
            if (piecesTaken < cakePieces)
            {
                Console.WriteLine($"{cakePieces - piecesTaken} pieces are left.");
            }
            else if (piecesTaken > cakePieces)
            {
                Console.WriteLine($"No more cake left! You need {piecesTaken - cakePieces} pieces more.");
            }
        }
    }
}
