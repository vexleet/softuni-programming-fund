using System;

namespace Calculate_Triangle_Area_07
{
    class Program
    {
        static double CalculateTriangeArea(double width, double height)
        {
            return width * height / 2;
        }

        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateTriangeArea(width, height);

            Console.WriteLine(area);
        }
    }
}
