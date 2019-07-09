using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            double sumOfGrades = 0;
            
            int countOfExcellentGrades = 0;
            
            int countOfVeryGoodGrades = 0;
            
            int countOfGoodGrades = 0;
            
            int countOfFails = 0;

            for (int i =0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                
                sumOfGrades += grade;
                if (grade >= 5)
                {
                    countOfExcellentGrades++;
                }
                else if (grade >= 4 && grade < 5)
                {
                    countOfVeryGoodGrades++;
                }
                else if (grade >= 3 && grade < 4)
                {
                    countOfGoodGrades++;
                }
                else if (grade < 3)
                {
                    countOfFails++;
                }
            }


            double topStudents = (countOfExcellentGrades*1.0 / numberOfStudents)*100;
            double goodStudents = (countOfVeryGoodGrades*1.0 / numberOfStudents)*100;
            double mediocoreStudents = (countOfGoodGrades*1.0 / numberOfStudents)*100;
            double failures = (countOfFails*1.0 / numberOfStudents)*100;
            double average = sumOfGrades / numberOfStudents;

            Console.WriteLine($"Top students: {topStudents:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodStudents:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {mediocoreStudents:F2}%");
            Console.WriteLine($"Fail: {failures:F2}%");
            Console.WriteLine($"Average: {average:F2}");

            
        }
    }
}
