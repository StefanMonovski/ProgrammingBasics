using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVacation = double.Parse(Console.ReadLine());
            double moneySave = double.Parse(Console.ReadLine());
            double moneyInUse = 0;
            int days = 0;
            int consecutiveSpend = 0;
            string spendOrSave = "";

            while (moneySave < priceVacation && consecutiveSpend < 5)
            {               
                spendOrSave = Console.ReadLine();
                moneyInUse = double.Parse(Console.ReadLine());
                if (spendOrSave == "spend")
                {
                    consecutiveSpend++;
                    moneySave -= moneyInUse;
                    if (moneySave < 0)
                    {
                        moneySave = 0;
                    }
                }
                else if (spendOrSave == "save")
                {
                    consecutiveSpend = 0;
                    moneySave += moneyInUse;
                }
                days++;
            }
            if (moneySave < priceVacation)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            if (moneySave >= priceVacation)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
