﻿using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            change = change * 100;
            change = Math.Floor(change);
            int countCoins = 0;
            while (change > 0)
            {
                if (change >= 200)
                {
                    change = change - 200;
                    countCoins++;

                }
                else if(change >= 100)
                {
                    change = change -100;
                    countCoins++;
                }
                else if (change >= 50)
                {
                    change -= 50;
                    countCoins++;
                }
                else if (change >= 20)
                {
                    change -= 20;
                    countCoins++;
                }
                else if (change >= 10)
                {
                    change -= 10;
                    countCoins++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    countCoins++;
                }
                else if (change >= 2)
                {
                    change -= 2;
                    countCoins++;
                }
                else if (change >= 1)
                {
                    change -= 1;
                    countCoins++;
                }
            }
            Console.WriteLine(countCoins);
        }
    }
}
