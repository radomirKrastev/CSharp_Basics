using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    int sum = number1 + number2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {sum} - odd");
                    }
                    break;

                case '-':
                    int difference = number1 - number2;
                    if (difference % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {difference} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {difference} - odd");
                    }
                    break;

                case '*':
                    int product = number1 * number2;
                    if (product % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {product} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {product} - odd");
                    }
                    break;

                case '/':
                    if (number2  == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        double division = number1 * 1.0 / number2;
                        Console.WriteLine($"{number1} / {number2} = {division:F2}");
                    }
                    break;
                case '%':
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        double result = number1  % number2;
                        Console.WriteLine($"{number1} % {number2} = {result}");
                    }
                    break;
            }

        }
    }
}
