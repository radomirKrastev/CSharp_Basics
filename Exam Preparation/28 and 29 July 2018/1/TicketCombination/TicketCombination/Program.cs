using System;

namespace TicketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            int countCombinations = 0;


            for (char nameStadium = 'B'; nameStadium <= 'L'; nameStadium++)
            {
                
                if (nameStadium % 2 != 0)
                {
                    continue;
                }
                if (countCombinations == number)
                {
                    break;
                }

                for (char nameSector = 'f'; nameSector >= 'a'; nameSector--)
                {
                    if (countCombinations == number)
                    {
                        break;
                    }
                    
                    for (char nameEntrence = 'A'; nameEntrence <= 'C'; nameEntrence++)
                    {
                        if (countCombinations == number)
                        {
                            break;
                        }
                        
                        for (int row = 1; row <= 10; row++)
                        {
                            if (countCombinations == number)
                            {
                                break;
                            }
                            
                            for (int seat = 10; seat >= 1; seat--)
                            {
                                
                                countCombinations++;

                                if (countCombinations == number)
                                {
                                    Console.WriteLine($"{nameStadium}{nameSector}{nameEntrence}{row}{seat}");
                                    Console.WriteLine("Prize: " + (nameStadium+nameSector+nameEntrence+row+seat)+" lv.");
                                    break;
                                }


                            }

                        }
                    }

                }

                

            }




            





        }
    }
}
