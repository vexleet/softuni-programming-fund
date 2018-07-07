using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowmen_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> defeatedAndSuicidedIndexes = new List<int>();
            List<int> wonNumbers = new List<int>();

            while(input.Count() > 1)
            {

                for (int i = 0; i < input.Count(); i++)
                {
                    int attacker = input[i];
                    int attackerIndex = i;
                    int targetIndex = attacker;

                    if (input[attackerIndex] == -9999999)
                    {
                        continue;
                    }

                    if (attacker > input.Count())
                    {
                        targetIndex = attacker % input.Count();
                    }
                    int target = input[targetIndex];
                    int difference = Math.Abs(attackerIndex - targetIndex);


                    if (difference == 0)
                    {
                        defeatedAndSuicidedIndexes.Add(target);
                        input[attackerIndex] = -9999999;
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                    }
                    else if (difference % 2 == 0)
                    {
                        defeatedAndSuicidedIndexes.Add(target);
                        input[targetIndex] = -9999999;
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                    }
                    else if(difference % 2 == 1)
                    {
                        defeatedAndSuicidedIndexes.Add(attacker);
                        
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                    }

                    wonNumbers = input.Where(x => x != -9999999).ToList();

                    if(wonNumbers.Count() == 1)
                    {
                        break;
                    }
                }

                input = input.Where(x => x != -9999999).ToList();
            }

        }
    }
}
