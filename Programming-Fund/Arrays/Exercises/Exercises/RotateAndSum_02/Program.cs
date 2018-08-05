using System;
using System.Linq;

namespace RotateAndSum_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotateK = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotateK; i++)
            {
                int tmp = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j >= 1; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = tmp;

                for (int k = 0; k < numbers.Length; k++)
                {
                    sum[k] += numbers[k];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
