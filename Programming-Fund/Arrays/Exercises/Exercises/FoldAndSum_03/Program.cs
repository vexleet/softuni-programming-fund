using System;
using System.Linq;

namespace FoldAndSum_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstRow = new int[numbers.Length / 2];
            int[] secondRow = new int[numbers.Length / 2];
            int[] sum = new int[numbers.Length / 2];
            int firstRowCounter = 0;
            int secondRowCounter = 0;

            for (int i = numbers.Length / 4; i < numbers.Length - (numbers.Length / 4); i++)
            {
                firstRow[firstRowCounter] = numbers[i];
                firstRowCounter++;
            }

            for(int i = numbers.Length / 4 - 1; i >= 0; i--)
            {
                secondRow[secondRowCounter] = numbers[i];
                secondRowCounter++;
            }

            for(int i = numbers.Length - 1; i >= numbers.Length - (numbers.Length / 4); i--)
            {
                secondRow[secondRowCounter] = numbers[i];
                secondRowCounter++;
            }

            for (int i = 0; i < firstRow.Length && i < secondRow.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
