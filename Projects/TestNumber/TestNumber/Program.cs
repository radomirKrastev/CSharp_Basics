using System;

namespace TestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 25;
            //Console.WriteLine(a/6);
            //Console.WriteLine(a % 6);

            double n = 4.16864;
            Console.WriteLine(Math.Ceiling(n));
            Console.WriteLine(Math.Floor(n));
            Console.WriteLine(Math.Round(n, 2));
            Console.WriteLine($"{n:F2}");


        }
    }
}
