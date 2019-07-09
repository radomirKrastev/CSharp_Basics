using System;

namespace SkiHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rate = Console.ReadLine();

            int nights = days;
            if (days >1)
            {
               nights = days - 1;
            }

            if(type == "room for one person" && rate =="positive")
            {
                double price = 18;
                    double payment = price * nights;
                    double result = payment + (0.25 * payment);
                    Console.WriteLine($"{result:F2}");
            }
            else if (type == "room for one person" && rate == "negative")
            {
                double price = 18;
                double payment = price * nights;
                double result = payment - (0.1 * payment);
                Console.WriteLine($"{result:F2}");
            }

            else if (type == "apartment" && rate == "positive")
            {
                if (days < 10)
                {
                    double price = 25;
                    double payment = (price * nights)*0.7;
                    double result = payment + (0.25 * payment);
                    Console.WriteLine($"{result:F2}");
                }
                else if (days >= 10 && days <= 15)
                {
                    double price = 25;
                    double payment = (price * nights) * 0.65;
                    double result = payment + (0.25 * payment);
                    Console.WriteLine($"{result:F2}");
                }
                else if(days > 15)
                {
                    double price = 25;
                    double payment = (price * nights) * 0.5;
                    double result = payment + (0.25 * payment);
                    Console.WriteLine($"{result:F2}");
                }
            }
            else if (type == "apartment" && rate == "negative")
            {
                if (days < 10)
                {
                    double price = 25;
                    double payment = (price * nights) * 0.7;
                    double result = payment - (0.1 * payment);
                    Console.WriteLine($"{result:F2}");
                }
                else if (days >= 10 && days <= 15)
                {
                    double price = 25;
                    double payment = (price * nights) * 0.65;
                    double result = payment - (0.1 * payment);
                    Console.WriteLine($"{result:F2}");
                }
                else if (days > 15)
                {
                    double price = 25;
                    double payment = (price * nights) * 0.5;
                    double result = payment - (0.1 * payment);
                    Console.WriteLine($"{result:F2}");
                }

            }

            else if (type == "president apartment" && rate == "positive")
            {
                if (days < 10)
                {
                    double price = 35;
                    double payment = (price * nights) * 0.9;
                    double result = payment + (0.25 * payment);
                    Console.WriteLine($"{result:F2}");
                }
                else if (days >= 10 && days <= 15)
                {
                    double price = 35;
                    double payment = (price * nights) * 0.85;
                    double result = payment + (0.25 * payment);
                    Console.WriteLine($"{result:F2}");
                }
                else if (days > 15)
                {
                    double price = 35;
                    double payment = (price * nights) * 0.8;
                    double result = payment + (0.25 * payment);
                    Console.WriteLine($"{result:F2}");
                }
            }

            else if (type == "president apartment" && rate == "negative")
            {
                if (days < 10)
                {
                    double price = 35;
                    double payment = (price * nights) * 0.9;
                    double result = payment - (0.1 * payment);
                    Console.WriteLine($"{result:F2}");
                }
                else if (days >= 10 && days <= 15)
                {
                    double price = 35;
                    double payment = (price * nights) * 0.85;
                    double result = payment - (0.1 * payment);
                    Console.WriteLine($"{result:F2}");
                }
                else if (days > 15)
                {
                    double price = 35;
                    double payment = (price * nights) * 0.8;
                    double result = payment - (0.1 * payment);
                    Console.WriteLine($"{result:F2}");
                }
            }
        }
    }
}
