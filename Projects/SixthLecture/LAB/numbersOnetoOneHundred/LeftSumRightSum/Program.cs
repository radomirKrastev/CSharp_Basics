using System;

namespace LeftSumRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            int sumLeft = 0;
            int sumRight = 0;

            for (int countOfNumbers = 0; countOfNumbers < n; countOfNumbers++)
            {
                int leftNumber = int.Parse(Console.ReadLine());
                sumLeft += leftNumber;
            }

            for (int countOfNumbers = 0; countOfNumbers < n; countOfNumbers++)
            {
                int rightNumber = int.Parse(Console.ReadLine());
                sumRight += rightNumber;
            }

            if (sumLeft - sumRight == 0)
            {
                Console.WriteLine($"Yes, sum = {sumLeft}");
            }
            else
            {
                int difference = sumRight - sumLeft;
                difference = Math.Abs(difference);
                Console.WriteLine("No, diff = "+difference);
            }

        }
    }
}
