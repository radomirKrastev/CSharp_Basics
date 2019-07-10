using System;

namespace Rectangle2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());

            var area = a * b;

            Console.WriteLine("area = " + area);

        }
    }
}
