using System;

namespace ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int BTC = int.Parse(Console.ReadLine());
            double CHK = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double usdMoney = CHK * 0.15;
            double bgnMoney = (BTC * 1168) + usdMoney*1.76;

            double eurMoney = bgnMoney / 1.95;

            double netMoneyInEUR = eurMoney-(eurMoney * (comission / 100.00));
            Console.WriteLine($"{netMoneyInEUR:F2}");

        }
    }
}
