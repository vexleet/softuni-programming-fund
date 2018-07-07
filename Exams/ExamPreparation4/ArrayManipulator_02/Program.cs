using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(command != "end")
            {
                var currentCommand = command.Split(' ');

                switch (currentCommand[0])
                {
                    case "exchange":
                        int getIndexForExchange = int.Parse(currentCommand[1]);
                        
                        if(getIndexForExchange + 1 > array.Count())
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        List<int> getElements = array.Take(getIndexForExchange + 1).ToList();
                        array.RemoveRange(0, getIndexForExchange + 1);
                        foreach (var item in getElements)
                        {
                            array.Add(item);
                        }
                        break;
                    case "max":
                        string neededMax = currentCommand[1];

                        int bestMaxIndex = 0;
                        int bestMax = 0;
                        if(neededMax == "odd")
                        {
                            try
                            {
                                bestMax = array.First(x => x % 2 != 0);
                            }
                            catch
                            {
                                Console.WriteLine("No matches");
                                break;
                            }
                            for (int i = 0; i < array.Count(); i++)
                            {
                                if (array[i] % 2 != 0)
                                {
                                    if (array[i] >= bestMax)
                                    {
                                        bestMax = array[i];
                                        bestMaxIndex = i;
                                    }
                                }
                            }
                            Console.WriteLine(bestMaxIndex);
                        }
                        else
                        {
                            try
                            {
                                bestMax = array.First(x => x % 2 == 0);
                            }
                            catch
                            {
                                Console.WriteLine("No matches");
                                break;
                            }
                            for (int i = 0; i < array.Count(); i++)
                            {
                                if (array[i] % 2 == 0)
                                {
                                    if (array[i] >= bestMax)
                                    {
                                        bestMax = array[i];
                                        bestMaxIndex = i;
                                    }
                                }
                            }

                            Console.WriteLine(bestMaxIndex);
                        }
                        break;
                    case "min":
                        string neededMin = currentCommand[1];

                        int bestMinIndex = 0;
                        int bestMin = 0;
                        if (neededMin == "odd")
                        {
                            try
                            {
                                bestMin = array.First(x => x % 2 != 0);
                            }
                            catch
                            {
                                Console.WriteLine("No matches");
                                break;
                            }
                            for (int i = 0; i < array.Count(); i++)
                            {
                                if (array[i] % 2 != 0)
                                {
                                    if (array[i] <= bestMin)
                                    {
                                        bestMin = array[i];
                                        bestMinIndex = i;
                                    }
                                }
                            }

                            Console.WriteLine(bestMinIndex);
                        }
                        else
                        {
                            try
                            {
                                bestMin = array.First(x => x % 2 == 0);
                            }
                            catch
                            {
                                Console.WriteLine("No matches");
                                break;
                            }
                            for (int i = 0; i < array.Count(); i++)
                            {
                                if (array[i] % 2 == 0)
                                {
                                    if (array[i] <= bestMin)
                                    {
                                        bestMin = array[i];
                                        bestMinIndex = i;
                                    }
                                }
                            }
                            Console.WriteLine(bestMinIndex);
                        }
                        break;

                    case "first":
                        int countFirstElements = int.Parse(currentCommand[1]);
                        string neededFirst = currentCommand[2];
                        int counterFirst = 0;
                        List<int> firstElements = new List<int>();

                        if (countFirstElements > array.Count())
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        for (int i = 0; i < array.Count(); i++)
                        {
                            if(neededFirst == "odd")
                            {
                                if(array[i] % 2 != 0)
                                {
                                    firstElements.Add(array[i]);
                                    counterFirst++;
                                }
                            }
                            else
                            {
                                if(array[i] % 2 == 0)
                                {
                                    firstElements.Add(array[i]);
                                    counterFirst++;
                                }
                            }

                            if(counterFirst == countFirstElements)
                            {
                                break;
                            }
                        }

                        Console.WriteLine($"[{string.Join(", ", firstElements)}]");
                        break;

                    case "last":
                        int countLastElements = int.Parse(currentCommand[1]);
                        string neededLast = currentCommand[2];
                        int counterLast = 0;
                        List<int> lastElements = new List<int>();

                        if (countLastElements > array.Count())
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        for (int i = array.Count() - 1; i >= 0; i--)
                        {
                            if (neededLast == "odd")
                            {
                                if (array[i] % 2 != 0)
                                {
                                    lastElements.Add(array[i]);
                                    counterLast++;
                                }
                            }
                            else
                            {
                                if (array[i] % 2 == 0)
                                {
                                    lastElements.Add(array[i]);
                                    counterLast++;
                                }
                            }

                            if (counterLast == countLastElements)
                            {
                                break;
                            }
                        }
                        lastElements.Reverse();
                        Console.WriteLine($"[{string.Join(", ", lastElements)}]");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");

        }
    }
}
