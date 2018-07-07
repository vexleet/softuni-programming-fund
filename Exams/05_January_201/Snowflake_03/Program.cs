using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Snowflake_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?:[^A-Za-z\d]+)
                (?:[\d_]+)
                (?:[^A-Za-z\d]+)(?:[\d_]+)([A-Za-z]+)(?:[\d_]+)(?:[^A-Za-z\d]+)
                (?:[\d_]+)
                (?:[^A-Za-z\d]+)$";

            string checkInput = string.Empty;
            List<string> addElements = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                addElements.Add(Console.ReadLine());
            }

            checkInput = $@"{addElements[0]}
                {addElements[1]}
                {addElements[2]}
                {addElements[3]}
                {addElements[4]}";

            if (Regex.IsMatch(checkInput, pattern))
            {
                Match match = Regex.Match(checkInput, pattern);

                Console.WriteLine("Valid");
                Console.WriteLine(match.Groups[1].Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
