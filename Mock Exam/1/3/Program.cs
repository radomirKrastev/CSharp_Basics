using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestPerformence = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int income = 0;
            int countOfGuests = 0;

            while (command != "The restaurant is full")
            {
                int groupOfGuests = int.Parse(command);
                countOfGuests += groupOfGuests;
                if (groupOfGuests < 5)
                {
                    income += groupOfGuests * 100;
                }
                else
                {
                    income += groupOfGuests * 70;
                }


                command = Console.ReadLine();
            }

            if(income >= guestPerformence)
            {
                int result = income - guestPerformence;
                Console.WriteLine($"You have {countOfGuests} guests and {result} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {countOfGuests} guests and {income} leva income, but no singer.");
            }

        }
    }
}
