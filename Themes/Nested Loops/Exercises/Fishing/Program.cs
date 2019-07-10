using System;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine());

            double cost = 0;
            double profit = 0;
            int countOfFish = 0;


            string command = Console.ReadLine();


            while (countOfFish < quota)
            {
                
                    double fishKgs = double.Parse(Console.ReadLine());

                    int priceOfFish = 0;
                    for (int j = 0; j < command.Length; j++)
                    {
                        char fish = command[j];
                        priceOfFish += fish;
                    }

                    if ((countOfFish+1) % 3 == 0)
                    {
                        profit += priceOfFish / fishKgs;
                    }
                    else
                    {
                        cost += priceOfFish / fishKgs;
                    }

                    countOfFish++;
                if (countOfFish == quota)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }

                    command = Console.ReadLine();

                

                if (command == "Stop")
                {
                    break;
                }

                
            }
            


            double result = profit - cost;
            if (profit >= cost)
            {
                Console.WriteLine($"Lyubo's profit from {countOfFish} fishes is {result:F2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {Math.Abs(result):F2} leva today.");
            }


        }
    }
}
