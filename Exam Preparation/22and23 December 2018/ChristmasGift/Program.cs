using System;

namespace ChristmasGift
{
    class Program
    {
        static void Main(string[] args)
        {
            int count16andunder = 0;
            int above16 = 0;

            string command = Console.ReadLine();

            while(command != "Christmas")
            {
                int years = int.Parse(command);
                if(years <= 16)
                {
                    count16andunder++;
                }
                else
                {
                    above16++;
                }

                command = Console.ReadLine();

                
            }

            Console.WriteLine($"Number of adults: {above16}");
            Console.WriteLine($"Number of kids: {count16andunder}");
            int moneyForAdults = 15 * above16;
            int moneyForKids = 5 * count16andunder;
            Console.WriteLine($"Money for toys: {moneyForKids}");
            Console.WriteLine($"Money for sweaters: {moneyForAdults}");

        }
    }
}
