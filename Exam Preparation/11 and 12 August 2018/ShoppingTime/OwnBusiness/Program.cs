using System;

namespace OwnBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());

            int roomLeft = 0;
            int spaceOccupied = 0;

            string command = Console.ReadLine();

            while(command != "Done")
            {
                int computers = int.Parse(command);
                int space = width * length * heigth;
                spaceOccupied += computers;

                if (spaceOccupied <= space)
                {
                    roomLeft = space - spaceOccupied;
                }
                else
                {
                    int neededSpace = spaceOccupied - space;
                    Console.WriteLine($"No more free space! You need {neededSpace} Cubic meters more.");

                    break;
                }

                command = Console.ReadLine();
            }

            if(command == "Done")
            Console.WriteLine($"{roomLeft} Cubic meters left.");

        }
    }
}
