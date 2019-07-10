using System;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console
            //calculate cleaning time with the rest
            //if surprise

            double brother1CleaningTime = double.Parse(Console.ReadLine());
            double brother2CleaningTime = double.Parse(Console.ReadLine());
            double brother3CleaningTime = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());

            double cleaningTime = 1 / (1 / brother1CleaningTime + 1 / brother2CleaningTime + 1 / brother3CleaningTime);
            double totalTime = cleaningTime * 1.15;

            Console.WriteLine($"Cleaning time: {totalTime:F2}");

            double leftTime = totalTime - fishingTime;
            leftTime = Math.Abs(leftTime);
            

            if (totalTime <= fishingTime)
            {
                leftTime = Math.Floor(leftTime);
                Console.WriteLine($"Yes, there is a surprise - time left -> {leftTime} hours.");
            }
            else if (totalTime > fishingTime)
            {
                leftTime = Math.Ceiling(leftTime);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {leftTime} hours.");
            }



        }
    }
}
