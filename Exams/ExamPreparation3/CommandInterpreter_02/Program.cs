using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandInterpreter_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var splitInput = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var command = splitInput[0];

                switch (command)
                {
                    case "reverse":
                        int startReverse = int.Parse(splitInput[2]);
                        int countReverse = int.Parse(splitInput[4]);

                        if (startReverse >= 0 && countReverse >= 0 && countReverse <= numbers.Count()
                                && startReverse + countReverse <= numbers.Count())
                        {
                            numbers = ReverseNumbers(numbers, startReverse, countReverse);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        int countRollLeft = int.Parse(splitInput[1]);

                        if (countRollLeft >= 0)
                        {
                            numbers = RollLeftNumbers(numbers, countRollLeft);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollRight":
                        int countRollRight = int.Parse(splitInput[1]);

                        if (countRollRight >= 0)
                        {
                            numbers = RollRightNumbers(numbers, countRollRight);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "sort":
                        int startSort = int.Parse(splitInput[2]);
                        int countSort = int.Parse(splitInput[4]);

                        if (startSort >= 0 && countSort >= 0 && startSort < numbers.Count()
                            && startSort + countSort <= numbers.Count())
                        {
                            numbers = SortElements(numbers, startSort, countSort);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");

        }

        static List<string> ReverseNumbers(List<string> list, int start, int count)
        {
            List<string> getNumbers = new List<string>(list);
            getNumbers.Reverse(start, count);        
            return getNumbers;
        }

        static List<string> RollLeftNumbers(List<string> list, int count)
        {
            int counter = 0;
            while (counter < count % list.Count())
            {
                string firstElement = list[0];

                for (int j = 0; j < list.Count() - 1; j++)
                {
                    list[j] = list[j + 1];
                }

                list[list.Count() - 1] = firstElement;
                counter++;
            }

            return list;
        }

        static List<string> RollRightNumbers(List<string> list, int count)
        {
            int counter = 0;

            while (counter < count % list.Count())
            {
                string lastElement = list[list.Count() - 1];

                for (int j = list.Count() - 1; j > 0; j--)
                {
                    list[j] = list[j - 1];
                }

                list[0] = lastElement;
                counter++;
            }

            return list;
        }

        static List<string> SortElements(List<string> list, int start, int count)
        {
            List<string> getNumbers = new List<string>(list);
            getNumbers.Sort(start, count, StringComparer.InvariantCulture);

            return getNumbers;
        }

    }
}
