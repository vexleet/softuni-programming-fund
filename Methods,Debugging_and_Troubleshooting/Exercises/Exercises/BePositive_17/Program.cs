using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        long countSequences = long.Parse(Console.ReadLine());

        for (long i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            var numbers = new List<long>();

            for (long j = 0; j < input.Length; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    long num = long.Parse(input[j]);
                    numbers.Add(num);
                }
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                long currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(currentNum);

                    found = true;
                }
                else
                {
                    if(j + 1 >= numbers.Count)
                    {
                        currentNum += numbers[j];
                    }
                    else
                    {
                        currentNum += numbers[j + 1];
                    }

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    j++;
                }
            }
            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}