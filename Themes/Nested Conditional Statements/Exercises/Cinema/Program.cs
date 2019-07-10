using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int seats = rows * columns;
            double priceOfTickets = 0;

            if (typeOfMovie == "Premiere")
            {
                priceOfTickets = 12;
            }
            else if (typeOfMovie == "Normal")
            {
                priceOfTickets = 7.5;
            }
            else if (typeOfMovie == "Discount")
            {
                priceOfTickets = 5;
            }

            double endPrice = seats * priceOfTickets;
            Console.WriteLine($"{endPrice:F2} leva ");

        }
    }
}
