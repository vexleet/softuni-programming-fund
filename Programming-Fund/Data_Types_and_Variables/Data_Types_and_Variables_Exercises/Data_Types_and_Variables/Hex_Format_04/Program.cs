using System;

namespace Hex_Format_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int num = Convert.ToInt32(hex, 16);
            Console.WriteLine(num);
        }
    }
}
