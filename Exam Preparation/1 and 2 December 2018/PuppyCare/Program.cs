using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodBoughtInKilos = int.Parse(Console.ReadLine());
            int totalFoodEaten = 0;
            string command = Console.ReadLine();

            while (command != "Adopted")
            {
                int foodEatenGrams = int.Parse(command);
                totalFoodEaten += foodEatenGrams;

                command = Console.ReadLine();

            }

            if(totalFoodEaten <= foodBoughtInKilos * 1000)
            {
                int leftovers = foodBoughtInKilos * 1000 - totalFoodEaten;
                Console.WriteLine($"Food is enough! Leftovers: {leftovers} grams.");
            }
            else
            {
                int moreFoodNeeded = totalFoodEaten - foodBoughtInKilos * 1000;
                Console.WriteLine($"Food is not enough. You need {moreFoodNeeded} grams more.");
            }

        }
    }
}
