using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsStay = int.Parse(Console.ReadLine());


            double priceStudio = 0;
            double priceApartment = 0;
            double sumStudio = 0;
            double sumApartment = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApartment = 65;

                if (nightsStay > 7 && nightsStay <=14)
                {
                     sumStudio = (nightsStay*1.0 * priceStudio) * 0.95;
                     sumApartment = nightsStay*1.0 * priceApartment;
                    
                }
                else if (nightsStay > 14)
                {
                     sumStudio = (nightsStay*1.0 * priceStudio) * 0.7;
                     sumApartment = (nightsStay*1.0 * priceApartment) * 0.9;
                }
                else
                {
                     sumStudio = nightsStay*1.0 * priceStudio;
                     sumApartment = nightsStay*1.0 * priceApartment;
                }
            }
            
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.2;
                priceApartment = 68.7;

                if (nightsStay > 7 && nightsStay <= 14)
                {
                    sumStudio = nightsStay*1.0 * priceStudio;
                    sumApartment = nightsStay*1.0 * priceApartment;

                }
                else if (nightsStay > 14)
                {
                    sumStudio = (nightsStay*1.0 * priceStudio) * 0.8;
                    sumApartment = (nightsStay*1.0 * priceApartment) * 0.9;
                }
                else
                {
                    sumStudio = nightsStay*1.0 * priceStudio;
                    sumApartment = nightsStay*1.0 * priceApartment;
                }
            }

            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApartment = 77;

                if (nightsStay > 7 && nightsStay <= 14)
                {
                     sumStudio = nightsStay*1.0 * priceStudio;
                     sumApartment = nightsStay*1.0 * priceApartment;

                }
                else if (nightsStay > 14)
                {
                     sumStudio = nightsStay*1.0 * priceStudio;
                     sumApartment = (nightsStay*1.0 * priceApartment) * 0.9;
                }
                else
                {
                     sumStudio = nightsStay*1.0 * priceStudio;
                     sumApartment = nightsStay*1.0 * priceApartment;
                }
            }

            Console.WriteLine($"Apartment: {sumApartment:F2} lv.");
            Console.WriteLine($"Studio: {sumStudio:F2} lv.");

        }

    }
}
