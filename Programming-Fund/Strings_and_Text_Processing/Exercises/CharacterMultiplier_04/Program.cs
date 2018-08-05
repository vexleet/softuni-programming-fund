using System;
using System.Linq;

namespace CharacterMultiplier_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int getMaxLength = Math.Max(input[0].Length, input[1].Length);
            long sum = 0;

            for (int i = 0; i < getMaxLength; i++)
            {
                if(input[0].Length <= i)
                {
                    sum += input[1][i];
                }
                else if(input[1].Length <= i)
                {
                    sum += input[0][i];
                }
                else
                {
                    sum += input[1][i] * input[0][i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
