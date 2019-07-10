using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //int width = int.Parse(Console.ReadLine());
            //int length = int.Parse(Console.ReadLine());

            //int totalPieces = 0;
            //int wholeCake = width * length;
            //int leftFromTheCake = width * length;

            //while (leftFromTheCake > 0)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "STOP")
            //    {
            //        if (leftFromTheCake > 0)
            //        {
            //            int difference = wholeCake - totalPieces;
            //            Console.WriteLine($"{difference} pieces are left.");
            //            break;
            //        }

            //    }

            //    int piecesOfCake = int.Parse(command);
            //    totalPieces += piecesOfCake;
            //    leftFromTheCake -= piecesOfCake;

            //}

            //if (leftFromTheCake <= 0)
            //{
            //    int difference = Math.Abs(wholeCake - totalPieces);
            //    Console.WriteLine($"No more cake left! You need {difference} pieces more.");

            //}


            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int leftFromTheCake = width * length;
            string command = "";

            while ((command = Console.ReadLine()) != "STOP")
            {
                int piecesTaken = int.Parse(Console.ReadLine());
                leftFromTheCake -= piecesTaken;
                
               
                if (leftFromTheCake <= 0)
                {

                    Console.WriteLine($"No more cake left! You need {Math.Abs(leftFromTheCake)} pieces more.");

                }

                if (command == "STOP")
                {

                    Console.WriteLine($"{Math.Abs(leftFromTheCake)} pieces are left.");
                }
            }


        }
    }
}
