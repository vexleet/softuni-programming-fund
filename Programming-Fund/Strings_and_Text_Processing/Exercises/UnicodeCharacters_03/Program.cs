using System;
using System.Linq;

namespace UnicodeCharacters_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                var currentLetter = char.ConvertToUtf32(word, i);     
                Console.Write("\\u{0:x4}", Convert.ToUInt16(currentLetter));
            }
        }
    }
}
