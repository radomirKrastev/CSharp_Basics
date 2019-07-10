using System;

namespace DanceGym
{
    class Program
    {
        static void Main(string[] args)
        {
            //read length of room
            //read width of room
            //raed side of wardrobe
            //find area of room
            //find area of wardrobe
            //find area of bench
            //space in the room area of room - (area of room/10) - wardrobe(A*A) / 70.4

            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double areaRoom = (L * 100) * (W * 100);
            double areaWardrobe = (A*100)*(A*100);
            double areaBench = areaRoom / 10;

            double spaceRoom = (areaRoom - areaBench - areaWardrobe) / 7040;

            Console.WriteLine(Math.Floor(spaceRoom));              


        }
    }
}
