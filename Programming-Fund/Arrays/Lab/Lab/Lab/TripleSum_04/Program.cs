using System;
using System.Linq;

namespace TripleSum_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool availableSums = false;

            for (var i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                        availableSums = true;
                    }

                }
            }
            if (!availableSums)
            {
                Console.WriteLine("No");
            }
        }
    }
}
