using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling(((steps*1.0 / days)/steps)*100.0);
            double stepsPerDancer = stepsPerDay / dancers;

            if (stepsPerDay < 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {stepsPerDancer:F2}% steps to be learned per day.");
            }
            
            //$"Yes, they will succeed in that goal! {F2}%.";
            //$"No, they will not succeed in that goal! Required {F2}% steps to be learned per day.";

        }
    }
}
