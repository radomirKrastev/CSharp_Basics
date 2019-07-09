using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countofFishermans = int.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;
            double totalPrice = 0;
            bool areFishermansEven = countofFishermans % 2 == 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (countofFishermans <= 6)
                    {
                        discount = 0.1 * price;
                    }
                    else if(countofFishermans == 7 || countofFishermans <= 11)
                    {
                        discount = 0.15 * price;
                    }
                    else
                    {
                        discount = 0.25 * price;
                    }
                    break;
                case "Summer":
                    price = 4200;
                    if (countofFishermans <= 6)
                    {
                        discount = 0.1 * price;
                    }
                    else if (countofFishermans == 7 || countofFishermans <= 11)
                    {
                        discount = 0.15 * price;
                    }
                    else
                    {
                        discount = 0.25 * price;
                    }
                    break;
                case "Autumn":
                    price = 4200;
                    if (countofFishermans <= 6)
                    {
                        discount = 0.1 * price;
                    }
                    else if (countofFishermans == 7 || countofFishermans <= 11)
                    {
                        discount = 0.15 * price;
                    }
                    else
                    {
                        discount = 0.25 * price;
                    }
                    break;
                case "Winter":
                    price = 2600;
                    if (countofFishermans <= 6)
                    {
                        discount = 0.1 * price;
                    }
                    else if (countofFishermans == 7 || countofFishermans <= 11)
                    {
                        discount = 0.15 * price;
                    }
                    else
                    {
                        discount = 0.25 * price;
                    }
                    break;

            }

            if ((season == "Spring" || season == "Summer" || season == "Winter") && areFishermansEven)
            {
                totalPrice = (price-discount) - (price-discount)*0.05;
            }
            else
            {
                totalPrice = price - discount;
            }

            if (totalPrice <= budget)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
            }

        }
    }
}
