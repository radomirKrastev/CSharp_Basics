using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double widdth = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double averageHeigthOfAstronaut = double.Parse(Console.ReadLine());

            double volumeRocket = widdth * length * heigth;
            double volumeRoom = (averageHeigthOfAstronaut + 0.4) * 2 * 2;

            double howMuchAstronauts = Math.Floor(volumeRocket / volumeRoom);

            if(howMuchAstronauts>=3 && howMuchAstronauts <= 10)
            {
                Console.WriteLine($"The spacecraft holds {howMuchAstronauts} astronauts.");
            }
            else if (howMuchAstronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
