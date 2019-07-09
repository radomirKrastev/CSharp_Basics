using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            char nameStadiumValue = '\0';
            int countCombinations = 0;


            for (char nameStadium = 'B'; nameStadium <= 'L'; nameStadium++)
            {
                if (countCombinations == number)
                {
                    break;
                }
                if (nameStadium % 2 == 0)
                {
                    nameStadiumValue = nameStadium;
                }
            }
        }
    }
}   
