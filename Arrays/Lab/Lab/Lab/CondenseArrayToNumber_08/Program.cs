using System;
using System.Linq;

namespace CondenseArrayToNumber_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[array1.Length - 1];

            while(array1.Length > 1)
            {
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = array1[i] + array1[i + 1];
                }
                array1 = condensed;
                condensed = new int[array1.Length - 1];
            }

            Console.WriteLine(array1[0]);

        }
    }
}
