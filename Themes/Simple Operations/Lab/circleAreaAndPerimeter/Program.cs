using System;

namespace circleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double p = Math.PI;

            double CircleArea = p * Math.Pow(radius, 2);
            double CirclePerimeter = 2 * p * radius;

            Console.WriteLine(Math.Round(CircleArea,2));
            Console.WriteLine(Math.Round(CirclePerimeter,2));
        }
    }
}
