using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //read a (side)
            //read h (height)
            //calculate area a*h/2
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = side * height / 2;

            Console.WriteLine($"Area is: {area:F2}");

            //
        }
    }
}
