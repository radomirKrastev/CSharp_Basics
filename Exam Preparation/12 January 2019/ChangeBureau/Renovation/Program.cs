using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lengthFloor = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());
            double pricePerTile = double.Parse(Console.ReadLine());
            double builderPayCheck = double.Parse(Console.ReadLine());

            double areaOfFloor = widthFloor * lengthFloor;
            double areaOfTile = sideTriangle * heightTriangle / 2;

            double tilesNeeded = Math.Ceiling(areaOfFloor / areaOfTile) + 5;

            double totalCost = tilesNeeded * pricePerTile + builderPayCheck;

            if (budget >= totalCost)
            {
                double moneyLeft = budget - totalCost;
                Console.WriteLine($"{moneyLeft:F2} lv left.");
            }
            else
            {
                double neededMoney = totalCost - budget;
                Console.WriteLine($"You'll need {neededMoney:F2} lv more.");
            }


        }
    }
}
