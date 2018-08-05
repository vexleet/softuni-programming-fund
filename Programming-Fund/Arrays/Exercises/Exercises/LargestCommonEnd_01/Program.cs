using System;
using System.Linq;

namespace LargestCommonEnd_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ').ToArray();
            string[] array2 = Console.ReadLine().Split(' ').ToArray();
            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < array1.Length && i < array2.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    leftCounter++;
                }
            }
            for (int j = 0; j < array1.Length && j < array2.Length; j++)
            {
                if (array1[array1.Length - 1 - j] == array2[array2.Length - 1 - j])
                {
                    rightCounter++;
                }
            }

            if (leftCounter > rightCounter)
            {
                Console.WriteLine(leftCounter);
            }
            else
            {
                Console.WriteLine(rightCounter);
            }

        }
    }
}

