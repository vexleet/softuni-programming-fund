using System;
using System.Text.RegularExpressions;

namespace ExtractEmails_01
{
    class Program
    {
        public static MatchCollection MatchCollection { get; private set; }

        static void Main(string[] args)
        {
            string pattern = @"\b(^|(?<=\s))[a-zA-Z0-9]+(\.|\-|_)?([a-zA-Z0-9]+)@([a-zA-Z]+([\.\-_][A-Za-z]+)+)(\b|(?=\s))";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}
