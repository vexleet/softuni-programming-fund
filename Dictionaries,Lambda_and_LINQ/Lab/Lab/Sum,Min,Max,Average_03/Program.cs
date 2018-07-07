using System;
using System.Linq;

namespace Sum_Min_Max_Average_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfArray = int.Parse(Console.ReadLine());
            int[] nums = new int[lengthOfArray];

            for (int i = 0; i < lengthOfArray; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                nums[i] = currentNumber;
            }

            Console.WriteLine($"Sum = {nums.Sum()}");
            Console.WriteLine($"Min = {nums.Min()}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Average = {nums.Average()}");
        }
    }
}
