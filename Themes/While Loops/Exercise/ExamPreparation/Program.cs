using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitOfBadGrades = int.Parse(Console.ReadLine());

            int countOfBadGrades = 0;
            int countOfGrades = 0;
            int sumOfGrades = 0;
            string lastTask = "";
            while (countOfBadGrades < limitOfBadGrades)
            {
                string nameOfProblem = Console.ReadLine();
                if (nameOfProblem == "Enough")
                {
                    double averageGrade = sumOfGrades*1.0 / countOfGrades;
                    Console.WriteLine($"Average score: {averageGrade:F2}");
                    Console.WriteLine($"Number of problems: {countOfGrades}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;

                }
                
                
                lastTask = nameOfProblem;
                int grade = int.Parse(Console.ReadLine());
                sumOfGrades += grade;
                countOfGrades++;
                if (grade <= 4)
                {
                    countOfBadGrades++;
                }
                

            }

            if (countOfBadGrades >= limitOfBadGrades)
            {
                Console.WriteLine($"You need a break, {countOfBadGrades} poor grades.");   
            }

        }
    }
}
