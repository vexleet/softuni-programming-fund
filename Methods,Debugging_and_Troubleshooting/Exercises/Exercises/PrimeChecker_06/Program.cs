using System;

namespace PrimeChecker_06
{
    class Program
    {
        static bool isPrime(long n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {

                for(var i = 2; i <= Math.Sqrt(n); i++)
                {
                    if(n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool check = isPrime(n);
            Console.WriteLine(check);
        }
    }
}
