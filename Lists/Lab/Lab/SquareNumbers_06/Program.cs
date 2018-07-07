using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            foreach(int i in numbers)
            {
                if(Math.Sqrt(i) == (int)Math.Sqrt(i))
                {
                    result.Add(i);
                }
            }
            result.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
