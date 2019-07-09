using System;

namespace WeddinPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests = int.Parse(Console.ReadLine());
            int countOfPresents = int.Parse(Console.ReadLine());

            int money = 0;
            int electronicDevices = 0;
            int vouchers = 0;
            int others = 0;

            int presents = 0;

            while (presents < countOfPresents)
            {
                string category = Console.ReadLine();

                if (category == "A")
                {
                    money++;
                }
                else if(category == "B")
                {
                    electronicDevices++;
                }
                else if (category == "V")
                {
                    vouchers++;
                }
                else
                {
                    others++;
                }

                presents++;
            }

            double moneyAsPercentage = (money*1.0 / countOfPresents)*100;
            double electronicDevicesAsPercentage = (electronicDevices*1.0 / countOfPresents)*100;
            double vouchersAsPercentage = (vouchers*1.0 / countOfPresents)*100;
            double othersAsPercentage = (others*1.0 / countOfPresents)*100;
            double presentsAsPercentage = (countOfPresents*1.0/numberOfGuests)*100;


            Console.WriteLine($"{moneyAsPercentage:F2}%");
            Console.WriteLine($"{electronicDevicesAsPercentage:F2}%");
            Console.WriteLine($"{vouchersAsPercentage:F2}%");
            Console.WriteLine($"{othersAsPercentage:F2}%");
            Console.WriteLine($"{presentsAsPercentage:F2}%");

        }
    }
}
