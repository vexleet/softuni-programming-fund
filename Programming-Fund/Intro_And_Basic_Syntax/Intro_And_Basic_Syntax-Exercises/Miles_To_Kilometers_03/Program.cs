using System;

namespace Miles_To_Kilometers_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double toKilometers = miles * 1.60934;
            Console.WriteLine($"{toKilometers:F2}");
        }
    }
}
