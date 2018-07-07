using System;

namespace SieveOfEratosthenes_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if(n <= 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for(var i = 2; i <= n; i++)
                {
                    if (isPrime(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }

        static bool isPrime(long n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {

                for (var i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
