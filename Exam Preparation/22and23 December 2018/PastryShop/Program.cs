using System;

namespace PastryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProduct = Console.ReadLine();
            int countOfOrders = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());

            double price = 0;

            if (date <= 15)
            {
                switch (typeOfProduct)
                {
                    case "Cake":
                        price = countOfOrders * 24.0;
                        break;
                    case "Souffle":
                        price = countOfOrders * 6.66;
                        break;
                    case "Baklava":
                        price = countOfOrders * 12.6;
                        break;
                }

                if (price >= 100 && price <= 200)
                {
                    price *= 0.85*0.9;
                }
                else if (price > 200)
                {
                    price *= 0.75*0.9;
                }
                else
                {
                    price *= 0.9;
                }
            }
            
            else
            {
                switch (typeOfProduct)
                {
                    case "Cake":
                        price = countOfOrders * 28.7;
                        break;
                    case "Souffle":
                        price = countOfOrders * 9.8;
                        break;
                    case "Baklava":
                        price = countOfOrders * 16.98;
                        break;
                }

                if (date<=22 && (price >= 100 && price <= 200))
                {
                    price *= 0.85;
                }
                else if (date <= 22 && price > 200)
                {
                    price *= 0.75;
                }

            }


            Console.WriteLine($"{price:F2}");

        }
    }
}
