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
            string pattern = @"^([^A-Za-z\d]+)\s([\d_]+)\s([^A-Za-z\d]+)([\d_]+)([A-Za-z]+)([\d_]+)([^A-Za-z\d]+)\s([\d_]+)\s([^A-Za-z\d]+)$";
            string checkInput = "";
            List<string> addElements = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                addElements.Add(Console.ReadLine());
            }

            checkInput = string.Join("", addElements).ToString();

            if (Regex.IsMatch(checkInput, pattern))
            {
                Match match = Regex.Match(checkInput, pattern);

                Console.WriteLine("Valid");
                Console.WriteLine(match.Groups[5].Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
