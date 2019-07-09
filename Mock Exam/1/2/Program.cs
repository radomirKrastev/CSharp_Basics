using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPassengers = int.Parse(Console.ReadLine());
            int countOfStops = int.Parse(Console.ReadLine());

            for (int i =1; i<=countOfStops; i++)
            {
                
                int hopOffPassengers = int.Parse(Console.ReadLine());
                int hopOnPassengers = int.Parse(Console.ReadLine());

                countOfPassengers += hopOnPassengers - hopOffPassengers;

                if (i % 2 != 0)
                {
                    countOfPassengers += 2;
                }
                else
                {
                    countOfPassengers -= 2;
                }


            }

            Console.WriteLine($"The final number of passengers is : {countOfPassengers}");
        }
    }
}
