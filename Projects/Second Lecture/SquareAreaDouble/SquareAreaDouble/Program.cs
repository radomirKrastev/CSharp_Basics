using System;

namespace SquareAreaDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareSide = double.Parse(Console.ReadLine());

            double squareArea = squareSide * squareSide;

            Console.WriteLine(squareArea);


        }
    }
}
