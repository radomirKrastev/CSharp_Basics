using System;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBatches = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countBatches; i++)
            {
                string ingredient = Console.ReadLine();

                bool isingredientFlour = false;
                bool isingredientEgg = false;
                bool isingredientSugar = false;

                while (!isingredientEgg || !isingredientFlour || !isingredientSugar)
                {

                    if (ingredient == "flour")
                    {
                        isingredientFlour = true;
                    }
                    else if (ingredient == "eggs")
                    {
                        isingredientEgg = true;
                    }
                    else if (ingredient == "sugar")
                    {
                        isingredientSugar = true;
                    }

                    if (ingredient == "Bake!")
                    {


                        Console.WriteLine("The batter should contain flour, eggs and sugar!");

                    }

                    ingredient = Console.ReadLine();



                }

                

                while (ingredient != "Bake!")
                {
                    ingredient = Console.ReadLine();
                }

                if (ingredient == "Bake!" && (isingredientSugar && isingredientFlour && isingredientEgg))
                {
                    Console.WriteLine($"Baking batch number {i}...");
                }









            }

        }
    }
}
