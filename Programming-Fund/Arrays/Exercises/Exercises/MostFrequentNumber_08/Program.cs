using System;
using System.Linq;

namespace MostFrequentNumber_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int bestCounter = counter;
            int frequentNumber = numbers[0];
            for(var i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                }
                if(bestCounter < counter)
                {
                    bestCounter = counter;
                    frequentNumber = numbers[i];
                }
                counter = 1;
            }
            Console.WriteLine(frequentNumber);
        }
    }
}
