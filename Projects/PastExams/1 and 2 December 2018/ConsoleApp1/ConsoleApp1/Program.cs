using System;

namespace SchoolSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int penPacks = int.Parse(Console.ReadLine());
            int markersPacks = int.Parse(Console.ReadLine());
            double litersCleaningSpray = double.Parse(Console.ReadLine());
            int percentageDiscount = int.Parse(Console.ReadLine());

            double grossSum = penPacks * 5.8 + markersPacks * 7.2 + litersCleaningSpray * 1.2;
            double discount = (grossSum * percentageDiscount*1.0)/100;
            double netSum = grossSum - discount;
            Console.WriteLine($"{netSum:F3}");
        }
    }
}
