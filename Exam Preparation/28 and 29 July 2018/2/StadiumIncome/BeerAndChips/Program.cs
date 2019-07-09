using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameFan = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int packsOfChips = int.Parse(Console.ReadLine());

            double beersPrice = beers * 1.2;
            double chipsPrice = Math.Ceiling(beersPrice * 0.45 * packsOfChips);

            double result = budget - (beersPrice + chipsPrice);


            if(result >= 0)
            {
                Console.WriteLine($"{nameFan} bought a snack and has {result:F2} leva left.");
            }
            
            else
            {
                Console.WriteLine($"{nameFan} needs {Math.Abs(result):F2} more leva!");
            }
            



        }
    }
}
