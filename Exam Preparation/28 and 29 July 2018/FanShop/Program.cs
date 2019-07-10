using System;

namespace FanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());

            int price = 0;

            for(int i = 0; i<items; i++)
            {
                string itemSelected = Console.ReadLine();
                switch (itemSelected)
                {
                    case "hoodie":
                        price += 30;
                        break;
                    case "keychain":
                        price += 4;
                        break;
                    case "T-shirt":
                        price += 20;
                        break;
                    case "flag":
                        price += 15;
                        break;
                    case "sticker":
                        price += 1;
                        break;
                }
                
            }

            int result = budget - price;

            if (result >= 0)
            {
                Console.WriteLine($"You bought {items} items and left with {result} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(result)} more lv.");
            }

        }
    }
}
