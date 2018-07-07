using System;

namespace Vowel_Or_Digit_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string getInput = Console.ReadLine();
            int x = 0;
            char a = 'A';

            if(Int32.TryParse(getInput, out x) == true)
            {
                Console.WriteLine("digit");
            }
            else if(char.TryParse(getInput, out a))
            {
                char symbol = Convert.ToChar(getInput);
                if((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                (symbol == 'o') || (symbol == 'u'))
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
