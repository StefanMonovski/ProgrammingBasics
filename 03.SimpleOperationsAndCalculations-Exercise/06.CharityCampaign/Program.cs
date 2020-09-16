using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int corrugations = int.Parse(Console.ReadLine());
            int pancackes = int.Parse(Console.ReadLine());

            double incomeCakes = (cakes * 45);
            double incomeCorrugations = (corrugations * 5.80);
            double incomePancackes = (pancackes * 3.20);

            double incomeOneDayAllBakers = (incomeCakes + incomeCorrugations + incomePancackes) * bakers;
            double incomeCampaign = (incomeOneDayAllBakers * days);
            double incomeAfterTaxes = (incomeCampaign - (incomeCampaign * 0.125));
            Console.WriteLine($"{incomeAfterTaxes:F2}");
        }
    }
}
