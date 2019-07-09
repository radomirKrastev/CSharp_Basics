using System;

namespace ChristmasMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());
            int countFantasyBooks = int.Parse(Console.ReadLine());
            int countHorrorBooks = int.Parse(Console.ReadLine());
            int countRomanticBooks = int.Parse(Console.ReadLine());

            double grossMoneyGained = countFantasyBooks * 14.9 + countHorrorBooks * 9.8 + countRomanticBooks * 4.3;

            double netMoneyGained = grossMoneyGained - (grossMoneyGained * 0.2);

            double additionalMoney = 0;
            double bonusForTheSellers = 0;

            if (netMoneyGained >= target)
            {
                additionalMoney = netMoneyGained - target;
                bonusForTheSellers = Math.Floor(0.1 * additionalMoney);
                
                
                target =target+  additionalMoney -bonusForTheSellers  ;
                Console.WriteLine($"{target:F2} leva donated.");
                Console.WriteLine($"Sellers will receive {bonusForTheSellers} leva.");
            }

            else
            {
                double neededMoney = target - netMoneyGained;
                Console.WriteLine($"{neededMoney:F2} money needed.");
            }

        }
    }
}
