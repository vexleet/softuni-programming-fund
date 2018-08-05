using System;

namespace GeometryCalculator_11
{
    class Program
    {
        static double CalculateTriangleArea(double side, double height)
        {
            return 0.5 * (side * height);
        } 

        static double CalculateSquareArea(double side)
        {
            return Math.Pow(side, 2);
        }

        static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if(figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double area = CalculateTriangleArea(side, height);
                Console.WriteLine($"{area:f2}");
            }

            else if(figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());

                double area = CalculateSquareArea(side);
                Console.WriteLine($"{area:f2}");
            }
            else if(figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double area = CalculateRectangleArea(width, height);
                Console.WriteLine($"{area:f2}");
            }
            else if(figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double circleRadius = CalculateCircleArea(radius);
                Console.WriteLine($"{circleRadius:f2}");
            }

        }
    }
}
