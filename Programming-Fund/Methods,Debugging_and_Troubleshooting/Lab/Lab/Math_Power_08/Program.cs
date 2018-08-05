using System;

namespace Math_Power_08
{
    class Program
    {
        static double RaiseToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }

        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(num, power);

            Console.WriteLine(result);
        }
    }
}
