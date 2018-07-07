using System;

namespace Game_Of_Number_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int combinations = 0;
            int lastCombination = 0;
            int firstN = 0;
            int secondN = 0;

            for(var i = n; i <= m; i++)
            {
                for(var j = n; j <= m; j++)
                {
                    if(currentSum == magicNumber)
                    {
                        firstN = i;
                        secondN = j - 1;
                        lastCombination = currentSum;
                    }
                    currentSum = i + j;
                    
                    combinations++;
                }
            }
            if (lastCombination == magicNumber)
            {
                Console.WriteLine($"Number found! {firstN} + {secondN} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
