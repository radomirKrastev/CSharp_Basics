using System;

namespace BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestPerformantMoney = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int totalMoney = 0;

            int countOfGuests = 0;
            while(command != "The restaurant is full")
            {
                int group = int.Parse(command);
                
                if (group < 5)
                {
                    totalMoney += group * 100;
                }
                else
                {
                    totalMoney += group * 70;
                }

                countOfGuests += group;
                command = Console.ReadLine();
            }

            int result = totalMoney - guestPerformantMoney;
            if (result >= 0)
            {
                Console.WriteLine($"You have {countOfGuests} guests and {result} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {countOfGuests} guests and {totalMoney} leva income, but no singer.");
            }

        }
    }
}
