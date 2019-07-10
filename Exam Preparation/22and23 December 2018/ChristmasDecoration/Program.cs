using System;

namespace ChristmasDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());

            int valueItem = 0;
            int costs = 0;

            while (budget > costs)
            {
                int moneyLeft = budget - costs;
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    Console.WriteLine($"Money left: {moneyLeft}");
                    break;
                }

                if (valueItem > 0)
                {
                    valueItem = 0;
                }

               for (int i = 0; i<command.Length; i++)
               {
                    char letter = command[i];
                    valueItem += letter;
                    
               }
 
                costs += valueItem;

                
                if (valueItem <= moneyLeft)
                {
                    Console.WriteLine("Item successfully purchased!");
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    break;
                }


            }


        }
    }
}
