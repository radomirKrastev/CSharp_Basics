using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hourPlus15 = hours * 60 + minutes + 15;

            int Hour = hourPlus15 / 60;
            int Minute = hourPlus15 % 60;

            if(Hour == 24)
            {
                Hour = 0;
            }


            if (Minute < 10)
            {
                Console.WriteLine(Hour + ":0" + Minute);
            }
            else
            {
                Console.WriteLine(Hour + ":" + Minute);
            }



        }
    }
}
