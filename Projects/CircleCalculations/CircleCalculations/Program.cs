using System;

namespace CircleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Goal 1 => area
            // Goal 2 => perimeter

            // from console => radius
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;

            // area => Pi * r * r
            double area = pi * r * r;



            // perimeter => 2 * Pi * r

            double perimeter = 2 * pi * r;

            // Pi => 3.14?

            //console => write => format
            Console.WriteLine("{0:F2}", area);
            Console.WriteLine("{0:F2}", perimeter);
        }
    }
}
