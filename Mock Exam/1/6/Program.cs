using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double souvenirsMoney = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());

            double fuelMoney = (420*1.0 / 100 * 7)*1.85;
            
            double souvenirsSpending = 3 * souvenirsMoney;
            double foodSpending = 3 * foodMoney;

            double firstNight = hotelMoney * 0.9;
            double secondNight = hotelMoney * 0.85;
            double thirdNight = hotelMoney * 0.8;

            double totalCosts = firstNight + secondNight + thirdNight + fuelMoney + souvenirsSpending + foodSpending;

            Console.WriteLine($"Money needed: {totalCosts:F2}");
        }
    }
}
