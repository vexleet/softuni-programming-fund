using System;

namespace IndexOfLetters_09
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            string word = Console.ReadLine();

            for(var i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {Array.IndexOf(alpha, word[i])}");                               
            }

        }
    }
}
