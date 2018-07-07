using System;

namespace Printing_Triangle_03
{
    class Program
    {
        static void PrintTriangle(int num)
        {
            for(var i = 1; i <= num; i++)
            {
                for(var j = 1; j<= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }


            for(var i = num; i >= 1; i--)
            {
                int count = 1;

                for (var j = i; j>= 2; j--)
                {
                    Console.Write($"{count} ");
                    count++;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
    }
}
