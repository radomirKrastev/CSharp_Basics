using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" ||
                dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.5 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "apple":
                        price = 1.2 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "orange":
                        price = 0.85 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapefruit":
                        price = 1.45 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "kiwi":
                        price = 2.7 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "pineapple":
                        price = 5.5 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapes":
                        price = 3.85 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.7 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "apple":
                        price = 1.25 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "orange":
                        price = 0.9 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapefruit":
                        price = 1.6 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "kiwi":
                        price = 3.0 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "pineapple":
                        price = 5.6 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapes":
                        price = 4.2 * quantity;
                        Console.WriteLine($"{price:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }

    }
}
