using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractMiddle1_2Or3Elements_09
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var listOfStrings = new List<string>();

            if(array1.Length == 1)
            {
                Console.WriteLine($"{{ {array1[0]} }}");
                return;
            }
            if (array1.Length % 2 == 0)
            {
                int start = array1.Length / 2 - 1;
                for (int i = array1.Length / 2 - 1; i < array1.Length - start; i++)
                {
                    listOfStrings.Add(array1[i].ToString());
                }
            }
            else
            {
                int start = array1.Length / 2 - 1;
                for (int i = start; i < array1.Length - start; i++)
                {
                    listOfStrings.Add(array1[i].ToString());
                }
            }

            string[] result = listOfStrings.ToArray();
            Console.WriteLine($"{{ {string.Join(", ", result)} }}");

        }
    }
}