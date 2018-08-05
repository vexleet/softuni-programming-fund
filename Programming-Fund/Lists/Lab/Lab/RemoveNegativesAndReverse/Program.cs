using System;
using System.Collections.Generic;
using System.Linq;
namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            foreach (int i in numbers)
            {
                if(i > 0) {
                    result.Add(i);
                }
            }
            result.Reverse();
            if(result.Count() == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
