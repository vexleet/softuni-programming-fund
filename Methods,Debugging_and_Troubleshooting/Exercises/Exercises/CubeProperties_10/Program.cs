using System;

namespace CubeProperties_10
{
    class Program
    {
        
        static void CalculateVolume(double num)
        {
            double volume = Math.Pow(num, 3);
            Console.WriteLine($"{volume:f2}");
        }

        static void CalculateArea(double num)
        {
            double area = 6 * Math.Pow(num, 2);
            Console.WriteLine($"{area:f2}");
        }

        static void CalculateFace(double num)
        {
            double face = Math.Sqrt(2 * Math.Pow(num, 2));
            Console.WriteLine($"{face:f2}");
        }

        static void CalculateSpace(double num)
        {
            double space = Math.Sqrt(3 * Math.Pow(num, 2));
            Console.WriteLine($"{space:f2}");
        }

        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if(parameter == "volume")
            {
                CalculateVolume(sideOfCube);
            }
            else if(parameter == "area")
            {
                CalculateArea(sideOfCube);
            }
            else if(parameter == "face")
            {
                CalculateFace(sideOfCube);
            }
            else if(parameter == "space")
            {
                CalculateSpace(sideOfCube);
            }
        }
    }
}
