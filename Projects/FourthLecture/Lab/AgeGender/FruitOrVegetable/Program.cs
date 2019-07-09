using System;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitorvegetable = Console.ReadLine();



            if (fruitorvegetable == "banana" || fruitorvegetable == "apple" || fruitorvegetable == "kiwi"
                     || fruitorvegetable == "cherry" || fruitorvegetable == "lemon" || fruitorvegetable == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (fruitorvegetable == "tomato" || fruitorvegetable == "cucumber" || fruitorvegetable == "pepper"
                || fruitorvegetable == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
