using System;

namespace NameProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            //string catNameOne = Console.ReadLine();
            //string catNameTwo = Console.ReadLine();
            //string dogNameOne = Console.ReadLine();
            //string dogNameTwo = Console.ReadLine();

            //Console.WriteLine($"My name is {name}, and I have two cats, {catNameOne} and {catNameTwo}. I also have two dogs {dogNameOne} and {dogNameTwo}.");

            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());

            Console.WriteLine($"My name is {firstName}, my second name is {secondName} and I am {age:F0} years old.");

        }
    }
}
