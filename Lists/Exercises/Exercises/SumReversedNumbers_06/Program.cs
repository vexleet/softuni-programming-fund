using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> reversedNumbers = new List<int>();
            for (int i = 0; i < numbers.Count(); i++)
            {
                int currentNumber = ReverseNumber(numbers[i]);
                reversedNumbers.Add(Math.Abs(currentNumber));
            }

            Console.WriteLine(reversedNumbers.Sum()); 
        }

        static int ReverseNumber(int currentNumber)
        {
            char[] currentNumberToArray = currentNumber.ToString().ToCharArray();
            string reversedNumber = "";

            for (int i = currentNumberToArray.Length - 1; i >= 0; i--)
            {
                reversedNumber += currentNumberToArray[i];
            }

            return int.Parse(reversedNumber);
        }
    }
}
