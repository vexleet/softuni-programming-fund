using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RageQuit_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([^\d]+)(?=[1-9]+)([\d]+)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            var uniqueSymbols = string.Concat(matches.Cast<Match>().Select(x => x.Groups[1]))
                .ToUpper().Distinct().ToList();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count()}");

            foreach (Match item in matches)
            {
                var lettersToHit = item.Groups[1].Value.ToUpper();
                var timesToHit = int.Parse(item.Groups[2].Value);

                Console.Write(string.Concat(Enumerable.Repeat(lettersToHit, timesToHit)));    
            }
            Console.WriteLine();
        }
    }
}
