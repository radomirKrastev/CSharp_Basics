using System;

namespace WarOnNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int winnerSum = int.MinValue;
            string winnerName = "";
            
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                if (input == "STOP")
                {
                    break;
                }

                int sum = 0;

                for (int i = 0; i<input.Length; i++)
                {
                    int letter = input[i];
                    sum += letter;
                }

                if (sum > winnerSum)
                {
                    winnerName = input;
                    winnerSum = sum;
                }

                

                input = Console.ReadLine();
                
            }

            Console.WriteLine($"Winner is {winnerName} - {winnerSum}!");
        }
    }
}
