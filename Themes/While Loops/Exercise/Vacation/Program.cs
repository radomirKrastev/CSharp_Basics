using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double balance = double.Parse(Console.ReadLine());

            int countOfDays = 0;
            int countOfSpendDays = 0;
            while (balance<moneyForVacation)
            {
                string input = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                countOfDays++;
                if (input == "spend")
                {
                    countOfSpendDays++;
                    if (balance < amount)
                    {
                        balance = 0;
                    }
                    else
                    {
                        balance -= amount;
                    }
                }
                else if (input == "save")
                {
                    countOfSpendDays = 0;
                    balance += amount;
                }

                if (countOfSpendDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countOfDays);
                    break;
                }

                if (balance >= moneyForVacation)
                {
                    Console.WriteLine($"You saved the money for {countOfDays} days.");
                    break;
                }


            }

        }
    }
}
