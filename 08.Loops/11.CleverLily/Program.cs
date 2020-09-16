using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            double moneyBirthday = 0.0;
            double totalMoneyBirthday = 0.0;
            double totalMoneyToys = 0.0;
            int totalToys = 0;

            for (int i = 2; i <= ageLily; i += 2)
            {
                moneyBirthday = moneyBirthday + 10;
                totalMoneyBirthday += moneyBirthday - 1;
            }
            for (int i = 1; i <= ageLily; i += 2)
            {
                totalToys++;
                totalMoneyToys = priceToy * totalToys;
            }

            double savedMoney = totalMoneyBirthday + totalMoneyToys;

            if (savedMoney >= priceWashingMachine)
            {
                Console.WriteLine($"Yes! {(savedMoney - priceWashingMachine):F2}");
            }
            else if (savedMoney < priceWashingMachine)
            {
                Console.WriteLine($"No! {(priceWashingMachine - savedMoney):F2}");
            }
        }
    }
}

