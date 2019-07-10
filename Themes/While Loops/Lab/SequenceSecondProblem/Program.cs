using System;

namespace SequenceSecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowestNumber = int.MaxValue;
            int greatestNumber = int.MinValue;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                int number = int.Parse(command);

                if (number < lowestNumber)
                {
                    lowestNumber=number;
                }
                if (number > greatestNumber)
                {
                    greatestNumber = number;
                }

            }

            Console.WriteLine($"Max number: {greatestNumber}");
            Console.WriteLine($"Min number: {lowestNumber}");

        }
        
    }
}
