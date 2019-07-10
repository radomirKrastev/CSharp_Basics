using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string resultFirstMatch = Console.ReadLine();
            //string resultSecondMatch = Console.ReadLine();
            //string resultThirdMatch = Console.ReadLine();

            //char Match1HostsGoals = resultFirstMatch[0];
            //char Match1GuestsGoals = resultFirstMatch[2];

            //int HGoals1 = 
            //if(int H = Match1HostsGoals)

            //int Match1HostsScoredGoals = int.Parse(Match1GuestsGoals.ToString());

            int gamesWon = 0;
            int gamesLost = 0;
            int gamesDrawn = 0;
            

            for (int i = 0; i<3; i++)
            {
                string result = Console.ReadLine();

                char HGoals = result[0];
                char AGoals = result[2];

                int HomeTeamGoals = int.Parse(HGoals.ToString());
                int AwayTeamGoals = int.Parse(AGoals.ToString());

                if (HomeTeamGoals > AwayTeamGoals)
                {
                    gamesWon++;
                }
                else if (HomeTeamGoals < AwayTeamGoals)
                {
                    gamesLost++;
                }
                else
                {
                    gamesDrawn++;
                }
            }

            Console.WriteLine($"Team won {gamesWon} games.");
            Console.WriteLine($"Team lost {gamesLost} games.");
            Console.WriteLine($"Drawn games: {gamesDrawn}");

        }
    }
}
