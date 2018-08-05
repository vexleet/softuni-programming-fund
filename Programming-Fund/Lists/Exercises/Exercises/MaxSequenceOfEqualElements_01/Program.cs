using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            int start = 0;
            int length = 1;
            int bestStart = start;
            int bestLength = length;

            for (int i = 1; i < numbers.Count(); i++)
            {
                if(numbers[i] == numbers[i - 1])
                {
                    length++;
                    if (bestLength < length)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    length = 1;
                }
                                                
            }

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write($"{numbers[bestStart + i]} ");
            }
        }
    }
}
