using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();

            int countOfGrades = 0;
            double averageGrade = 0;
            double sumOfGrades = 0;

            while (countOfGrades < 12)
            {
                double annualGrade = double.Parse(Console.ReadLine());
                

                if (annualGrade >= 4)
                {
                    sumOfGrades += annualGrade;
                    countOfGrades++;
                    averageGrade = sumOfGrades / countOfGrades;
                }


            }

            Console.WriteLine($"{nameOfStudent} graduated. Average grade: {averageGrade:F2}");

        }
    }
}
