using System;
using System.Collections.Generic;

namespace PrimesInGivenRange_07
{
    class Program
    {
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> result = new List<int>();
            
            for(var i = startNum; i<=endNum; i++)
            {
                bool isPrime = true;

                if (i < 2)
                {
                    continue;
                }
                else
                {
                    for(var j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if(i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        result.Add(i);
                    }

                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> result = FindPrimesInRange(startNum, endNum);
            foreach(var i in result)
            {
                if (result.IndexOf(i) == result.Count - 1)
                {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}
