using System;

namespace SameWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            word1 = word1.ToLower();
            word2 = word2.ToLower();

            bool AreWordsEqual = word1 == word2;

            if (AreWordsEqual)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
