using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').Reverse().ToList();
            List<string> result = new List<string>();

            foreach (string i in numbers)
            {
                string[] test = i.Split(' ');
                foreach (string j in test)
                {
                    if (j != "")
                    {
                        result.Add(j);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
