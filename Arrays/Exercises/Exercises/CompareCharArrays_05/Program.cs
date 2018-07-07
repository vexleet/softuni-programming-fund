using System;
using System.Linq;

namespace CompareCharArrays_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLetters = Console.ReadLine().Split(' ').ToArray();
            string[] secondLetters = Console.ReadLine().Split(' ').ToArray();

            string firstLettersToString = string.Join("", firstLetters);
            string secondLettersToString = string.Join("", secondLetters);
            if (firstLettersToString.CompareTo(secondLettersToString) >= 1)
            {
                Console.WriteLine(secondLettersToString);
                Console.WriteLine(firstLettersToString);
            }
            else
            {
                Console.WriteLine(firstLettersToString);
                Console.WriteLine(secondLettersToString);
            }
        }
    }
}
