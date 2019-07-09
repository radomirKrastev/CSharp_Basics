using System;

namespace ChristmasSweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaklavaPerKg = double.Parse(Console.ReadLine());
            double priceMuffinsPerKg = double.Parse(Console.ReadLine());
            double KgsOfBowl = double.Parse(Console.ReadLine());
            double KgsOfCandies = double.Parse(Console.ReadLine());
            double KgsOfCookies = double.Parse(Console.ReadLine());

            double priceBowlPerKg = priceBaklavaPerKg * 1.6;
            double priceCandiesPerKg = priceMuffinsPerKg * 1.8;
            double priceCookies = 7.5;

            double neededMoney = KgsOfBowl * priceBowlPerKg + KgsOfCandies * priceCandiesPerKg 
                + KgsOfCookies * priceCookies;

            Console.WriteLine($"{neededMoney:F2}");
        }
    }
}
