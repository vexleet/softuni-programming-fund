using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> countNumbers = new List<int>();
            numbers.Sort();

            for(int i = 0; i < numbers.Count(); i++)
            {
                int counter = 1;
                for (int j = i + 1; j <= numbers.Count(); j++)
                {
                    if(j == numbers.Count())
                    {
                        Console.WriteLine($"{numbers[i]} -> {counter}");
                        i = j - 1;
                        break;
                    }
                    else if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine($"{numbers[i]} -> {counter}");
                        i = j - 1;
                        break;
                    }
                }
            }
        }
    }
}
