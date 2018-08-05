using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeyReplacer_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialWordsInput = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern1 = @"([A-Za-z]+)(?:<|\\|\|)(?:.*)?(?:<|\||\\)([A-Za-z]+)";
            Regex r1 = new Regex(pattern1);
            
            MatchCollection m1 = r1.Matches(specialWordsInput);
            string start = "";
            string end = "";

            foreach (Match item in m1)
            {
                start = item.Groups[1].ToString();
                end = item.Groups[2].ToString();
            }

            string pattern2 = @"" + start + "(.*?)" + end + "";
            Regex r2 = new Regex(pattern2);
            MatchCollection m2 = r2.Matches(input);

            string emptyStringChecker = "";

            foreach (Match item in m2)
            {
                emptyStringChecker += item.Groups[1];
            }

            if(emptyStringChecker == "")
            {
                Console.WriteLine("Empty result");
                return;
            }
            Console.WriteLine(emptyStringChecker);
        }
    }
}
