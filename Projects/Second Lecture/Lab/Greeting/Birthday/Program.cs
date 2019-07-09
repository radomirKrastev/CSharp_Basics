using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volumeofparallelepipedindecimeters = length * 0.1 * width * 0.1 * heigth * 0.1;

            double litersofwater = volumeofparallelepipedindecimeters - (percentage * 0.01 * volumeofparallelepipedindecimeters);

            Console.WriteLine($"{litersofwater:F3}");

            


        }
    }
}
