using System;
using System.Numerics;

namespace Factorial_13
{
    class Program
    {        

        static void Main(string[] args)
        {
            BigInteger num = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for(var i = 1; i <= num; i ++) {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
