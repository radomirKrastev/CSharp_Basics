using System;

namespace SchoolTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDaysGone = int.Parse(Console.ReadLine());
            int foodLeftInKilos = int.Parse(Console.ReadLine());
            double firstDogFoodInKilos = double.Parse(Console.ReadLine());
            double secondDogFoodInKilos = double.Parse(Console.ReadLine());
            double thirdDogFoodInKilos = double.Parse(Console.ReadLine());

            double kilogramsOfFoodNeeded = (firstDogFoodInKilos + secondDogFoodInKilos + thirdDogFoodInKilos)*numberOfDaysGone;

            if (kilogramsOfFoodNeeded > foodLeftInKilos)
            {
                double moreFoodNeeded = kilogramsOfFoodNeeded - foodLeftInKilos;
                Console.WriteLine($"{Math.Ceiling(moreFoodNeeded)} more kilos of food are needed.");
            }
            else
            {
                double foodLeft = foodLeftInKilos - kilogramsOfFoodNeeded;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }

        }
    }
}
