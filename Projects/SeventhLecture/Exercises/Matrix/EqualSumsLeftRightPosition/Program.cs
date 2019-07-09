using System;

namespace EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                int leftPositions = 0;
                int rightPositions = 0;
                int medianPosition = 0;
                string iAsString = i.ToString();
                for (int j = 0; j < iAsString.Length; j++)
                {
                    char p = iAsString[j];
                    int valuePosition = int.Parse(p.ToString());

                    if (j < 2)
                    {
                        leftPositions += valuePosition;
                    }
                    else if (j > 2)
                    {
                        rightPositions += valuePosition;
                    }
                    else
                    {
                        medianPosition += valuePosition;
                    }

                }

                if (rightPositions == leftPositions)
                {
                    Console.Write($"{i} ");
                }
                else if (leftPositions < rightPositions)
                {
                     if(leftPositions + medianPosition == rightPositions)
                     {
                        Console.Write($"{i} ");
                     }
                     
                }
                else if (rightPositions < leftPositions)
                {
                    if (rightPositions + medianPosition == leftPositions)
                    {
                        Console.Write($"{i} ");
                    }
                    
                }
            }
        }
    }
}
