using System;
using System.Linq;

namespace SumArrays_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len1 = array1.Length;
            int len2 = array2.Length;

            int[] arrayResult = new int[Math.Max(len1, len2)];

            for(var i = 0; i < arrayResult.Length; i++)
            {
                int sum = array1[i % len1] + array2[i % len2];
                arrayResult[i] = sum;
            }

            Console.WriteLine(string.Join(" ", arrayResult));
        }
    }
}
