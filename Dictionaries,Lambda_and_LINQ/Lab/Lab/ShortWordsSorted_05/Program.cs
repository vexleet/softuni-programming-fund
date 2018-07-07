using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToList();

            var wordsThatAreAtLessThan5Letters = words.Where(item => item.Length < 5);
            var orderWords = wordsThatAreAtLessThan5Letters.OrderBy(x => x).Distinct();

            Console.WriteLine(string.Join(", ", orderWords));
        }
    }
}
