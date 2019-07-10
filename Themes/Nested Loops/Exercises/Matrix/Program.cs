using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int firstNum = a; firstNum<=b; firstNum++)
            {
                for (int secondNum = a; secondNum <= b; secondNum++)
                {
                    for (int thirdNum = c; thirdNum <= d; thirdNum++)
                    {
                        for (int fourthNum = c; fourthNum <= d; fourthNum++)
                        {
                            bool diagonalOneEqualDiagonalTwo = firstNum + fourthNum == secondNum + thirdNum;
                            bool firstLineDiffNumbers = firstNum != secondNum;
                            bool secondLineDiffNumbers = thirdNum != fourthNum;

                            if (diagonalOneEqualDiagonalTwo && firstLineDiffNumbers && secondLineDiffNumbers)
                            {
                                Console.WriteLine(""+firstNum+secondNum);
                                Console.WriteLine(""+thirdNum+fourthNum);
                                Console.WriteLine();
                            }
                            
                        }
                    }
                }
            }               
            


        }

    }
}
