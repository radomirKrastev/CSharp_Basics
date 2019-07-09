using System;

namespace StadiumIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSectors = int.Parse(Console.ReadLine());
            int capacityStadium = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double incomePerSector = (capacityStadium * price) / numberSectors * 1.0;
            
            double totalIncome = incomePerSector * numberSectors;
            double charity = (totalIncome - 0.75 * incomePerSector) * 0.125;

            Console.WriteLine($"Total income - {totalIncome:F2} BGN");
            Console.WriteLine($"Money for charity - {charity:F2} BGN");

        }
    }
}
