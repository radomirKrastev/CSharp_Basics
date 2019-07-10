using System;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // x1, y1, x2, y2, x и y

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool xCoincide = x == x1 || x == x2;
            bool yBetween = y >= y1 && y <= y2;
            bool yCoincide = y == y1 || y == y2;
            bool xBetween = x >= x1 && x <= x2;

            bool firstCheck = xCoincide && yBetween;
            bool secondCheck = yCoincide && xBetween;

            if (firstCheck || secondCheck)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
