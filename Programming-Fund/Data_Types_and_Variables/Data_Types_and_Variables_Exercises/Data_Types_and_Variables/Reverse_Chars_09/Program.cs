using System;

namespace Reverse_Chars_09
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char lastLetter = char.Parse(Console.ReadLine());
            string allLetters = $"{firstLetter}{secondLetter}{lastLetter}";
            char[] result = allLetters.ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(result);
            
        }
    }
}
