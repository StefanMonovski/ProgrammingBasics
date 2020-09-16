using System;

namespace _09.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (sales >= 0 && sales <= 500)
            {
                switch (town)
                {
                    case "Sofia": Console.WriteLine($"{(sales * 0.05):F2}"); break;
                    case "Varna": Console.WriteLine($"{(sales * 0.045):F2}"); break;
                    case "Plovdiv": Console.WriteLine($"{(sales * 0.055):F2}"); break;
                    default: Console.WriteLine("error"); break;
                }

            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (town)
                {
                    case "Sofia": Console.WriteLine($"{(sales * 0.07):F2}"); break;
                    case "Varna": Console.WriteLine($"{(sales * 0.075):F2}"); break;
                    case "Plovdiv": Console.WriteLine($"{(sales * 0.08):F2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (town)
                {
                    case "Sofia": Console.WriteLine($"{(sales * 0.08):F2}"); break;
                    case "Varna": Console.WriteLine($"{(sales * 0.10):F2}"); break;
                    case "Plovdiv": Console.WriteLine($"{(sales * 0.12):F2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else if (sales > 10000)
            {
                switch (town)
                {
                    case "Sofia": Console.WriteLine($"{(sales * 0.12):F2}"); break;
                    case "Varna": Console.WriteLine($"{(sales * 0.13):F2}"); break;
                    case "Plovdiv": Console.WriteLine($"{(sales * 0.145):F2}"); break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
