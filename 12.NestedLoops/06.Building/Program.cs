using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int Totalfloors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for ( int floor = Totalfloors; floor > 0; floor--)
            {
                if (floor == Totalfloors)
                {
                    for (int lastFloorRooms = 0; lastFloorRooms < rooms; lastFloorRooms++)
                    {
                        Console.Write($"L{floor}{lastFloorRooms} ");
                    }
                    Console.WriteLine();
                }
                else if (floor % 2 == 0)
                {
                    for (int nextFloorRooms = 0; nextFloorRooms < rooms; nextFloorRooms++)
                    {
                        Console.Write($"O{floor}{nextFloorRooms} ");
                    }
                    Console.WriteLine();
                }
                else if (floor % 2 == 1)
                {
                    for (int nextFloorRooms = 0; nextFloorRooms < rooms; nextFloorRooms++)
                    {
                        Console.Write($"A{floor}{nextFloorRooms} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
