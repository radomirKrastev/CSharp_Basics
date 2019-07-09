using System;

namespace ShoppingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int lunchTime = int.Parse(Console.ReadLine());
            double peripheryPrice = double.Parse(Console.ReadLine());
            double programPrice = double.Parse(Console.ReadLine());
            double whiteFrappePrice = double.Parse(Console.ReadLine());

            int timeLeft = lunchTime - 15;

            double totalPricePaid = peripheryPrice *3+ programPrice *2+ whiteFrappePrice;

            Console.WriteLine($"{totalPricePaid:F2}");
            Console.WriteLine($"{timeLeft}");

            
        }
    }
}
