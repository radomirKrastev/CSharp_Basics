using System;

namespace TrainTheTrainersMySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfJury = int.Parse(Console.ReadLine());
            int countOfGradesAll = 0;
            double sumOfGradesAll = 0;
            string command = Console.ReadLine();
            while (command != "Finish")
            {
                int countOfGradesStudent = 0;
                double sumOfGradeStudent = 0;
                for(int i = 0; i<countOfJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    countOfGradesStudent++;
                    countOfGradesAll++;
                    sumOfGradesAll += grade;
                    sumOfGradeStudent += grade;

                }
                double averageGradeStudent = sumOfGradeStudent / countOfGradesStudent; 
                Console.WriteLine($"{command} - {averageGradeStudent:F2}.");

                command = Console.ReadLine();

            }

            double averageGradeAll = sumOfGradesAll / countOfGradesAll;

            Console.WriteLine($"Student's final assessment is {averageGradeAll:F2}.");
        }
    }
}
