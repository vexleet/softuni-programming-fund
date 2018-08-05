using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LettersChangeNumbers_8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] bigAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] smallAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();

            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char firstLetter = input[i][0];
                char lastLetter = input[i][input[i].Length - 1];
                decimal number = decimal.Parse(input[i].Substring(1, input[i].Length - 2));
                decimal result = 0;

                if(firstLetter > 90)
                {
                    int positionOfLetter = Array.IndexOf(smallAlpha, firstLetter) + 1;
                    result = number * positionOfLetter;
                }
                else
                {
                    int positionOfLetter = Array.IndexOf(bigAlpha, firstLetter) + 1;
                    result = number / positionOfLetter;
                }

                if (lastLetter > 90)
                {
                    int positionOfLetter = Array.IndexOf(smallAlpha, lastLetter) + 1;
                    result += positionOfLetter;
                }
                else
                {
                    int positionOfLetter = Array.IndexOf(bigAlpha, lastLetter) + 1;
                    result -= positionOfLetter;
                }

                sum += result;

            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
