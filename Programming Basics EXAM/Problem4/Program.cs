using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer = Console.ReadLine();

            string command = Console.ReadLine();

            int pointsLeft = 301;
            int countOfUnsuccessfulShots = 0;
            int countOfSuccessfulShots = 0;
            while (command != "Retire")
            {
                int pointsScored = int.Parse(Console.ReadLine());

                if(command == "Single" && pointsScored<=pointsLeft)
                {
                    countOfSuccessfulShots++;
                    pointsLeft -= pointsScored;
                }
                else if (command == "Double" && pointsScored*2 <= pointsLeft)
                {
                    countOfSuccessfulShots++;
                    pointsLeft -= pointsScored * 2;
                }
                else if (command == "Triple" && pointsScored*3 <= pointsLeft)
                {
                    countOfSuccessfulShots++;
                    pointsLeft -= pointsScored * 3;
                }
                else
                {
                    countOfUnsuccessfulShots++;
                }

                if(pointsLeft == 0)
                {
                    Console.WriteLine($"{nameOfPlayer} won the leg with {countOfSuccessfulShots} shots.");
                    break;
                }

                command = Console.ReadLine();

            }

            if (command == "Retire")
            {
                Console.WriteLine($"{nameOfPlayer} retired after {countOfUnsuccessfulShots} unsuccessful shots.");
            }

        }
    }
}
