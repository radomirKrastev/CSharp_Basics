using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalSumOfPairs = 0;
            int previousSum = 0;
            
            int maxDifference = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                
                if (i > 0)
                {

                    int diff = Math.Abs((number2 + number1) - previousSum);

                    if (diff > maxDifference)
                    {
                        maxDifference = diff;
                    }
                }

                previousSum = number1+number2;
                totalSumOfPairs += number1 + number2;

            }
            int result = totalSumOfPairs / n;
            bool arePairsEqual = totalSumOfPairs == result * n; 
            if (arePairsEqual&&totalSumOfPairs!=0)
            {
                Console.WriteLine($"Yes, value={result}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
            //for (int i = 0; i < n; i++)
            //{
            //    int number2 = int.Parse(Console.ReadLine());
            //    totalsum2 += number2;
            //}





        }
    }
}
