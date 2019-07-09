using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());
            int countLessThan200 = 0;
            int countBetween200and399 = 0;
            int countBetween400and599 = 0;
            int countBetween600and799 = 0;
            int countGreaterThan800 = 0;
                                 
            for (int i = 0; i<totalNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    countLessThan200++;
                }
                else if (number >=200 && number < 400)
                {
                    countBetween200and399++;
                }
                else if (number >=400 && number < 600)
                {
                    countBetween400and599++;
                }
                else if (number >= 600 && number < 800)
                {
                    countBetween600and799++;
                }
                else
                {
                    countGreaterThan800++;
                }
            }

            double p1 = (countLessThan200*1.0 / totalNumbers) * 100;
            double p2 = (countBetween200and399*1.0 / totalNumbers) * 100;
            double p3 = (countBetween400and599*1.0 / totalNumbers) * 100;
            double p4 = (countBetween600and799*1.0 / totalNumbers) * 100;
            double p5 = (countGreaterThan800*1.0 / totalNumbers) * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");


        }

    }
}
