using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "print")
            {
                string currentCommand = command[0];

                switch (currentCommand)
                {
                    case "add":
                        numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;

                    case "addMany":
                        int pos = int.Parse(command[1]);

                        for (int i = 2; i < command.Length; i++)
                        {
                            numbers.Insert(pos, int.Parse(command[i]));
                            pos++;
                        }
                        break;

                    case "contains":
                        int indexOfElement = numbers.IndexOf(int.Parse(command[1]));
                        Console.WriteLine(indexOfElement);
                        break;

                    case "remove":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;

                    case "sumPairs":
                        List<int> SumOfPairsResult = new List<int>();
                        for (int i = 0; i < numbers.Count(); i += 2)
                        {
                            if (i != numbers.Count() - 1)
                            {
                                int sumPairs = numbers[i] + numbers[i + 1];
                                SumOfPairsResult.Add(sumPairs);
                            }
                            else
                            {
                                SumOfPairsResult.Add(numbers[i]);
                            }
                        }

                        numbers = SumOfPairsResult;
                        break;

                    case "shift":
                        int counter = 0;
                        while (counter < int.Parse(command[1]))
                        {
                            var tmp = numbers[0];
                            for (var i = 1; i < numbers.Count(); i++)
                            {
                                numbers[i - 1] = numbers[i];
                            }
                            numbers[numbers.Count() - 1] = tmp;
                            counter++;
                        }
                        break;
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine($"[{ string.Join(", ", numbers)}]");
        }
    }
}
