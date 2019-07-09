using System;

namespace EvenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            
            

            for (int i =0; i<n; i++)
            {
                

                int number = int.Parse(Console.ReadLine());

                if(i%2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }

            bool areSumsEqual = sumOdd - sumEven == 0;

            if (areSumsEqual)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sumEven);
            }
            else
            {
                int difference = Math.Abs(sumEven - sumOdd);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + difference);
            }

        }
    }
}
