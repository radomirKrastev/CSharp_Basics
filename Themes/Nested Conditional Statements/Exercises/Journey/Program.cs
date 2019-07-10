using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string wchichSeason = Console.ReadLine();

            // budget => destination 
            // season => %of budget

            string destination = "";
            string kindOfJourney = "";
            double moneyNeeded = 0;

            if (budget <= 100)
            {
                switch (wchichSeason)
                {
                    case "summer":
                        destination = "Bulgaria";
                        kindOfJourney = "Camp";
                        moneyNeeded = 0.3 * budget;
                        break;
                    case "winter":
                        destination = "Bulgaria";
                        kindOfJourney = "Hotel";
                        moneyNeeded = 0.7 * budget;
                        break;
                }
            }
            else if (budget <= 1000)
            {
                switch (wchichSeason)
                {
                    case "summer":
                        destination = "Balkans";
                        kindOfJourney = "Camp";
                        moneyNeeded = 0.4 * budget;
                        break;
                    case "winter":
                        destination = "Balkans";
                        kindOfJourney = "Hotel";
                        moneyNeeded = 0.8 * budget;
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                kindOfJourney = "Hotel";
                moneyNeeded = 0.9 * budget;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{kindOfJourney} - {moneyNeeded:F2}");
             
        }

    }
}
