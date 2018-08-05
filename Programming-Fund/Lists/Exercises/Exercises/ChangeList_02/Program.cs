using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int endCommand = -1;

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if(command[0] == "Odd")
                {
                    endCommand = 1;
                    break;
                }
                else if(command[0] == "Even")
                {
                    endCommand = 0;
                    break;
                }

                string commandToManipulate = command[0];
                int element = int.Parse(command[1]);

                if(commandToManipulate == "Delete")
                {
                    numbers = DeleteElement(numbers, element);
                }
                else if(commandToManipulate == "Insert")
                {
                    int position = int.Parse(command[2]);
                    numbers = InsertElement(numbers, element, position);
                }
            }

            for (int i = 0; i < numbers.Count(); i++)
            {
                if(numbers[i] % 2 == endCommand)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }



        static List<int> DeleteElement(List<int> currentNumbers, int element)
        {
            for (int i = 0; i < currentNumbers.Count(); i++)
            {
                if(currentNumbers[i] == element)
                {
                    currentNumbers.RemoveAt(i);
                    i--;
                }
            }
            return currentNumbers;          
        }

        static List<int> InsertElement(List<int> currentNumbers, int element, int position)
        {       
            currentNumbers.Insert(position, element);          
            return currentNumbers;
        }
    }
}
