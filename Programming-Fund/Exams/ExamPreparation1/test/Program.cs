using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"[@#\$\^]+";

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i].Length == 20)
                {
                    MatchCollection matches = Regex.Matches(input[i], pattern);

                    if(matches.Count == 0)
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                        continue;
                    }

                    if(matches.Count == 2)
                    {
                        if (!Regex.IsMatch(matches[0].Value, pattern))
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - 10{matches[0].Value[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - no match");
                        }
                        continue;
                    }

                    string leftHalf = matches[0].Value;
                    string rightHalf = matches[1].Value;

                    string addHalves = leftHalf + rightHalf;

                    if(addHalves.All(x => x == '$'))
                    {
                        Console.WriteLine($"ticket - \"{input[i]}\" - {addHalves.Length / 2}$");
                    }
                    else if(addHalves.All(x => x == '@'))
                    {
                        Console.WriteLine($"ticket - \"{input[i]}\" - {addHalves.Length / 2}@");
                    }
                    else if(addHalves.All(x => x == '#'))
                    {
                        Console.WriteLine($"ticket - \"{input[i]}\" - {addHalves.Length / 2}#");
                    }
                    else if(addHalves.All(x => x == '^'))
                    {
                        Console.WriteLine($"ticket - \"{input[i]}\" - {addHalves.Length / 2}^");
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
