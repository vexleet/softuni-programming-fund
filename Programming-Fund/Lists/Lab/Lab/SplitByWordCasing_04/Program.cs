using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> words = input.Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> upperCaseWords = new List<string>();
            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            for(int i = 0; i < words.Count(); i++)
            {
                string currentWord = words[i];
                int lowerCaseCounter = 0;
                int upperCaseCounter = 0;

                foreach(char letter in currentWord)
                {
                    if (letter >= 97 && letter <=122)
                    {
                        lowerCaseCounter++;
                    }
                    else if(letter >= 65 && letter <= 90)
                    {
                        upperCaseCounter++;
                    }
                    
                }
                if(upperCaseCounter == currentWord.Length)
                {
                    upperCaseWords.Add(currentWord);
                }
                else if(lowerCaseCounter == currentWord.Length)
                {
                    lowerCaseWords.Add(currentWord);
                }
                else
                {
                    mixedCaseWords.Add(currentWord);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}
