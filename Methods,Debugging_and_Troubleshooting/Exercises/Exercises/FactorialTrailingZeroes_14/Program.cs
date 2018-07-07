using System;
using System.Numerics;

namespace FactorialTrailingZeroes_14
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (var i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            string str = factorial.ToString();
            int countZeroes = 0;
            for(int i = str.Length - 1; i >= 0; i--)
            {
                if(str[i] == '0')
                {
                    countZeroes++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(countZeroes);
        }
    }
}
