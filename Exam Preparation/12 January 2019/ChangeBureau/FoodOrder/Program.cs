using System;

namespace FoodOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double sumOfCart = 2.5;
            int countofProducts = 0;
            while(budget >= sumOfCart)
            {
                string nameOfProduct = Console.ReadLine();
                

                if (nameOfProduct == "Order")
                {
                    Console.WriteLine($"You ordered {countofProducts} items!");
                    Console.WriteLine($"Total: {sumOfCart:F2}");
                    break;
                }

                double priceOfProduct = double.Parse(Console.ReadLine());
                sumOfCart += priceOfProduct;
                countofProducts++;

                if (sumOfCart > budget)
                {
                    Console.WriteLine("You will exceed the budget if you order this!");
                    sumOfCart -= priceOfProduct;
                    countofProducts--;
                }

            }

        }
    }
}
