using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfchrysanthemums = int.Parse(Console.ReadLine());
            int countOfroses = int.Parse(Console.ReadLine());
            int countOftulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHoliday = Console.ReadLine();

            double priceOfFlowers = 0;
            int totalFlowers = countOfchrysanthemums + countOfroses + countOftulips;

            switch (season)
            {
                case "Summer":
                    if(isHoliday == "Y")
                    {
                        priceOfFlowers = (countOfchrysanthemums*2.0 * 1.15) + (countOfroses* 4.1*1.15) + 
                            (countOftulips*2.5*1.15);  
                        
                    }

                    else if (isHoliday == "N")
                    {
                        priceOfFlowers = (countOfchrysanthemums * 2.0) + (countOfroses *4.1) +
                            (countOftulips * 2.5);
                    }
                    break;

                case "Spring":

                    if(isHoliday == "Y" && countOftulips > 7)
                    {
                        priceOfFlowers = ((countOfchrysanthemums * 2.0 * 1.15) + (countOfroses * 4.1 * 1.15) +
                            (countOftulips * 2.5 * 1.15))*0.95;
                    }

                    else if (isHoliday == "Y")
                    {
                        priceOfFlowers = (countOfchrysanthemums * 2.0 * 1.15) + (countOfroses * 4.1 * 1.15) +
                            (countOftulips * 2.5 * 1.15);
                    }

                    else if (isHoliday == "N" && countOftulips>7)
                    {
                        priceOfFlowers = ((countOfchrysanthemums * 2.0) + (countOfroses * 4.1) +
                            (countOftulips * 2.5))*0.95;
                    }

                    else if (isHoliday == "N")
                    {
                        priceOfFlowers = (countOfchrysanthemums * 2.0) + (countOfroses * 4.1) +
                            (countOftulips * 2.5);
                    }
                    break;

                case "Winter":

                    if (isHoliday == "Y" && countOfroses >= 10)
                    {
                        priceOfFlowers = ((countOfchrysanthemums * 3.75 * 1.15) + (countOfroses * 4.5 * 1.15) +
                            (countOftulips * 4.15 * 1.15)) * 0.9;
                    }

                    else if (isHoliday == "Y")
                    {
                        priceOfFlowers = (countOfchrysanthemums * 3.75 * 1.15) + (countOfroses * 4.5 * 1.15) +
                            (countOftulips * 4.15 * 1.15);
                    }

                    else if (isHoliday == "N" && countOfroses >= 10)
                    {
                        priceOfFlowers = ((countOfchrysanthemums * 3.75) + (countOfroses * 4.5) +
                            (countOftulips * 4.15)) * 0.9;
                    }

                    else if (isHoliday == "N")
                    {
                        priceOfFlowers = (countOfchrysanthemums * 3.75) + (countOfroses * 4.5) +
                            (countOftulips * 4.15);
                    }
                    break;

                case "Autumn":
                    if (isHoliday == "Y")
                    {
                        priceOfFlowers = (countOfchrysanthemums * 3.75 * 1.15) + (countOfroses * 4.5 * 1.15) +
                            (countOftulips * 4.15 * 1.15);

                    }

                    else if (isHoliday == "N")
                    {
                        priceOfFlowers = (countOfchrysanthemums * 3.75) + (countOfroses * 4.5) +
                            (countOftulips * 4.15);
                    }
                    break;
            }

            

            if (totalFlowers > 20)
            {
                double totalBouquetPrice = priceOfFlowers*0.8 + 2;
                Console.WriteLine($"{totalBouquetPrice:F2}");
            }
            else
            {
                double totalBouquetPrice = priceOfFlowers + 2;
                Console.WriteLine($"{totalBouquetPrice:F2}");
            }
            

        }
    }
}
