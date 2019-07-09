using System;

namespace TrekkingEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAlpinists = int.Parse(Console.ReadLine());
            int numberOfCarabineers = int.Parse(Console.ReadLine());
            int numberOfRopes = int.Parse(Console.ReadLine());
            int numberOfPiquels = int.Parse(Console.ReadLine());

            double priceOfCarabineer = 36;
            double priceOfRope = 3.6;
            double priceOfPiquel = 19.8;

            double netSum = (priceOfCarabineer * numberOfCarabineers * 1.0 + priceOfRope * numberOfRopes * 1.0
                + priceOfPiquel * numberOfPiquels * 1.0) * numberOfAlpinists;
            double grossSum = 0.2 * netSum + netSum;

            Console.WriteLine($"{grossSum:F2}");




        }
    }
}
