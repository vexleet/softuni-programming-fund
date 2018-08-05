using System;

namespace Rectangle_Properties_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + height);
            decimal area = Convert.ToDecimal(width * height);
            double diagonal = Convert.ToDouble(Math.Sqrt((width * width) + (height * height)));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
