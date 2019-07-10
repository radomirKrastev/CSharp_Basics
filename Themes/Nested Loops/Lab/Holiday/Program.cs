using System;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double disposableMoney = 0;
                double vacationCosts = double.Parse(Console.ReadLine());
                while (disposableMoney < vacationCosts)
                {
                    double savedSum = double.Parse(Console.ReadLine());
                    disposableMoney += savedSum;
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

            }

            
            
        }
    }
}
