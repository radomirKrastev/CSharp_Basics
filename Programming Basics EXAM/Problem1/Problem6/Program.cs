using System;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int countOfWins = 0;
            int countOfLosses = 0;
            int allGamesCount = 0;

            while (command != "End of tournaments")
            {
                int numberOfGames = int.Parse(Console.ReadLine());

                for (int i = 1; i<=numberOfGames; i++)
                {
                    int pointsForDesiTeam = int.Parse(Console.ReadLine());
                    int pointsForOppositionsTeam = int.Parse(Console.ReadLine());

                    if (pointsForDesiTeam > pointsForOppositionsTeam)
                    {
                        int result = pointsForDesiTeam - pointsForOppositionsTeam;
                        Console.WriteLine($"Game {i} of tournament {command}: win with {result} points.");
                        countOfWins++;
                    }

                    else
                    {
                        int result = pointsForOppositionsTeam - pointsForDesiTeam;
                        Console.WriteLine($"Game {i} of tournament {command}: lost with {result} points.");
                        countOfLosses++;
                    }

                    allGamesCount++;
                    
                }

                command = Console.ReadLine();
                


            }

            double percentageWins = (countOfWins * 1.0 / allGamesCount) * 100;
            double percentageLosses = (countOfLosses * 1.0 / allGamesCount) * 100;

            Console.WriteLine($"{percentageWins:F2}% matches win");
            Console.WriteLine($"{percentageLosses:F2}% matches lost");


        }
    }
}
