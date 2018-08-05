using System;

namespace MaxMethod_02
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int getMax = GetMax(num1, num2, num3);
            Console.WriteLine(getMax);
        }

        private static int GetMax(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b >= a && b >= c)
            {
                return b;
            }
            else if (c >= a && c >= b)
            {
                return c;
            }
            return 0;
        }
    }
}
