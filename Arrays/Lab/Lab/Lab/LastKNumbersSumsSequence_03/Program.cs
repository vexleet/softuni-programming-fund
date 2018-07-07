using System;

namespace LastKNumbersSumsSequence_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];
            array[0] = 1;

            for(var i = 1; i < n; i++)
            {
                long sum = 0;

                for (var j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += array[j];
                    }
                }
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ", array));

        }
    }
}
