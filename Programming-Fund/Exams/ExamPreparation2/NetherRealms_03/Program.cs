using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demonNames = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(d => d).ToArray();

            for (int i = 0; i < demonNames.Length; i++)
            {
                MatchCollection getLetters = Regex.Matches(demonNames[i], @"[^\d\.\+\-\*\/\s\,]");
                MatchCollection getDigits = Regex.Matches(demonNames[i], @"[\-\+]?\d+(?:\.\d+)?");
                double health = 0;
                decimal damage = 0;

                foreach (Match item in getLetters)
                {
                    health += char.Parse(item.Value);
                }

                foreach (Match item in getDigits)
                {
                    damage += decimal.Parse(item.Value);
                }

                MatchCollection getMultipliersAndDivision = Regex.Matches(demonNames[i], @"(\*|\/)");

                foreach (Match item in getMultipliersAndDivision)
                {
                    if (item.Value == "*")
                    {
                        damage *= 2;
                    }
                    else if (item.Value == "/")
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine($"{demonNames[i]} - {health} health, {damage:F2} damage");
            }
        }
    }
}