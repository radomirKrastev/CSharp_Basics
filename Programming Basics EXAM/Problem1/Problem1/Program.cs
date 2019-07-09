using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int basketballTrainingTax = int.Parse(Console.ReadLine());

            double priceOfSneakers = 0.6 * basketballTrainingTax;
            double priceOfBasketballKit = 0.8 * priceOfSneakers;
            double priceOfBasketBall = 0.25 * priceOfBasketballKit;
            double priceOfBasketballAccessories = 0.20 * priceOfBasketBall;

            double trainingCosts = priceOfSneakers + priceOfBasketballKit + priceOfBasketBall
                + priceOfBasketballAccessories + basketballTrainingTax;

            Console.WriteLine($"{trainingCosts:F2}");

        }
    }
}
