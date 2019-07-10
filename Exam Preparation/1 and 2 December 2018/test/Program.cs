using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());

            int countOfPasswords = 0;

            char A = '\0';
            char B = '\0';

            for (char i = '#'; i <= 55; i++)
            {
                 A = i;
                if (i == 55)
                {
                    i = '#';
                }
            }

            for (char j = '@'; j <= 96; j++)
            {
                B = j;
                if (j == 96)
                {
                    j = '@';
                }
            }

            for (int k = 1; k<=a; k++)
            {
                for (int l = 1; l <= b; l++)
                {
                    Console.WriteLine($"{A}{B}{k}{l}{B}{A}|");
                    countOfPasswords++;
                    if(countOfPasswords == maxPasswords)
                    {
                        break;
                    }
                }
            }

        }
    }    
}
