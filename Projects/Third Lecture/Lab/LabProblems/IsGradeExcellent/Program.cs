using System;

namespace IsGradeExcellent
{
    class Program
    {
        static void Main(string[] args)
        {
            // read grade from console
            // make the check
            // true or false
            // write to console

            double grade = double.Parse(Console.ReadLine());
            double MinExcellentGradeValue = 5.5;
            bool IsGradeExcellent = grade >= MinExcellentGradeValue;

            if (IsGradeExcellent)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
