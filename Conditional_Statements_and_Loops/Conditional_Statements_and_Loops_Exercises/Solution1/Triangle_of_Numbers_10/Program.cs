using System;

namespace Triangle_of_Numbers_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(var i = 1; i<= number; i++)
            {
                for(var j = 1; j<=i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
