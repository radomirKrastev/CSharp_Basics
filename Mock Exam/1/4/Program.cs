using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfSushi = Console.ReadLine();
            string nameOfRestaurant = Console.ReadLine();
            int countOfServes = int.Parse(Console.ReadLine());
            string forHome = Console.ReadLine();

            double priceSushi = 0;

            if(kindOfSushi == "sashimi")
            {
                switch (nameOfRestaurant)
                {
                    case "Sushi Zone":
                        priceSushi = 4.99;
                        break;
                    case "Sushi Time":
                        priceSushi = 5.49;
                        break;
                    case "Sushi Bar":
                        priceSushi = 5.25;
                        break;
                    case "Asian Pub":
                        priceSushi = 4.50;
                        break;
                    default:
                        Console.WriteLine($"{nameOfRestaurant} is invalid restaurant!");
                        break;

                }
            }

            else if (kindOfSushi == "maki")
            {
                switch (nameOfRestaurant)
                {
                    case "Sushi Zone":
                        priceSushi = 5.29;
                        break;
                    case "Sushi Time":
                        priceSushi = 4.69;
                        break;
                    case "Sushi Bar":
                        priceSushi = 5.55;
                        break;
                    case "Asian Pub":
                        priceSushi = 4.80;
                        break;
                    default:
                        Console.WriteLine($"{nameOfRestaurant} is invalid restaurant!");
                        break;

                }
            }

            else if (kindOfSushi == "uramaki")
            {
                switch (nameOfRestaurant)
                {
                    case "Sushi Zone":
                        priceSushi = 5.99;
                        break;
                    case "Sushi Time":
                        priceSushi = 4.49;
                        break;
                    case "Sushi Bar":
                        priceSushi = 6.25;
                        break;
                    case "Asian Pub":
                        priceSushi = 5.50;
                        break;
                    default:
                        Console.WriteLine($"{nameOfRestaurant} is invalid restaurant!");
                        break;

                }
            }

            else if (kindOfSushi == "temaki")
            {
                switch (nameOfRestaurant)
                {
                    case "Sushi Zone":
                        priceSushi = 4.29;
                        break;
                    case "Sushi Time":
                        priceSushi = 5.19;
                        break;
                    case "Sushi Bar":
                        priceSushi = 4.75;
                        break;
                    case "Asian Pub":
                        priceSushi = 5.50;
                        break;
                    default:
                        Console.WriteLine($"{nameOfRestaurant} is invalid restaurant!");
                        break;

                }
            }

            double totalCost = priceSushi * countOfServes;
            bool isNameCorrect = nameOfRestaurant == "Sushi Zone" || nameOfRestaurant == "Sushi Time" ||
                nameOfRestaurant == "Sushi Bar" || nameOfRestaurant == "Asian Pub";

            if(forHome == "Y"&&isNameCorrect)
            {
                totalCost = totalCost * 0.2 + totalCost;
                Console.WriteLine($"Total price: {Math.Ceiling(totalCost)} lv.");
            }
            else if (forHome == "N" && isNameCorrect)
            {
                Console.WriteLine($"Total price: {Math.Ceiling(totalCost)} lv.");
            }
        }
    }
}
