using System;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                switch (dayOrNight)
                {
                    case "day":
                        if (people >= 4)
                        {
                              price = 10.5 * 0.9;
                        }
                        else
                        {
                              price = 10.5;
                        }
                        break;
                    case "night":
                        if (people >= 4)
                        {
                              price = 8.4*0.9;
                        }
                        else
                        {
                              price = 8.4;
                        }
                        break;
                }
            }

            else if (month == "june" || month == "july" || month == "august")
            {
                switch (dayOrNight)
                {
                    case "day":
                        if (people >= 4)
                        {
                              price = 12.6 * 0.9;
                        }
                        else
                        {
                              price = 12.6;
                        }
                        break;
                    case "night":
                        if (people >= 4)
                        {
                              price = 10.2 * 0.9;
                        }
                        else
                        {
                              price = 10.2;
                        }
                        break;
                }
            }

            if (hours >= 5)
            {
                price *= 0.5;
            }

            Console.WriteLine($"Price per person for one hour: {price:F2}");
            double totalPrice = price *hours* people;
            Console.WriteLine($"Total cost of the visit: {totalPrice:F2}");
                


        }
    }
}
