using System;

namespace Exchange_Variables_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");
            var tmp = num1;
            num1 = num2;
            num2 = tmp;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");
        }
    }
}
