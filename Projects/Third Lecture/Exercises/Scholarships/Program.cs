using System;

namespace Scholarships
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grades = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());

            bool incomeLessMinimumSalary = income < minimumSalary;
            bool resultScolarhip = grades >= 5.5;

            double socialScholarhip = Math.Floor(0.35 * minimumSalary);
            double excellentScholarhip = Math.Floor(grades * 25);

            if(resultScolarhip && excellentScholarhip >= socialScholarhip)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarhip} BGN");
            }
            else if(incomeLessMinimumSalary && grades >= 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarhip} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
