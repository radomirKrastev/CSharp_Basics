using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //char symbol = '@';
            //Console.WriteLine((int)symbol);
            //int number = 101;
            //Console.WriteLine((char)number);
            //string sum ="" + 'a' + 'b';
            //Console.WriteLine(sum);

            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 100;
            int lastDigit = number % 10;
            int rawSecondDigit = number / 10;
            int secondDigit = rawSecondDigit % 10;

            int rows = firstDigit + secondDigit;
            int columns = firstDigit + lastDigit;


            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= secondDigit;
                    }
                    else
                    {
                        number += lastDigit;
                    }

                    Console.Write($"{number} ");
                    if (c == columns - 1)
                    {
                        Console.Write(Environment.NewLine);
                    }
                }
                    
                        
                    
            }

        }
    }
}
