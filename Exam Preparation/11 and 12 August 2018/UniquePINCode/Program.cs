using System;

namespace UniquePINCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            for(int i = 1; i<=number1; i++)
            {
                for (int j = 1; j <= number2; j++)
                {
                    int countDivisions = 0;
                    for(int h = 1; h<=j; h++)
                    {
                        if (j % h == 0)
                        {
                            countDivisions++;
                        }
                    }
                    for (int k = 1; k <= number3; k++)
                    {
                        if(i%2==0 && k%2==0 && (countDivisions==2 && j != 1))
                        {
                            Console.WriteLine(""+i+" "+j+" "+k);
                        }
                    }
                }
            }

        }
    }
}
