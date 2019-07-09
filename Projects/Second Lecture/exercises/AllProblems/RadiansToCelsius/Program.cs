using System;

namespace RadiansToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read radians 
            //Calculate degrees -> radians * 180 / pi
            //Print -> round

            double radians = double.Parse(Console.ReadLine());

            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(Math.Round(degrees));
        }
    }
}
