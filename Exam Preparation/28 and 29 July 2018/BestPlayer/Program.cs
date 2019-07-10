using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();
            int bestPlayerGoals = 0;
            string bestPlayerName = "";
            while (namePlayer != "END")
            {
                int numberOfGoals = int.Parse(Console.ReadLine());
                if (numberOfGoals > bestPlayerGoals)
                {
                    bestPlayerGoals = numberOfGoals;
                    bestPlayerName = namePlayer;
                }
                if (numberOfGoals >= 10)
                {
                    Console.WriteLine($"{namePlayer} is the best player!");
                    Console.WriteLine($"He has scored {numberOfGoals} goals and made a hat-trick !!!");
                    break;
                }
                

                namePlayer = Console.ReadLine();
            }


            if (namePlayer == "END" && bestPlayerGoals<3 )
            {
                Console.WriteLine($"{bestPlayerName} is the best player!");
                Console.WriteLine($"He has scored {bestPlayerGoals} goals.");
            }
            else if (namePlayer == "END" && bestPlayerGoals>=3)
            {
                Console.WriteLine($"{bestPlayerName} is the best player!");
                Console.WriteLine($"He has scored {bestPlayerGoals} goals and made a hat-trick !!!");
            }

            


        }
    }
}
