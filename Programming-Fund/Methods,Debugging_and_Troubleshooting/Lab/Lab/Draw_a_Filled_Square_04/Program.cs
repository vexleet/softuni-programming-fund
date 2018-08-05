using System;

namespace Draw_a_Filled_Square_04
{
    class Program
    {
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string ('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for(var i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintHeaderRow(num);
            for(var i = 0; i < num - 2; i++)
            {
                PrintMiddleRow(num);
            }
            PrintHeaderRow(num);
        }
    }
}
