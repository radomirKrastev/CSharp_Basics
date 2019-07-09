using System;

namespace LowestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int lowestNumber = int.MaxValue;


            for (int inputedNumbers = 0; inputedNumbers < countOfNumbers; inputedNumbers++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < lowestNumber)
                {
                    lowestNumber = number;
                }
            }

            Console.WriteLine(lowestNumber);
        }
    }
}
