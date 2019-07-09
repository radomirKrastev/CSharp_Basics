using System;

namespace SequenceOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sequence = 1;

            while (sequence <= n)
            {
                Console.WriteLine(sequence);
                sequence = sequence * 2 + 1;
            }

        }
    }
}
