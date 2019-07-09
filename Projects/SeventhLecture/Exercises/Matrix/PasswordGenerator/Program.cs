using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int firstNumber = 1; firstNumber<=n; firstNumber++)
            {
                for (int secondNumber = 1; secondNumber <= n; secondNumber++)
                {
                    for (char firstLetter = "abcdefghi"[0]; firstLetter < "abcdefghi"[l]; firstLetter++)
                    {
                        for (char secondLetter = "abcdefghi"[0]; secondLetter < "abcdefghi"[l]; secondLetter++)
                        {
                            for (int fifthNumber = 1; fifthNumber <= n; fifthNumber++)
                            {
                                if (fifthNumber > firstNumber && fifthNumber > secondNumber)
                                {
                                    Console.Write(""+firstNumber+secondNumber+firstLetter+secondLetter+fifthNumber+" ");
                                }
                                
                            }
                        }
                    }
                }
            }

        }
    }
}
