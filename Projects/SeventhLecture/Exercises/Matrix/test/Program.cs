using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string nAsString = "" + n;
            char nPositon = nAsString[2];
            int g = nPositon + 1;

            string numberString =""+nPositon;
            int t = int.Parse(numberString);
            Console.WriteLine(t);
            

        }
    }
}
