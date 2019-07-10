using System;

namespace VolleyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int countOfHometownTravels = int.Parse(Console.ReadLine());

            //double playableSaturdays = ((48.0 - (countOfHometownTravels * 1.0))*(3/4))/2.0;
            //double playableHolidays = numberOfHolidays * (2 / 3);
            //double timesPlayed = 0;

            double playableSaturdays = (48-countOfHometownTravels)*(3*1.0/4);
            double playableHolidays = numberOfHolidays * (2*1.0 / 3);
            double timesPlayed = 0;

            if (typeOfYear == "leap")
            {
                timesPlayed = (playableHolidays + playableSaturdays + countOfHometownTravels) * 0.15 +
                    (playableHolidays + playableSaturdays + countOfHometownTravels);
                Console.WriteLine(Math.Floor(timesPlayed));
            }
            else
            {
                timesPlayed = (playableHolidays + playableSaturdays + countOfHometownTravels);
                Console.WriteLine(Math.Floor(timesPlayed));
            }

        }
    }
}
