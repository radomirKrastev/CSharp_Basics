﻿using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int counterCheckedBooks = 0;

            while (capacity > 0)
            {
                string takenBook = Console.ReadLine();
                

                if (searchedBook == takenBook)
                {
                    Console.WriteLine($"You checked {counterCheckedBooks} books and found it.");
                    break;
                }
                else
                {
                    counterCheckedBooks++;
                    capacity--;

                }


            }
            
            if(capacity == 0)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counterCheckedBooks} books.");
            }
             
        }
    }
}
