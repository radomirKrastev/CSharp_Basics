using System;

namespace EqualSumsEvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int number = n1;

            for (int i = n1; i <= n2; i++)
            {
                int evenSum = 0;
                int OddSum = 0;
                string iAsString = i.ToString();

                for(int j =0; j< iAsString.Length; j++)
                {
                    char positionSymbol = iAsString[j];
                    int p = int.Parse(positionSymbol.ToString());
                    if ((j+1) % 2 == 0)
                    {
                        evenSum += p;
                    }
                    else
                    {
                        OddSum += p;
                    }


                }
                if (evenSum == OddSum)
                {
                    Console.Write($"{i} ");
                }
                

            }

        }
    }
}
