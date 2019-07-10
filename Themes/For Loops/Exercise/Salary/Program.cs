using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsOpened = int.Parse(Console.ReadLine());
            double netSalary = double.Parse(Console.ReadLine());
            int fine = 0;

            for(int check =0; check < tabsOpened &&  netSalary > fine; check++)
            {
                string nameOfSite = Console.ReadLine();

                switch (nameOfSite)
                {
                    case "Facebook": fine += 150;
                        if (netSalary - fine <= 0)
                        {
                            Console.WriteLine("You have lost your salary.");
                        }
                        break;
                    case "Instagram": fine += 100;
                        if (netSalary - fine <= 0)
                        {
                            Console.WriteLine("You have lost your salary.");
                        }
                        break;
                    case "Reddit": fine += 50;
                        if (netSalary - fine <= 0)
                        {
                            Console.WriteLine("You have lost your salary.");
                        }
                        break;
                    default:
                        break;
                }
 
            }
            if (netSalary > fine)
            {
                double salaryLeft = netSalary - fine;
                Console.WriteLine(Math.Round(salaryLeft));
            }
            
        }
    }
}
