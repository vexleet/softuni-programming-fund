using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long[] getBombNumberAndPower = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long sum = 0;

            long bombNumber = getBombNumberAndPower[0];
            int power = (int)getBombNumberAndPower[1];

            for (int i = 0; i < numbers.Count(); i++)
            {
                if(numbers[i] == bombNumber)
                {
                    numbers = DetonateNumbersFromLeft(numbers, i, power);
                    numbers = DetonateNumbersFromRight(numbers, numbers.IndexOf(bombNumber), power);
                    numbers.Remove(bombNumber);
                    i = 0;
                }
            }

            for (int i = 0; i < numbers.Count(); i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }

        static List<long> DetonateNumbersFromLeft(List<long> currentNumbers, int indexOfBombNumber, long bombPower)
        {
            indexOfBombNumber -= 1;

            for (int i = 0; i < bombPower; i++)
            {
                if (indexOfBombNumber >= 0)
                {
                    currentNumbers.RemoveAt(indexOfBombNumber);
                    indexOfBombNumber--;
                }
            }

            return currentNumbers;
        }

        static List<long> DetonateNumbersFromRight(List<long> currentNumbers, int indexOfBombNumber, long bombPower)
        {
            indexOfBombNumber += 1;

            for (int i = 0; i < bombPower; i++)
            {
                if(indexOfBombNumber < currentNumbers.Count())
                {
                    currentNumbers.RemoveAt(indexOfBombNumber);
                }               
            }

            return currentNumbers;
        }
    }
}
