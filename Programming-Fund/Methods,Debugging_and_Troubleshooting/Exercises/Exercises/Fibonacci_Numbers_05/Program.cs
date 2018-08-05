using System;

namespace Fibonacci_Numbers_05
{
    class Program
    {
        static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;

            for(var i = 0; i < n; i++)
            {
                int tmp = a;
                a = b;
                b += tmp;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = Fibonacci(n);
            Console.WriteLine(result);

        }
    }
}
