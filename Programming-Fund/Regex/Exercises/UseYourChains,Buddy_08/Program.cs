using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UseYourChains_Buddy_08
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lettersFromAtoM = "ABCDEFGHIJKLM".ToLower().ToCharArray();
            char[] lettersFromNToZ = "NOPQRSTUVWXYZ".ToLower().ToCharArray();
            string decryptedMessages = "";

            string input = Console.ReadLine();
            string pattern = @"<p>(.*?)<\/p>";
            Regex regex1 = new Regex(pattern);

            MatchCollection matches = regex1.Matches(input);

            foreach (Match item in matches)
            {
                string currentSentence = item.Groups[1].Value;
                string currentMessage = "";
                for (int i = 0; i < currentSentence.Length; i++)
                {
                    char currentLetter = currentSentence[i];
                    if (lettersFromAtoM.Contains(currentLetter))
                    {
                        int getIndex = Array.IndexOf(lettersFromAtoM, currentLetter);
                        currentMessage += lettersFromNToZ[getIndex];
                    }
                    else if (lettersFromNToZ.Contains(currentLetter))
                    {
                        int getIndex = Array.IndexOf(lettersFromNToZ, currentLetter);
                        currentMessage += lettersFromAtoM[getIndex];
                    }
                    else if (int.TryParse(currentLetter.ToString(), out int result))
                    {
                        currentMessage += currentLetter;
                    }
                    else
                    {
                        currentMessage += " ";
                    }
                }
                decryptedMessages += currentMessage;
            }

            Console.WriteLine(Regex.Replace(decryptedMessages, @"\s+", " "));
        }
    }
}
