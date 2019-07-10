using System;

namespace EvenOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;

            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;



            for (int count = 1; count<=totalNumbers; count++)
            {
                double number = double.Parse(Console.ReadLine());

                if (count % 2 != 0)
                {
                    oddSum += number;

                    if(number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }

                else
                {
                    evenSum += number;

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:F2},");

            if (oddMin == int.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
            }

            if(oddMax == int.MinValue)
            {
                {
                    Console.WriteLine("OddMax=No,");
                }
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }

            Console.WriteLine($"EvenSum={evenSum:F2},");

            if (evenMin == int.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }

            if (evenMax == int.MinValue)
            {
                {
                    Console.WriteLine("EvenMax=No");
                }
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }





        }
    }
}
