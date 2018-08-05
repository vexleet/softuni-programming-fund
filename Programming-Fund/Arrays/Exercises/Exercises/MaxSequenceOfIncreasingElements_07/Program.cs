using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements_07
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long start = 0;
            long len = 1;
            long bestStart = start;
            long bestLen = len;
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    len++;
                    if (bestLen < len)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }


            }
            int counter = 0;
            while (counter < bestLen)
            {
                Console.Write($"{numbers[bestStart + counter]} ");
                counter++;
            }
        }
    }
}
