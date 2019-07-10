using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJury = int.Parse(Console.ReadLine());

            double sumAllGrades = 0;
            int countAllGrades = 0;
            string presentation = Console.ReadLine();
            while (presentation != "Finish")
            {
                double sum = 0;
                double averageGrade = 0;
                
                for (int i =0; i<countJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumAllGrades += grade;
                    countAllGrades++;
                    sum += grade;
                    averageGrade = sum / countJury * 1.0;
                }
                Console.WriteLine($"{presentation} - {averageGrade:F2}.");

                

                presentation = Console.ReadLine();
            }

            double averageAll = sumAllGrades / countAllGrades*1.0;
            if (presentation == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {averageAll:F2}.");
            }

        }
    }
}
