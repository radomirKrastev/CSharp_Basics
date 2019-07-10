using System;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageOfLilly = int.Parse(Console.ReadLine());
            double priceOfWasher = double.Parse(Console.ReadLine());
            int priceOfOneToy = int.Parse(Console.ReadLine());
            int moneyForBirthday = 0;
            int sumOfBirthdaysMoney = 0;
            int countOfToys = 0;

            for(int birthdays =1; birthdays<=ageOfLilly; birthdays++)
            {
                if (birthdays % 2 == 0)
                {
                    moneyForBirthday = moneyForBirthday+10;
                    sumOfBirthdaysMoney += moneyForBirthday;
                    sumOfBirthdaysMoney--;
                }
                else
                {
                    countOfToys++;
                }

            }
            int totalSavedMoney = sumOfBirthdaysMoney + (countOfToys * priceOfOneToy);
            double difference = totalSavedMoney * 1.0 - priceOfWasher;

            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:F2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(difference):F2}");
            }

        }
    }
}
