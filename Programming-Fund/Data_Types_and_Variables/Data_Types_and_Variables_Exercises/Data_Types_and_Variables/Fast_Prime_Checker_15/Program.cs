using System;

namespace Fast_Prime_Checker_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                bool checkPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        checkPrime = false;
                        break;
                    }
                }
                if(i >= 2)
                {
                    Console.WriteLine($"{i} -> {checkPrime}");
                }
            }

        }
    }
}
