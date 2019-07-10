using System;

namespace CharityCampaing
{
    class Program
    {
        static void Main(string[] args)
        {
            //read number of days
            //read number of confectioners
            //number of cakes
            //number of wafers
            //number of pancakes
            // cake = 45lv wafer = 5lv pancake = 3.2lv

            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafers = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double sum = (cakes * confectioners * 45 + wafers * confectioners * 5.8 + pancakes * confectioners * 3.2) * days * 0.875;

            Console.WriteLine($"{sum:F2}");





        }
    }
}
