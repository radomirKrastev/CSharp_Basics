using System;

namespace SwimmingWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double swimmingTime = double.Parse(Console.ReadLine());

            double numberOfDelays = distanceInMeters / 15;
            double timeOfDelays = Math.Floor(numberOfDelays) * 12.5;

            double timeIvan = (distanceInMeters * swimmingTime) + timeOfDelays;

            if (timeIvan < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeIvan:F2} seconds.");
            }
            else if (timeIvan >= worldRecord)
            {
                double additionalTime = timeIvan - worldRecord;
                Console.WriteLine($"No, he failed! He was {additionalTime:F2} seconds slower.");
            }
        }
    }
}
