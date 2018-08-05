using System;

namespace Multiplication_Table_2._0_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            do
            {
                int mult = n * i;
                Console.WriteLine($"{n} X {i} = {mult}");
                i++;
            }
            while (i <= 10);
        }
    }
}
