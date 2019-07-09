using System;

namespace BankOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            int countOfOperations = 0;
            double totalSum = 0;


            while (countOfOperations < numberOfOperations)
            {
               
                double eachSumAmount = double.Parse(Console.ReadLine());
                countOfOperations++;
                if (eachSumAmount >= 0)
                {
                    totalSum += eachSumAmount;
                    Console.WriteLine($"Increase: {eachSumAmount:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

            }
            Console.WriteLine("Total: "+totalSum);
        }
    }
}
