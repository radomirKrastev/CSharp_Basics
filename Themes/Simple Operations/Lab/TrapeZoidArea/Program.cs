using System;

namespace TrapeZoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double areaT = (side1 + side2) * height / 2;

            Console.WriteLine($"{areaT:F2}");


        }
    }
}
