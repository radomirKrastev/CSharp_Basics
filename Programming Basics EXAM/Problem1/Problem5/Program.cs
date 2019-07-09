using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfVisitors = int.Parse(Console.ReadLine());

            int visitorsForBackTraining = 0;
            int visitorsForChestTraining = 0;
            int visitorsForLegsTraining = 0;
            int visitorsForAbsTraining = 0;
            int visitorsForProteinShake = 0;
            int visitorsForProteinBar = 0;
            

            for(int i = 0; i<countOfVisitors; i++)
            {
                string reasonForVisiting = Console.ReadLine();

                if (reasonForVisiting == "Back")
                {
                    visitorsForBackTraining++;
                }
                else if (reasonForVisiting == "Chest")
                {
                    visitorsForChestTraining++;
                }
                else if (reasonForVisiting == "Legs")
                {
                    visitorsForLegsTraining++;
                }
                else if (reasonForVisiting == "Abs")
                {
                    visitorsForAbsTraining++;
                }
                else if (reasonForVisiting == "Protein shake")
                {
                    visitorsForProteinShake++;
                }
                else if (reasonForVisiting == "Protein bar")
                {
                    visitorsForProteinBar++;
                }
            }

            double percentageForTraining = (((visitorsForAbsTraining+visitorsForBackTraining+visitorsForChestTraining
                +visitorsForLegsTraining)*1.0)/countOfVisitors)*100;
            double percentageForProtein = (((visitorsForProteinShake + visitorsForProteinBar) * 1.0) / countOfVisitors) * 100;

            Console.WriteLine($"{visitorsForBackTraining} - back");
            Console.WriteLine($"{visitorsForChestTraining} - chest");
            Console.WriteLine($"{visitorsForLegsTraining} - legs");
            Console.WriteLine($"{visitorsForAbsTraining} - abs");
            Console.WriteLine($"{visitorsForProteinShake} - protein shake");
            Console.WriteLine($"{visitorsForProteinBar} - protein bar");
            Console.WriteLine($"{percentageForTraining:F2}% - work out");
            Console.WriteLine($"{percentageForProtein:F2}% - protein");
        }
    }
}
