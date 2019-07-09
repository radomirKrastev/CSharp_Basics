using System;

namespace TradeComission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double size = double.Parse(Console.ReadLine());

            double comission = 0;

            if (town == "Sofia")
            {
                if (size >= 0 && size <= 500)
                {
                    double sum = size * 0.05;
                    Console.WriteLine($"{sum:F2}");
                }
                else if (size > 500 && size <= 1000)
                {
                    double sum = size * 0.07;
                    Console.WriteLine($"{sum:F2}");
                }
                else if (size > 1000 && size <= 10000)
                {
                    double sum = size * 0.08;
                    Console.WriteLine($"{sum:F2}");
                }
                else if (size > 10000)
                {
                    double sum = size * 0.12;
                    Console.WriteLine($"{sum:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (town == "Varna")
            {
                if (size >= 0 && size <= 500)
                {
                    double sum = size * 0.045;
                    Console.WriteLine($"{sum:F2}");
                }
                else if (size > 500 && size <= 1000)
                {
                    double sum = size * 0.075;
                    Console.WriteLine($"{sum:F2}");
                }
                else if (size > 1000 && size <= 10000)
                {
                    double sum = size * 0.10;
                    Console.WriteLine($"{sum:F2}");
                }
                else if (size > 10000)
                {
                    double sum = size * 0.13;
                    Console.WriteLine($"{sum:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            
            else if (town == "Plovdiv")
            {
                if (size >= 0 && size <= 500)
                {
                    double sum = size * 0.055;
                    Console.WriteLine($"{sum:F2}");
                }
                else if (size > 500 && size <= 1000)
                {
                    double sum = size * 0.08;
                    Console.WriteLine($"{sum:F2}");
                }
                else if (size > 1000 && size <= 10000)
                {
                    double sum = size * 0.12;
                    Console.WriteLine($"{sum:F2}");
                }
                else if (size > 10000)
                {
                    double sum = size * 0.145;
                    Console.WriteLine($"{sum:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            
            else
            {
                Console.WriteLine("error");
            }



        }

    }
}
