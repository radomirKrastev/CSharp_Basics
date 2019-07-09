using System;

namespace ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComputers = int.Parse(Console.ReadLine());
            double sales = 0;
            double totalSales = 0;
            int rating = 0;
            for (int i = 0; i < numberOfComputers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                string numberAsString = number.ToString();

                if (numberAsString.Length == 3)
                {
                    char firstChar = numberAsString[0];
                    char secondChar = numberAsString[1];
                    string salesAsString = ""+firstChar+secondChar;
                    int salesAsNumber = int.Parse(salesAsString);
                    sales = salesAsNumber;
                }
                else
                {
                    char firstChar = numberAsString[0];
                    string salesAsString = "" + firstChar;
                    int salesAsNumber = int.Parse(salesAsString);
                    sales = salesAsNumber;
                }

                char lastchar = numberAsString[numberAsString.Length-1];
                string lastDigitAsString = "" + lastchar;
                int ratingAsNumber = int.Parse(lastDigitAsString);
                rating += ratingAsNumber;

                if (ratingAsNumber == 2)
                {
                    sales = 0;
                }
                else if (ratingAsNumber == 3)
                {
                    sales *= 0.5;
                }
                else if (ratingAsNumber == 4)
                {
                    sales *= 0.7;
                }
                else if (ratingAsNumber == 5)
                {
                    sales *= 0.85;
                }

                totalSales += sales;



            }

            double averageRating = rating / numberOfComputers;
            Console.WriteLine($"{totalSales:F2}");
            Console.WriteLine($"{averageRating:F2}");

        }
    }
}
