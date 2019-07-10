using System;

namespace GoingHome
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            int litersPer100Km = int.Parse(Console.ReadLine());
            double priceGasolinePerLiter = double.Parse(Console.ReadLine());
            int prizeMoney = int.Parse(Console.ReadLine());

            double moneyLeft = prizeMoney - ((kilometers * 1.0 * litersPer100Km) / 100.0 * priceGasolinePerLiter);


            if (moneyLeft >= 0)
            {
                Console.WriteLine($"You can go home. {moneyLeft:F2} money left.");
            }

            else
            {

                double moneyLeftPerPerson = Math.Abs(prizeMoney / 5.0);
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {moneyLeftPerPerson:F2} money.");
            }

            




        }
    }
}
