using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integersInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int skip = integersInput[0];
            int end = integersInput[1];

            string input = Console.ReadLine();
            string pattern = @"\|\<(?:\w{" + skip + @"})(?=(\w{0," + end + "}))";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            var list = matches.Cast<Match>().Select(match => match.Groups[1]).ToList();
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
