using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int inputedNumbers =0; inputedNumbers<countOfNumbers; inputedNumbers++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                
            }
            Console.WriteLine(sum);
        }
    }
}
