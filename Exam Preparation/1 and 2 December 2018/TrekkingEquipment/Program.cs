using System;

namespace TrekkingEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAlpinists = int.Parse(Console.ReadLine());
            int countOfCarabiners = int.Parse(Console.ReadLine());
            
            int countOfRopes = int.Parse(Console.ReadLine());
            int countOfPicelle = int.Parse(Console.ReadLine());

            double NetSumPerAlpinist = countOfCarabiners * 36.0 + countOfRopes * 3.6 + countOfPicelle * 19.8;
            double grossSumPerAlpinist = (NetSumPerAlpinist * 20) / 100 + NetSumPerAlpinist;

            double TotalSumForAll = grossSumPerAlpinist * numberOfAlpinists;

            Console.WriteLine($"{TotalSumForAll:F2}");


        }
    }
}
