using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3NumbersOtherSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int i = 0;

            while(i < 3)
            {
                if (nums.Count() == 0) break;

                int maxNumber = nums.Max();      
                Console.Write($"{maxNumber} ");
                nums.Remove(maxNumber);
                i++;
            }

        }
    }
}
