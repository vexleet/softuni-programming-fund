using System;

namespace Multiply_Evens_by_Odds_9
{
    class Program
    {
        private static int GetSumOfEvenNumbers(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                int lastDigit = n % 10;

                if(lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfOddNumbers(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;

                if (lastDigit % 2 == 1)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }
            return sum;
        }

        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenNumbers(n);
            int sumOdds = GetSumOfOddNumbers(n);
            return sumEvens * sumOdds;
        }

        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()) + 0);
            int result = GetMultipleOfEvensAndOdds(num);
            Console.WriteLine(result);
        }
    }
}
