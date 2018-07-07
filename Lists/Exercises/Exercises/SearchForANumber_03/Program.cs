using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] manipulatingNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            numbers = TakeElements(numbers, manipulatingNumbers[0]);
            numbers = DeleteElements(numbers, manipulatingNumbers[1]);
            Console.WriteLine(CheckForElement(numbers, manipulatingNumbers[2]));
        }

        static List<int> TakeElements(List<int> currentNumbers, int numberOfElementsToTake)
        {
            List<int> numbersAfterManipulation = new List<int>();
            for (int i = 0; i < numberOfElementsToTake; i++)
            {
                numbersAfterManipulation.Add(currentNumbers[i]);
            }

            return numbersAfterManipulation;
        }

        static List<int> DeleteElements(List<int> currentNumbers, int numberOfElementsToDelete)
        {
            List<int> numbersAfterManipulation = currentNumbers;

            for (int i = 0; i < numberOfElementsToDelete; i++)
            {
                numbersAfterManipulation.RemoveAt(i);
                i--;
                numberOfElementsToDelete--;
            }

            return numbersAfterManipulation;
        }

        static string CheckForElement(List<int> currentNumbers, int element)
        {
            if (currentNumbers.Contains(element))
            {
                return "YES!";
            }
            return "NO!";
        }
    }
}
