using System;

namespace GreatestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int greatestNumber = int.MinValue;
            

            for (int inputedNumbers =0; inputedNumbers<countOfNumbers; inputedNumbers++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > greatestNumber)
                {
                    greatestNumber = number;
                }
            }

            Console.WriteLine(greatestNumber);
        }
    }
}
