using System;
using System.Linq;

namespace EqualSums_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long equalSum = 0;
            bool availableSum = false;
            for (var i = 0; i < numbers.Length; i++)
            {
                long leftSum = 0;
                long rightSum = 0;

                for (var j = i; j >= 0; j--)
                {
                    leftSum += numbers[j];
                }

                for (int k = i; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                if(leftSum == rightSum)
                {
                    availableSum = true;
                    equalSum = i;
                }
            }
            if (!availableSum)
            {
                Console.WriteLine("no");
                return;
            }

            Console.WriteLine(equalSum);
        }
    }
}
