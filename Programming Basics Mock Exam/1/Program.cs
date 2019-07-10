using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numberAsString = number.ToString();


            char c1 = numberAsString[0];
            char c2 = numberAsString[1];
            char c3 = numberAsString[2];
            int s1 = int.Parse(c1.ToString());
            int s2 = int.Parse(c2.ToString());
            int s3 = int.Parse(c3.ToString());

                
            for (int n3 = 1; n3 <= s3; n3++)
            {
                for (int n2 = 1; n2 <= s2; n2++)
                {
                    for (int n1 = 1; n1 <= s1; n1++)
                    {
                        int result = n3 * n2 * n1;
                        Console.WriteLine($"{n3} * {n2} * {n1} = {result};");
                    }
                }
            }




        }
    }
}
