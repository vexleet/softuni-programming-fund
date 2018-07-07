using System;

namespace Multiplication_Table_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(var i = 1; i <= 10; i++)
            {
                int mult = n * i;

                Console.WriteLine($"{n} X {i} = {mult}");
            }
        }
    }
}
