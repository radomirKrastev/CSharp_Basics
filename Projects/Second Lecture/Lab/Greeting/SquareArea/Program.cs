using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double squareArea = side * side;
            Console.WriteLine(squareArea);

        }
    }
}
