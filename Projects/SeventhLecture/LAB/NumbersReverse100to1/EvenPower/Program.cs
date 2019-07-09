using System;

namespace EvenPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double poweredNumber = 2;

            for (int i=0; i<=n; i += 2)
            {
                double result = Math.Pow(poweredNumber, i);
                Console.WriteLine(result);
            }
        }
    }
}
