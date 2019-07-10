using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //read data (3 lines number, unit, unit)
            //if print

            double number = double.Parse(Console.ReadLine());
            string unit1 = Console.ReadLine();
            string unit2 = Console.ReadLine();

            if (unit1 == "mm" && unit2 == "cm")
            {
                double num = number / 10.0;
                Console.WriteLine($"{num:F3}");
            }
            else if (unit1 == "m" && unit2 == "cm")
            {
                double num = number * 100.0;
                Console.WriteLine($"{num:F3}");
            }
            else if (unit1 == "m" && unit2 == "mm")
            {
                double num = number * 1000.0;
                Console.WriteLine($"{num:F3}");
            }
            else if (unit1 == "mm" && unit2 == "m")
            {
                double num = number / 1000.0;
                Console.WriteLine($"{num:F3}");

            }
            else if (unit1 == "cm" && unit2 == "m")
            {
                double num = number / 100.0;
                Console.WriteLine($"{num:F3}");
            }
            else if (unit1 == "cm" && unit2 == "mm")
            {
                double num = number * 10.0;
                Console.WriteLine($"{num:F3}");
            }
        }
    }
}
