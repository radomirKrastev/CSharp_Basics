using System;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int totalSteps = 0;
            int difference = 0;
            int goal = 10000;

            while (true)
            {
                
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    totalSteps += lastSteps;
                    if (totalSteps >= goal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    else
                    {
                        difference = goal - totalSteps;
                        Console.WriteLine($"{difference} more steps to reach goal.");
                        break;
                    }


                }
                
                int steps = int.Parse(input);
                totalSteps += steps;
                
                if (totalSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                
                
                    
                

            }


        }
    }
}
