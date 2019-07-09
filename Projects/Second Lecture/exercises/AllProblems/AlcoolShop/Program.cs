using System;

namespace AlcoolShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //read price of whiskey for liter 
            //liters of beer
            //liters of wine
            //liters of rakija
            //liters of whiskey
            //price of rakija = 0.5*price of whiskey
            //price of wine = 0.4* price of rakija
            //price of beer = 0.8* price of rakija 

            double priceWhiskey = double.Parse(Console.ReadLine());
            double litersBeer = double.Parse(Console.ReadLine());
            double litersWine = double.Parse(Console.ReadLine());
            double litersRakija = double.Parse(Console.ReadLine());
            double litersWhiskey = double.Parse(Console.ReadLine());

            double priceRakija = 0.5 * priceWhiskey;
            double priceWine = 0.6 * priceRakija;
            double priceBeer = 0.2 * priceRakija;

            double sum = priceWhiskey * litersWhiskey + priceRakija * litersRakija + priceWine * litersWine + priceBeer * litersBeer;

            Console.WriteLine($"{sum:F2}");








        }
    }
}
