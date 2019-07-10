using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (typeOfFlowers)
            {
                case "Roses":
                    price = 5;
                    break;

                case "Dahlias":
                    price = 3.8;
                    break;

                case "Tulips":
                    price = 2.8;
                    break;

                case "Narcissus":
                    price = 3;
                    break;

                case "Gladiolus":
                    price = 2.5;
                    break;
            }

            double priceOfFlowers = price * countOfFlowers;

            if(countOfFlowers > 80 && typeOfFlowers == "Roses")
            {
                priceOfFlowers *= 0.9;
            }
            else if(countOfFlowers>90 && typeOfFlowers == "Dahlias")
            {
                priceOfFlowers *= 0.85;
            }
            else if(countOfFlowers>80 && typeOfFlowers == "Tulips")
            {
                priceOfFlowers *= 0.85;
            }
            else if(countOfFlowers<120&& typeOfFlowers == "Narcissus")
            {
                priceOfFlowers *= 1.15;
            }
            else if(countOfFlowers<80&& typeOfFlowers == "Gladiolus")
            {
                priceOfFlowers *= 1.20;
            }

            if (budget >= priceOfFlowers)
            {
                double moneyLeft = budget - priceOfFlowers;
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {moneyLeft:F2} leva left.");
            }
            else if (budget < priceOfFlowers)
            {
                double neededMoney = priceOfFlowers - budget;
                Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
            }
            
        }
    }
}
