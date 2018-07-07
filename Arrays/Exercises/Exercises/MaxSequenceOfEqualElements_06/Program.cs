using System;
using System.Linq;

namespace MaxSequenceOfEqualElements_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int len = 1;
            int bestStart = start;
            int bestLen = len;
            for(var i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] == numbers[i - 1])
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
            while(counter < bestLen)
            {
                Console.Write($"{numbers[bestStart + counter]} ");
                counter++;
            }
            
        }
    }
}
