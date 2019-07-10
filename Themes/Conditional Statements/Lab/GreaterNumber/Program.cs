using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read 2 numbers from console
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());



            // compare the numbers 
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else
            {
                Console.WriteLine(number2);
            }

            // write to console bigger number 


        }
    }
}
