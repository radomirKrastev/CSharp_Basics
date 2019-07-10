using System;

namespace NameFaminlyNameYearTown
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            string FamilyName = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string Town = Console.ReadLine();

            Console.WriteLine($"You are {Name} {FamilyName}, a {age}-years old person from {Town}.");
        }
    }
}
