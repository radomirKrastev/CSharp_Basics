using System;

namespace MovingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heigthFreeSpace = int.Parse(Console.ReadLine());

            int spaceTaken = 0;
            int totalSpace = widthFreeSpace * heigthFreeSpace * lengthFreeSpace;
            int totalFreeSpace = widthFreeSpace * heigthFreeSpace * lengthFreeSpace;

            while (totalFreeSpace > 0)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    int difference = totalSpace - spaceTaken;
                    Console.WriteLine($"{difference} Cubic meters left.");
                    break;
                }


                int countOfBoxes = int.Parse(command);

                totalFreeSpace -= countOfBoxes;
                spaceTaken += countOfBoxes;

                                             
            }

            if(totalFreeSpace<=0)
            {
                int difference = spaceTaken - totalSpace;
                Console.WriteLine($"No more free space! You need {Math.Abs(difference)} Cubic meters more.");
            }

        }
    }
}
