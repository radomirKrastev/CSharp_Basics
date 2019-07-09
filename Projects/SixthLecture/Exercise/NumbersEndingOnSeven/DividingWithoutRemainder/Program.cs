using System;

namespace DividingWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            for (int i=0; i<number; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n%2==0)
                {
                    count1++;
                }
                if (n % 3 == 0)
                {
                    count2++;
                }
                if (n % 4 == 0)
                {
                    count3++;
                }
            }

            double p1 = (count1*1.0/number)*100;
            double p2 = (count2*1.0/number)*100;
            double p3 = (count3*1.0/number)*100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");

        }
    }
}
