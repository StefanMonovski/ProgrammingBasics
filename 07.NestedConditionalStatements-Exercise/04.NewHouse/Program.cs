using System;

namespace _04.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (flowers == "Roses")
            {
                if (quantity > 80)
                {
                    price = (quantity * 5) * 0.90;
                }
                else
                {
                    price = quantity * 5;
                }

            }

            else if (flowers == "Dahlias")
            {
                if (quantity > 90)
                {
                    price = (quantity * 3.80) * 0.85;
                }
                else
                {
                    price = quantity * 3.80;
                }

            }

            else if (flowers == "Tulips")
            {
                if (quantity > 80)
                {
                    price = (quantity * 2.80) * 0.85;
                }
                else
                {
                    price = quantity * 2.80;
                }
            }

            else if (flowers == "Narcissus")
            {
                if (quantity < 120)
                {
                    price = (quantity * 3) * 1.15;
                }
                else
                {
                    price = quantity * 3;
                }
            }

            else if (flowers == "Gladiolus")
            {
                if (quantity < 80)
                {
                    price = (quantity * 2.50) * 1.20;
                }
                else
                {
                    price = quantity * 2.50;
                }
            }

            if (price <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {(budget - price):F2} leva left.");
            }
            else if (price > budget)
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):F2} leva more.");
            }
        }
    }
}
