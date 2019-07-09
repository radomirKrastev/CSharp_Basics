using System;

namespace Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int countOfChanges = 0;

            for (int q = k; q <= 8; q++)
            {
                if (q % 2 != 0)
                {
                    continue;
                }
                for (int w = 9; w >= l; w--)
                {
                    if (w % 2 == 0)
                    {
                        continue;
                    }

                    for (int e = m; e <= 8; e++)
                    {
                        if (e % 2 != 0)
                        {
                            continue;
                        }

                        for (int r = 9; r >= n; r--)
                        {
                            if (r % 2 == 0)
                            {
                                continue;
                            }

                            string player1 = "" + q + w;
                            string player2 = "" + e + r;
                            if (countOfChanges >= 6)
                            {
                                break;
                            }

                            //bool number1Even = q % 2 == 0;
                            //bool number3Even = e % 2 == 0;

                            //bool number2Odd = w % 2 != 0;
                            //bool number4Odd = r % 2 != 0;



                            if (player1 != player2)
                            {
                                Console.WriteLine($"{player1} - {player2}");
                                countOfChanges++;
                            }
                            else
                            {
                                Console.WriteLine("Cannot change the same player.");
                            }
                        }
                    }
                }
            }

        }
    }
}
