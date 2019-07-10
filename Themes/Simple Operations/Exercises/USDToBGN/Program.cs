using System;

namespace USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double USD = double.Parse(Console.ReadLine());
            double BGN = 1.79549;

            double BGNtoUSD = USD * BGN;

            Console.WriteLine(Math.Round(BGNtoUSD,2));



        }
    }
}
