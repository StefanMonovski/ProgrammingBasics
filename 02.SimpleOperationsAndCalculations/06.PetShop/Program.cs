using System;

namespace _06.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int animalFood = int.Parse(Console.ReadLine());
            double totalPrice = (dogFood * 2.50) + (animalFood * 4);
            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
