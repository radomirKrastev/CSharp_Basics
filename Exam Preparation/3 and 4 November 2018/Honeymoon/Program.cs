using System;

namespace Honeymoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double neededMoney = 0;

            switch (city)
            {
                case "Cairo":
                    if (nights >= 1 && nights <= 4)
                    {
                        neededMoney = (nights * 500 + 600) * 0.97;
                    }
                    else if (nights >= 5 && nights <= 9)
                    {
                        neededMoney = (nights * 500 + 600) * 0.95;
                    }
                    else if (nights >= 10 && nights <= 24)
                    {
                        neededMoney = (nights * 500 + 600) * 0.9;
                    }
                    else if (nights >= 25 && nights <= 49)
                    {
                        neededMoney = (nights * 500 + 600) * 0.83;
                    }
                    else if (nights >= 50)
                    {
                        neededMoney = (nights * 500 + 600) * 0.70;
                    }
                    break;
                case "Paris":
                    if (nights<5)
                    {
                        neededMoney = (nights * 300) + 350;
                    }
                    else if (nights >= 5 && nights <= 9)
                    {
                        neededMoney = (nights * 300 + 350) * 0.93;
                    }
                    else if (nights >= 10 && nights <= 24)
                    {
                        neededMoney = (nights * 300 + 350) * 0.88;
                    }
                    else if (nights >= 25 && nights <= 49)
                    {
                        neededMoney = (nights * 300 + 350) * 0.78;
                    }
                    else if (nights >= 50)
                    {
                        neededMoney = (nights * 300 + 350) * 0.70;
                    }
                    break;
                case "Lima":
                    if (nights < 25)
                    {
                        neededMoney = (nights * 800) + 850;
                    }
                    
                    else if (nights >= 25 && nights <= 49)
                    {
                        neededMoney = (nights * 800 + 850) * 0.81;
                    }
                    else if (nights >= 50)
                    {
                        neededMoney = (nights * 800 + 850) * 0.70;
                    }
                    break;
                case "New York":
                    if (nights >=1 && nights<=4)
                    {
                        neededMoney = (nights * 600 + 650) * 0.97;
                    }
                    else if (nights >= 5 && nights <= 9)
                    {
                        neededMoney = (nights * 600 + 650) * 0.95;
                    }
                    else if (nights >= 10 && nights <= 24)
                    {
                        neededMoney = (nights * 600 + 650) * 0.88;
                    }
                    else if (nights >= 25 && nights <= 49)
                    {
                        neededMoney = (nights * 600 + 650) * 0.81;
                    }
                    else if (nights >= 50)
                    {
                        neededMoney = (nights * 600 + 650) * 0.70;
                    }
                    break;
                case "Tokyo":
                    if (nights < 10)
                    {
                        neededMoney = (nights * 700) + 700;
                    }
                    
                    else if (nights >= 10 && nights <= 24)
                    {
                        neededMoney = (nights * 700 + 700) * 0.88;
                    }
                    else if (nights >= 25 && nights <= 49)
                    {
                        neededMoney = (nights * 700+ 700) * 0.83;
                    }
                    else if (nights >= 50)
                    {
                        neededMoney = (nights * 700 + 700) * 0.70;
                    }
                    break;
            }

            double result = budget - neededMoney;
            if(result >= 0)
            {
                Console.WriteLine($"Yes! You have {result:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(result):F2} leva.");
            }
            
            
        }
    }
}
