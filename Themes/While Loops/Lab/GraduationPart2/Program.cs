using System;

namespace GraduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfStudent = Console.ReadLine();

            double averageGrade = 0;
            double sumOfGrades = 0;
            double countOfGrades = 0;
            double countOfBadGrades = 0;

            while (countOfGrades < 12)
            {
                double annualGrade = double.Parse(Console.ReadLine());

                if (annualGrade >= 4)
                {
                    sumOfGrades += annualGrade;
                    countOfGrades++;
                    averageGrade = sumOfGrades / countOfGrades;
                }
                else
                {
                    countOfBadGrades++;

                    if (countOfBadGrades > 1)
                    {
                        countOfGrades ++;
                        Console.WriteLine($"{nameOfStudent} has been excluded at {countOfGrades} grade");
                        break;
                    }
                }
            }
            if(countOfGrades == 12)
            {
                Console.WriteLine($"{nameOfStudent} graduated. Average grade: {averageGrade:F2}");

            }
            
        }
    }
}
