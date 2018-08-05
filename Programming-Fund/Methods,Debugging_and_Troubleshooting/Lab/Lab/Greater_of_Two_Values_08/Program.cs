using System;

namespace Greater_of_Two_Values_08
{
    class Program
    {
        static int GetMax(int firstNumber, int secondNumber)
        {
            if(firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static char GetMax(char firstChar, char secondChar)
        {
            if(firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        static string GetMax(string firstString, string secondString)
        {
            if(firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if(type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result = GetMax(num1, num2);
                Console.WriteLine(result);
            }
            else if(type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                char result = GetMax(char1, char2);
                Console.WriteLine(result);
            }
            else if(type == "string")
            {
                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();
                string result = GetMax(string1, string2);
                Console.WriteLine(result);
            }
        }
    }
}
