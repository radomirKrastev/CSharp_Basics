using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            int peopleForMusala = 0;
            int peopleForMonblanc = 0;
            int peopleForKilimanjaro = 0;
            int peopleForK2 = 0;
            int peopleForEverest = 0;

            int countOfAll = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {

                int peoplePerGroup = int.Parse(Console.ReadLine());
                countOfAll += peoplePerGroup;
                if (peoplePerGroup <= 5)
                {
                    peopleForMusala += peoplePerGroup;
                }
                else if (peoplePerGroup > 5 && peoplePerGroup <= 12)
                {
                    peopleForMonblanc += peoplePerGroup;
                }
                else if (peoplePerGroup > 12 && peoplePerGroup <= 25)
                {
                    peopleForKilimanjaro += peoplePerGroup;
                }
                else if (peoplePerGroup > 25 && peoplePerGroup <= 40)
                {
                    peopleForK2 += peoplePerGroup;
                }
                else
                {
                    peopleForEverest += peoplePerGroup;
                }
            }

            double percentageForMusala = (peopleForMusala*1.0/countOfAll)*100; 
            double percentageForMonblanc = (peopleForMonblanc * 1.0 / countOfAll) * 100;
            double percentageForKilimanjaro = (peopleForKilimanjaro * 1.0 / countOfAll) * 100;
            double percentageForK2 = (peopleForK2 * 1.0 / countOfAll) * 100;
            double percentageForEverest = (peopleForEverest * 1.0 / countOfAll) * 100;

            Console.WriteLine($"{percentageForMusala:F2}%");
            Console.WriteLine($"{percentageForMonblanc:F2}%");
            Console.WriteLine($"{percentageForKilimanjaro:F2}%");
            Console.WriteLine($"{percentageForK2:F2}%");
            Console.WriteLine($"{percentageForEverest:F2}%");


        }
    }
}
