using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStay = int.Parse(Console.ReadLine());
            string kindOfRoom = Console.ReadLine();
            string rate = Console.ReadLine();

            int nights = daysStay-1; 

            
            double amountDue = 0;

            if (nights < 10)
            {
                switch (kindOfRoom)
                {
                    case "room for one person":
                        amountDue = nights * 18;
                        break;
                    case "apartment":
                        amountDue = (nights * 25)*0.7;
                        break;
                    case "president apartment":
                        amountDue = (nights * 35)*0.9;
                        break;
                }
            }
            else if ( nights >=10 && nights <= 15)
            {
                switch (kindOfRoom)
                {
                    case "room for one person":
                        amountDue = nights * 18;
                        break;
                    case "apartment":
                        amountDue = (nights * 25) * 0.65;
                        break;
                    case "president apartment":
                        amountDue = (nights * 35) * 0.85;
                        break;
                }
            }
            else if (nights >15)
            {
                switch (kindOfRoom)
                {
                    case "room for one person":
                        amountDue = nights * 18;
                        break;
                    case "apartment":
                        amountDue = (nights * 25) * 0.5;
                        break;
                    case "president apartment":
                        amountDue = (nights * 35) * 0.80;
                        break;
                }
            }


            if (rate == "positive")
            {
                amountDue += (25 * amountDue) / 100;
                Console.WriteLine($"{amountDue:F2}");
            }
            else
            {
                amountDue -= (10 * amountDue) / 100;
                Console.WriteLine($"{amountDue:F2}");
            }

        }
    }
}
