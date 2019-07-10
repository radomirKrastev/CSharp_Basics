using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //cover/square
            //find numbers
            //find length table
            //find width table
            //find cover area
            //find square area
            //find area of covers and squares
            //find dollars
            //find the price of covers and squares in USD
            //dollars to bgn


            int count = int.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());
            double leva = 1.85;

            double coverArea = count * (lenghtTable + 2 * 0.30) * (widthTable + 2 * 0.30);
            double squareArea = count * (lenghtTable / 2) * (lenghtTable / 2);

            double dollarsPrice = coverArea * 7 + squareArea * 9;
            double levaPrice = dollarsPrice * leva;

            Console.WriteLine($"{dollarsPrice:F2} USD");
            Console.WriteLine($"{levaPrice:F2} BGN");










            
        



        }
    }
}
