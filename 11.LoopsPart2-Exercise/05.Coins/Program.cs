using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double coinsTotal = double.Parse(Console.ReadLine()) * 100;
            coinsTotal = Math.Round(coinsTotal);
            int numCoins = 0;
            while (coinsTotal >= 1)
            {
                if (coinsTotal >= 200)
                {
                    coinsTotal -= 200;
                    numCoins++;
                }
                else if (coinsTotal >= 100)
                {
                    coinsTotal -= 100;
                    numCoins++;
                }
                else if (coinsTotal >= 50)
                {
                    coinsTotal -= 50;
                    numCoins++;
                }
                else if (coinsTotal >= 20)
                {
                    coinsTotal -= 20;
                    numCoins++;
                }
                else if (coinsTotal >= 10)
                {
                    coinsTotal -= 10;
                    numCoins++;
                }
                else if (coinsTotal >= 5)
                {
                    coinsTotal -= 5;
                    numCoins++;
                }
                else if (coinsTotal >= 2)
                {
                    coinsTotal -= 2;
                    numCoins++;
                }
                else if (coinsTotal >= 1)
                {
                    coinsTotal -= 1;
                    numCoins++;
                }
            }
            Console.WriteLine(numCoins);
        }
    }
}
