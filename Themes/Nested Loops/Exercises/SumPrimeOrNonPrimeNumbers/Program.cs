using System;

namespace SumPrimeOrNonPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            

            while (command != "stop")
            {
                int number = int.Parse(command);
                while (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    break;
                }

                int countDivisions = 0;
                for (int i=1; i<=number; i++)
                {

                    if (number % i == 0)
                    {
                        countDivisions++;
                    }
                }

                if (countDivisions <=2 &&number>0 && number!=1)
                {
                    sumPrime += number;
                }
                else if(countDivisions>2 && number>0 || number==1)
                {
                    sumNonPrime += number;
                }

                command = Console.ReadLine();

            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}
