using System;

namespace Test_Numbers_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for(var i = n; i>=1; i--)
            {
                for (var j = 1; j <= m; j++)
                {
                    if (sum >= max)
                    {
                        //Console.WriteLine($"{counter} combinations");
                        //Console.WriteLine($"Sum: {sum} >= {max}");
                        i = 0;
                        break;
                    }
                    sum += (3 * (i*j));
                    counter++;
                }
            }
            if (sum >= max)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {max}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
