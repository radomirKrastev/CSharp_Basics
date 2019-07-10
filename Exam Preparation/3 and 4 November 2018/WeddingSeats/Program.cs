using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastSector = Console.ReadLine();
            int rowsFirstSector = int.Parse(Console.ReadLine());
            int oddRowSeats = int.Parse(Console.ReadLine());

            int countSeats = 0;

            for(char sector = 'A'; sector<=lastSector[0]; sector++)
            {
                if (sector != 'A')
                {
                    rowsFirstSector += 1;
                }

                for(int rows = 1; rows<=rowsFirstSector; rows++)
                {
                    if (rows % 2 != 0)
                    {

                        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        for (char seat = 'a'; seat < alphabet.ToLower()[oddRowSeats]; seat++)
                        {
                            countSeats++;
                            Console.WriteLine($"{sector}{rows}{seat}");
                            
                        }
                    }

                    else
                    {

                        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        for (char seat = 'a'; seat < alphabet.ToLower()[oddRowSeats+2]; seat++)
                        {
                            countSeats++;
                            Console.WriteLine($"{sector}{rows}{seat}");
                            
                        }
                    }
                }
            }

            Console.WriteLine(countSeats);

        }
    }
}
