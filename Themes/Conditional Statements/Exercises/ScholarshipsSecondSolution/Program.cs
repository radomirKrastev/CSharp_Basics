using System;

namespace ScholarshipsSecondSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());

            double excellentScholarship = averageGrade * 25;
            double socialScolarship = minimumSalary * 0.35;



            if (averageGrade >= 5.5 && income<minimumSalary && excellentScholarship >= socialScolarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else if (averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else if(income < minimumSalary && averageGrade >= 4.5 )
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScolarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
