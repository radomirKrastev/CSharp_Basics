using System;

namespace SafePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());

            int countOfPasswords = 0;


            //for (char i = '#'; i <= 55; i++)
            //{
            //    if (i == 55)
            //    {
            //        i = '#';
            //    }
            //    for (char j = '@'; j <= 96; j++)
            //    {
            //        if (j == 96)
            //        {
            //            j = '@';
            //        }

            char A = (char)35;
            char B = (char)64;

            for (int k = 1; k <= a; k++)
            {
                
                for (int l = 1; l <= b; l++)
                {

                    
                    if (A > 55)
                    {
                        A = (char)35;
                    }
                    if (B > 96)
                    {
                        B = (char)64;
                    }

                    if (countOfPasswords == maxPasswords)
                    {
                        break;
                    }

                    Console.Write($"{A}{B}{k}{l}{B}{A}|");
                    countOfPasswords++;

                    A++;
                    B++;


                }
            }
            
        }
    }
}
