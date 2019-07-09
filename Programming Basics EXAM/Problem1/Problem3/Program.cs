using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();

            double grade = 0;

            if(country == "Russia")
            {
                switch (instrument)
                {
                    case "ribbon":
                        grade = 9.1 + 9.4;
                        break;
                    case "hoop":
                        grade = 9.3 + 9.8;
                        break;
                    case "rope":
                        grade = 9.6 + 9;
                        break;
                }
            }
            else if (country == "Bulgaria")
            {
                switch (instrument)
                {
                    case "ribbon":
                        grade = 9.6 + 9.4;
                        break;
                    case "hoop":
                        grade = 9.55 + 9.75;
                        break;
                    case "rope":
                        grade = 9.5 + 9.4;
                        break;
                }
            }
            else if (country == "Italy")
            {
                switch (instrument)
                {
                    case "ribbon":
                        grade = 9.2 + 9.5;
                        break;
                    case "hoop":
                        grade = 9.45 + 9.35;
                        break;
                    case "rope":
                        grade = 9.7 + 9.15;
                        break;
                }
            }

            double percentageForMax = 100 - ((grade / 20) * 100);

            Console.WriteLine($"The team of {country} get {grade:F3} on {instrument}.");
            Console.WriteLine($"{percentageForMax:F2}%");


        }


    }
}
