using System;

namespace FiguresPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "square":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double perimeter = side * side;
                        Console.WriteLine($"{perimeter:F3}");
                        break;
                    }
                case "rectangle":
                    {
                        double width = double.Parse(Console.ReadLine());
                        double length = double.Parse(Console.ReadLine());
                        double perimeter = width * length;
                        Console.WriteLine($"{perimeter:F3}");
                        break;
                    }
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        double perimeter = Math.Pow(radius, 2) * Math.PI;
                        Console.WriteLine($"{perimeter:F3}");
                        break;
                    }
                case "triangle":
                    {
                        double height = double.Parse(Console.ReadLine());
                        double side = double.Parse(Console.ReadLine());
                        double area = (side * height)/2;
                        Console.WriteLine($"{area:F3}");
                        break;
                    }




                    
            }
              

            
            
        }
    }
}
